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
	public class PM_AllotAppFundFactory:Common.Business.PM_AllotAppFund
    {
        public static Common.Business.PM_AllotAppFund Fetch(PM_AllotAppFund data)
        {
            Common.Business.PM_AllotAppFund item = (Common.Business.PM_AllotAppFund)Activator.CreateInstance(typeof(Common.Business.PM_AllotAppFund));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AllotAppNo = data.AllotAppNo;
				                item.TaskCode = data.TaskCode;
				                item.FundCode = data.FundCode;
				                item.ProjCode = data.ProjCode;
				                item.FDAmt = data.FDAmt;
				                item.AppAmt = data.AppAmt;
				                item.CAccCode = data.CAccCode;
				                item.DAccCode = data.DAccCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_AllotAppFund>();
                var i = (from p in ctx.DataContext.PM_AllotAppFund.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AllotAppNo = i.AllotAppNo;
										this.TaskCode = i.TaskCode;
										this.FundCode = i.FundCode;
										this.ProjCode = i.ProjCode;
										this.FDAmt = i.FDAmt;
										this.AppAmt = i.AppAmt;
										this.CAccCode = i.CAccCode;
										this.DAccCode = i.DAccCode;
					}
            }
        }
	}

	public class PM_AllotAppFundsFactory : Common.Business.PM_AllotAppFunds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_AllotAppFund
                        select PM_AllotAppFundFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_AllotAppFund
                        select PM_AllotAppFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_AllotAppFund>();
                var i = (from p in ctx.DataContext.PM_AllotAppFund.Where(exp)
                         select PM_AllotAppFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_AllotAppFund>();
                var i = from p in ctx.DataContext.PM_AllotAppFund.Where(exp)
                         select PM_AllotAppFundFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
