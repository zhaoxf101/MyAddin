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
	public class PM_TaskFundFactory:Common.Business.PM_TaskFund
    {
        public static Common.Business.PM_TaskFund Fetch(PM_TaskFund data)
        {
            Common.Business.PM_TaskFund item = (Common.Business.PM_TaskFund)Activator.CreateInstance(typeof(Common.Business.PM_TaskFund));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.FundCode = data.FundCode;
				                item.FundExpTypeCode = data.FundExpTypeCode;
				                item.FundBudAreaCode = data.FundBudAreaCode;
				                item.FundFinAreaCode = data.FundFinAreaCode;
				                item.PBudExpFunCode = data.PBudExpFunCode;
				                item.IsPirFund = data.IsPirFund;
				                item.IsInPirFund = data.IsInPirFund;
				                item.AccCode = data.AccCode;
				                item.FAccCode = data.FAccCode;
				                item.BAccCode = data.BAccCode;
				                item.ExpSort = data.ExpSort;
				                item.IsExpSort = data.IsExpSort;
				                item.IsSpecial = data.IsSpecial;
				                item.IsInCtrl = data.IsInCtrl;
				                item.IsChkIn = data.IsChkIn;
				                item.IsFreeze = data.IsFreeze;
				                item.MaxDeficit = data.MaxDeficit;
				                item.IsBudItem = data.IsBudItem;
				                item.IsFinItem = data.IsFinItem;
				                item.IsCarryOver = data.IsCarryOver;
				                item.IsCarryOverIn = data.IsCarryOverIn;
				                item.IsCarryRedu = data.IsCarryRedu;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_TaskFund>();
                var i = (from p in ctx.DataContext.PM_TaskFund.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.FundCode = i.FundCode;
										this.FundExpTypeCode = i.FundExpTypeCode;
										this.FundBudAreaCode = i.FundBudAreaCode;
										this.FundFinAreaCode = i.FundFinAreaCode;
										this.PBudExpFunCode = i.PBudExpFunCode;
										this.IsPirFund = i.IsPirFund;
										this.IsInPirFund = i.IsInPirFund;
										this.AccCode = i.AccCode;
										this.FAccCode = i.FAccCode;
										this.BAccCode = i.BAccCode;
										this.ExpSort = i.ExpSort;
										this.IsExpSort = i.IsExpSort;
										this.IsSpecial = i.IsSpecial;
										this.IsInCtrl = i.IsInCtrl;
										this.IsChkIn = i.IsChkIn;
										this.IsFreeze = i.IsFreeze;
										this.MaxDeficit = i.MaxDeficit;
										this.IsBudItem = i.IsBudItem;
										this.IsFinItem = i.IsFinItem;
										this.IsCarryOver = i.IsCarryOver;
										this.IsCarryOverIn = i.IsCarryOverIn;
										this.IsCarryRedu = i.IsCarryRedu;
					}
            }
        }
	}

	public class PM_TaskFundsFactory : Common.Business.PM_TaskFunds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_TaskFund
                        select PM_TaskFundFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_TaskFund
                        select PM_TaskFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_TaskFund>();
                var i = (from p in ctx.DataContext.PM_TaskFund.Where(exp)
                         select PM_TaskFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_TaskFund>();
                var i = from p in ctx.DataContext.PM_TaskFund.Where(exp)
                         select PM_TaskFundFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
