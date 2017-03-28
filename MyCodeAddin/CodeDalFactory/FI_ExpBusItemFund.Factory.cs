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
	public class FI_ExpBusItemFundFactory:Common.Business.FI_ExpBusItemFund
    {
        public static Common.Business.FI_ExpBusItemFund Fetch(FI_ExpBusItemFund data)
        {
            Common.Business.FI_ExpBusItemFund item = (Common.Business.FI_ExpBusItemFund)Activator.CreateInstance(typeof(Common.Business.FI_ExpBusItemFund));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.CostCtr = data.CostCtr;
				                item.ExpBusCode = data.ExpBusCode;
				                item.ExpItemId = data.ExpItemId;
				                item.FundCode = data.FundCode;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemCode = data.ExpItemCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
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
				var exp = lambda.Resolve<FI_ExpBusItemFund>();
                var i = (from p in ctx.DataContext.FI_ExpBusItemFund.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.CostCtr = i.CostCtr;
										this.ExpBusCode = i.ExpBusCode;
										this.ExpItemId = i.ExpItemId;
										this.FundCode = i.FundCode;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ExpItemCode = i.ExpItemCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.Amt = i.Amt;
					}
            }
        }
	}

	public class FI_ExpBusItemFundsFactory : Common.Business.FI_ExpBusItemFunds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpBusItemFund
                        select FI_ExpBusItemFundFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpBusItemFund
                        select FI_ExpBusItemFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpBusItemFund>();
                var i = (from p in ctx.DataContext.FI_ExpBusItemFund.Where(exp)
                         select FI_ExpBusItemFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpBusItemFund>();
                var i = from p in ctx.DataContext.FI_ExpBusItemFund.Where(exp)
                         select FI_ExpBusItemFundFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
