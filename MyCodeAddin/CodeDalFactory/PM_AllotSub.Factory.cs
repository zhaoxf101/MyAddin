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
	public class PM_AllotSubFactory:Common.Business.PM_AllotSub
    {
        public static Common.Business.PM_AllotSub Fetch(PM_AllotSub data)
        {
            Common.Business.PM_AllotSub item = (Common.Business.PM_AllotSub)Activator.CreateInstance(typeof(Common.Business.PM_AllotSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AllotAppNo = data.AllotAppNo;
				                item.AllotItemCode = data.AllotItemCode;
				                item.MaxAllotRate = data.MaxAllotRate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_AllotSub>();
                var i = (from p in ctx.DataContext.PM_AllotSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AllotAppNo = i.AllotAppNo;
										this.AllotItemCode = i.AllotItemCode;
										this.MaxAllotRate = i.MaxAllotRate;
					}
            }
        }
	}

	public class PM_AllotSubsFactory : Common.Business.PM_AllotSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_AllotSub
                        select PM_AllotSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_AllotSub
                        select PM_AllotSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_AllotSub>();
                var i = (from p in ctx.DataContext.PM_AllotSub.Where(exp)
                         select PM_AllotSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_AllotSub>();
                var i = from p in ctx.DataContext.PM_AllotSub.Where(exp)
                         select PM_AllotSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
