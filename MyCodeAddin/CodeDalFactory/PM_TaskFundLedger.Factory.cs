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
	public class PM_TaskFundLedgerFactory:Common.Business.PM_TaskFundLedger
    {
        public static Common.Business.PM_TaskFundLedger Fetch(PM_TaskFundLedger data)
        {
            Common.Business.PM_TaskFundLedger item = (Common.Business.PM_TaskFundLedger)Activator.CreateInstance(typeof(Common.Business.PM_TaskFundLedger));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Year = data.Year;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.FundCode = data.FundCode;
				                item.FundBudAreaCode = data.FundBudAreaCode;
				                item.FundFinAreaCode = data.FundFinAreaCode;
				                item.AccCode = data.AccCode;
				                item.BAccCode = data.BAccCode;
				                item.FAccCode = data.FAccCode;
				                item.PBudExpFunCode = data.PBudExpFunCode;
				                item.FundExpTypeCode = data.FundExpTypeCode;
				                item.ExpSort = data.ExpSort;
				                item.IsExpSort = data.IsExpSort;
				                item.IsBudItem = data.IsBudItem;
				                item.IsFinItem = data.IsFinItem;
				                item.IsCarryOver = data.IsCarryOver;
				                item.IsCarryOverIn = data.IsCarryOverIn;
				                item.IsCarryRedu = data.IsCarryRedu;
				                item.IsSpecial = data.IsSpecial;
				                item.IsInCtrl = data.IsInCtrl;
				                item.IsChkIn = data.IsChkIn;
				                item.IsFreeze = data.IsFreeze;
				                item.MaxDeficit = data.MaxDeficit;
				                item.LRAmt = data.LRAmt;
				                item.BudAmt = data.BudAmt;
				                item.AdjAmt = data.AdjAmt;
				                item.ExpAmt = data.ExpAmt;
				                item.LRLoanAmt = data.LRLoanAmt;
				                item.LoanAmt = data.LoanAmt;
				                item.WoffAmt = data.WoffAmt;
				                item.LRInAmt = data.LRInAmt;
				                item.InAmt = data.InAmt;
				                item.OrdAmt = data.OrdAmt;
				                item.FIOrdAmt = data.FIOrdAmt;
				                item.BUnCaAmt = data.BUnCaAmt;
				                item.InUnCaAmt = data.InUnCaAmt;
				                item.PBudAmt = data.PBudAmt;
				                item.PAdjAmt = data.PAdjAmt;
				                item.DisAmt = data.DisAmt;
				                item.AccuAssAmt = data.AccuAssAmt;
				                item.AccuInAmt = data.AccuInAmt;
				                item.AccuExpAmt = data.AccuExpAmt;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_TaskFundLedger>();
                var i = (from p in ctx.DataContext.PM_TaskFundLedger.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Year = i.Year;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.FundCode = i.FundCode;
										this.FundBudAreaCode = i.FundBudAreaCode;
										this.FundFinAreaCode = i.FundFinAreaCode;
										this.AccCode = i.AccCode;
										this.BAccCode = i.BAccCode;
										this.FAccCode = i.FAccCode;
										this.PBudExpFunCode = i.PBudExpFunCode;
										this.FundExpTypeCode = i.FundExpTypeCode;
										this.ExpSort = i.ExpSort;
										this.IsExpSort = i.IsExpSort;
										this.IsBudItem = i.IsBudItem;
										this.IsFinItem = i.IsFinItem;
										this.IsCarryOver = i.IsCarryOver;
										this.IsCarryOverIn = i.IsCarryOverIn;
										this.IsCarryRedu = i.IsCarryRedu;
										this.IsSpecial = i.IsSpecial;
										this.IsInCtrl = i.IsInCtrl;
										this.IsChkIn = i.IsChkIn;
										this.IsFreeze = i.IsFreeze;
										this.MaxDeficit = i.MaxDeficit;
										this.LRAmt = i.LRAmt;
										this.BudAmt = i.BudAmt;
										this.AdjAmt = i.AdjAmt;
										this.ExpAmt = i.ExpAmt;
										this.LRLoanAmt = i.LRLoanAmt;
										this.LoanAmt = i.LoanAmt;
										this.WoffAmt = i.WoffAmt;
										this.LRInAmt = i.LRInAmt;
										this.InAmt = i.InAmt;
										this.OrdAmt = i.OrdAmt;
										this.FIOrdAmt = i.FIOrdAmt;
										this.BUnCaAmt = i.BUnCaAmt;
										this.InUnCaAmt = i.InUnCaAmt;
										this.PBudAmt = i.PBudAmt;
										this.PAdjAmt = i.PAdjAmt;
										this.DisAmt = i.DisAmt;
										this.AccuAssAmt = i.AccuAssAmt;
										this.AccuInAmt = i.AccuInAmt;
										this.AccuExpAmt = i.AccuExpAmt;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_TaskFundLedgersFactory : Common.Business.PM_TaskFundLedgers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_TaskFundLedger
                        select PM_TaskFundLedgerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_TaskFundLedger
                        select PM_TaskFundLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_TaskFundLedger>();
                var i = (from p in ctx.DataContext.PM_TaskFundLedger.Where(exp)
                         select PM_TaskFundLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_TaskFundLedger>();
                var i = from p in ctx.DataContext.PM_TaskFundLedger.Where(exp)
                         select PM_TaskFundLedgerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
