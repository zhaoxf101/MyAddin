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
	public class PM_WoffProjFundFactory:Common.Business.PM_WoffProjFund
    {
        public static Common.Business.PM_WoffProjFund Fetch(PM_WoffProjFund data)
        {
            Common.Business.PM_WoffProjFund item = (Common.Business.PM_WoffProjFund)Activator.CreateInstance(typeof(Common.Business.PM_WoffProjFund));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.WoffCode = data.WoffCode;
				                item.FundCode = data.FundCode;
				                item.WoffAmt = data.WoffAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_WoffProjFund>();
                var i = (from p in ctx.DataContext.PM_WoffProjFund.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.WoffCode = i.WoffCode;
										this.FundCode = i.FundCode;
										this.WoffAmt = i.WoffAmt;
					}
            }
        }
	}

	public class PM_WoffProjFundsFactory : Common.Business.PM_WoffProjFunds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_WoffProjFund
                        select PM_WoffProjFundFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_WoffProjFund
                        select PM_WoffProjFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_WoffProjFund>();
                var i = (from p in ctx.DataContext.PM_WoffProjFund.Where(exp)
                         select PM_WoffProjFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_WoffProjFund>();
                var i = from p in ctx.DataContext.PM_WoffProjFund.Where(exp)
                         select PM_WoffProjFundFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
