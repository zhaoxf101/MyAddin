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
	public class HR_ExpBusEttFactory:Common.Business.HR_ExpBusEtt
    {
        public static Common.Business.HR_ExpBusEtt Fetch(HR_ExpBusEtt data)
        {
            Common.Business.HR_ExpBusEtt item = (Common.Business.HR_ExpBusEtt)Activator.CreateInstance(typeof(Common.Business.HR_ExpBusEtt));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.EttItemCode = data.EttItemCode;
				                item.Period = data.Period;
				                item.BillNo = data.BillNo;
				                item.ExpBusCode = data.ExpBusCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_ExpBusEtt>();
                var i = (from p in ctx.DataContext.HR_ExpBusEtt.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.EttItemCode = i.EttItemCode;
										this.Period = i.Period;
										this.BillNo = i.BillNo;
										this.ExpBusCode = i.ExpBusCode;
					}
            }
        }
	}

	public class HR_ExpBusEttsFactory : Common.Business.HR_ExpBusEtts
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_ExpBusEtt
                        select HR_ExpBusEttFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_ExpBusEtt
                        select HR_ExpBusEttFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_ExpBusEtt>();
                var i = (from p in ctx.DataContext.HR_ExpBusEtt.Where(exp)
                         select HR_ExpBusEttFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_ExpBusEtt>();
                var i = from p in ctx.DataContext.HR_ExpBusEtt.Where(exp)
                         select HR_ExpBusEttFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
