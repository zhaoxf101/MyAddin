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
	public class PM_TuiLedgerFactory:Common.Business.PM_TuiLedger
    {
        public static Common.Business.PM_TuiLedger Fetch(PM_TuiLedger data)
        {
            Common.Business.PM_TuiLedger item = (Common.Business.PM_TuiLedger)Activator.CreateInstance(typeof(Common.Business.PM_TuiLedger));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AccYear = data.AccYear;
				                item.ClassCode = data.ClassCode;
				                item.LAmt = data.LAmt;
				                item.UAmt = data.UAmt;
				                item.FDAmt = data.FDAmt;
				                item.AppAmt = data.AppAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_TuiLedger>();
                var i = (from p in ctx.DataContext.PM_TuiLedger.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AccYear = i.AccYear;
										this.ClassCode = i.ClassCode;
										this.LAmt = i.LAmt;
										this.UAmt = i.UAmt;
										this.FDAmt = i.FDAmt;
										this.AppAmt = i.AppAmt;
					}
            }
        }
	}

	public class PM_TuiLedgersFactory : Common.Business.PM_TuiLedgers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_TuiLedger
                        select PM_TuiLedgerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_TuiLedger
                        select PM_TuiLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_TuiLedger>();
                var i = (from p in ctx.DataContext.PM_TuiLedger.Where(exp)
                         select PM_TuiLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_TuiLedger>();
                var i = from p in ctx.DataContext.PM_TuiLedger.Where(exp)
                         select PM_TuiLedgerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
