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
	public class PM_ModTaskFundFactory:Common.Business.PM_ModTaskFund
    {
        public static Common.Business.PM_ModTaskFund Fetch(PM_ModTaskFund data)
        {
            Common.Business.PM_ModTaskFund item = (Common.Business.PM_ModTaskFund)Activator.CreateInstance(typeof(Common.Business.PM_ModTaskFund));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.FundCode = data.FundCode;
				                item.FundBudAreaCode = data.FundBudAreaCode;
				                item.PBudExpFunCode = data.PBudExpFunCode;
				                item.FundExpTypeCode = data.FundExpTypeCode;
				                item.AccCode = data.AccCode;
				                item.IsPirFund = data.IsPirFund;
				                item.IsBudItem = data.IsBudItem;
				                item.IsFinItem = data.IsFinItem;
				                item.IsDeficit = data.IsDeficit;
				                item.IsCarryOver = data.IsCarryOver;
				                item.IsFreeze = data.IsFreeze;
				                item.IsSpecial = data.IsSpecial;
				                item.ExpSort = data.ExpSort;
				                item.IsExpSort = data.IsExpSort;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_ModTaskFund>();
                var i = (from p in ctx.DataContext.PM_ModTaskFund.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.FundCode = i.FundCode;
										this.FundBudAreaCode = i.FundBudAreaCode;
										this.PBudExpFunCode = i.PBudExpFunCode;
										this.FundExpTypeCode = i.FundExpTypeCode;
										this.AccCode = i.AccCode;
										this.IsPirFund = i.IsPirFund;
										this.IsBudItem = i.IsBudItem;
										this.IsFinItem = i.IsFinItem;
										this.IsDeficit = i.IsDeficit;
										this.IsCarryOver = i.IsCarryOver;
										this.IsFreeze = i.IsFreeze;
										this.IsSpecial = i.IsSpecial;
										this.ExpSort = i.ExpSort;
										this.IsExpSort = i.IsExpSort;
					}
            }
        }
	}

	public class PM_ModTaskFundsFactory : Common.Business.PM_ModTaskFunds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ModTaskFund
                        select PM_ModTaskFundFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ModTaskFund
                        select PM_ModTaskFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ModTaskFund>();
                var i = (from p in ctx.DataContext.PM_ModTaskFund.Where(exp)
                         select PM_ModTaskFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ModTaskFund>();
                var i = from p in ctx.DataContext.PM_ModTaskFund.Where(exp)
                         select PM_ModTaskFundFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
