using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF;
using EF.Data;
using EF.Linq;
using EF.Server;
using EFramework.DalLinq;

namespace Common.DalFactory
{
	public class HR_ExpEttItemSubFactory:Common.Business.HR_ExpEttItemSub
    {
        public static Common.Business.HR_ExpEttItemSub Fetch(HR_ExpEttItemSub data)
        {
            Common.Business.HR_ExpEttItemSub item = (Common.Business.HR_ExpEttItemSub)Activator.CreateInstance(typeof(Common.Business.HR_ExpEttItemSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.EttItemCode = data.EttItemCode;
				                item.SalaryItemCode = data.SalaryItemCode;
				                item.Per = data.Per;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_ExpEttItemSub>();
                var i = (from p in ctx.DataContext.HR_ExpEttItemSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.EttItemCode = i.EttItemCode;
										this.SalaryItemCode = i.SalaryItemCode;
										this.Per = i.Per;
					}
            }
        }
	}

	public class HR_ExpEttItemSubsFactory : Common.Business.HR_ExpEttItemSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_ExpEttItemSub
                        select HR_ExpEttItemSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }

		private void DataPortal_Fetch(Paging page)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = (from p in ctx.DataContext.HR_ExpEttItemSub
                        select HR_ExpEttItemSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }

        private void DataPortal_Fetch(PagigExpress page)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var exp = page.Lambda.Resolve<HR_ExpEttItemSub>();
                var i = (from p in ctx.DataContext.HR_ExpEttItemSub.Where(exp)
                         select HR_ExpEttItemSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var exp = lambda.Resolve<HR_ExpEttItemSub>();
                var i = from p in ctx.DataContext.HR_ExpEttItemSub.Where(exp)
                         select HR_ExpEttItemSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
