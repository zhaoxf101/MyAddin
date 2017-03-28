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
	public class FI_ExpBusEcoSubFundFactory:Common.Business.FI_ExpBusEcoSubFund
    {
        public static Common.Business.FI_ExpBusEcoSubFund Fetch(FI_ExpBusEcoSubFund data)
        {
            Common.Business.FI_ExpBusEcoSubFund item = (Common.Business.FI_ExpBusEcoSubFund)Activator.CreateInstance(typeof(Common.Business.FI_ExpBusEcoSubFund));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpBusCode = data.ExpBusCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.FundCode = data.FundCode;
				                item.Amt = data.Amt;
				                item.AdjAmt = data.AdjAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ExpBusEcoSubFund>();
                var i = (from p in ctx.DataContext.FI_ExpBusEcoSubFund.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpBusCode = i.ExpBusCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.FundCode = i.FundCode;
										this.Amt = i.Amt;
										this.AdjAmt = i.AdjAmt;
					}
            }
        }
	}

	public class FI_ExpBusEcoSubFundsFactory : Common.Business.FI_ExpBusEcoSubFunds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpBusEcoSubFund
                        select FI_ExpBusEcoSubFundFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpBusEcoSubFund
                        select FI_ExpBusEcoSubFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpBusEcoSubFund>();
                var i = (from p in ctx.DataContext.FI_ExpBusEcoSubFund.Where(exp)
                         select FI_ExpBusEcoSubFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpBusEcoSubFund>();
                var i = from p in ctx.DataContext.FI_ExpBusEcoSubFund.Where(exp)
                         select FI_ExpBusEcoSubFundFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
