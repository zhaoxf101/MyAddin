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
	public class FI_ExpBusSubFundFactory:Common.Business.FI_ExpBusSubFund
    {
        public static Common.Business.FI_ExpBusSubFund Fetch(FI_ExpBusSubFund data)
        {
            Common.Business.FI_ExpBusSubFund item = (Common.Business.FI_ExpBusSubFund)Activator.CreateInstance(typeof(Common.Business.FI_ExpBusSubFund));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpBusCode = data.ExpBusCode;
				                item.ExpItemId = data.ExpItemId;
				                item.ResId = data.ResId;
				                item.FundCode = data.FundCode;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemCode = data.ExpItemCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.ResouItemCode = data.ResouItemCode;
				                item.Amt = data.Amt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ExpBusSubFund>();
                var i = (from p in ctx.DataContext.FI_ExpBusSubFund.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpBusCode = i.ExpBusCode;
										this.ExpItemId = i.ExpItemId;
										this.ResId = i.ResId;
										this.FundCode = i.FundCode;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ExpItemCode = i.ExpItemCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.ResouItemCode = i.ResouItemCode;
										this.Amt = i.Amt;
					}
            }
        }
	}

	public class FI_ExpBusSubFundsFactory : Common.Business.FI_ExpBusSubFunds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpBusSubFund
                        select FI_ExpBusSubFundFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpBusSubFund
                        select FI_ExpBusSubFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpBusSubFund>();
                var i = (from p in ctx.DataContext.FI_ExpBusSubFund.Where(exp)
                         select FI_ExpBusSubFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpBusSubFund>();
                var i = from p in ctx.DataContext.FI_ExpBusSubFund.Where(exp)
                         select FI_ExpBusSubFundFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
