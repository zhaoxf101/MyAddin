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
	public class PM_TaskLedgerFactory:Common.Business.PM_TaskLedger
    {
        public static Common.Business.PM_TaskLedger Fetch(PM_TaskLedger data)
        {
            Common.Business.PM_TaskLedger item = (Common.Business.PM_TaskLedger)Activator.CreateInstance(typeof(Common.Business.PM_TaskLedger));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Year = data.Year;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.SBudExpFunCode = data.SBudExpFunCode;
				                item.Freeze = data.Freeze;
				                item.IsBudItem = data.IsBudItem;
				                item.IsFinItem = data.IsFinItem;
				                item.IsBudCtrl = data.IsBudCtrl;
				                item.IsSpecial = data.IsSpecial;
				                item.ExpAcctCode1 = data.ExpAcctCode1;
				                item.ExpAcctCode2 = data.ExpAcctCode2;
				                item.MaxDeficit = data.MaxDeficit;
				                item.LRAmt = data.LRAmt;
				                item.FDAmt = data.FDAmt;
				                item.BudAmt = data.BudAmt;
				                item.AdjAmt = data.AdjAmt;
				                item.ExpAmt = data.ExpAmt;
				                item.LRLoanAmt = data.LRLoanAmt;
				                item.LoanAmt = data.LoanAmt;
				                item.WoffAmt = data.WoffAmt;
				                item.OrdAmt = data.OrdAmt;
				                item.FIOrdAmt = data.FIOrdAmt;
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
				var exp = lambda.Resolve<PM_TaskLedger>();
                var i = (from p in ctx.DataContext.PM_TaskLedger.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Year = i.Year;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.SBudExpFunCode = i.SBudExpFunCode;
										this.Freeze = i.Freeze;
										this.IsBudItem = i.IsBudItem;
										this.IsFinItem = i.IsFinItem;
										this.IsBudCtrl = i.IsBudCtrl;
										this.IsSpecial = i.IsSpecial;
										this.ExpAcctCode1 = i.ExpAcctCode1;
										this.ExpAcctCode2 = i.ExpAcctCode2;
										this.MaxDeficit = i.MaxDeficit;
										this.LRAmt = i.LRAmt;
										this.FDAmt = i.FDAmt;
										this.BudAmt = i.BudAmt;
										this.AdjAmt = i.AdjAmt;
										this.ExpAmt = i.ExpAmt;
										this.LRLoanAmt = i.LRLoanAmt;
										this.LoanAmt = i.LoanAmt;
										this.WoffAmt = i.WoffAmt;
										this.OrdAmt = i.OrdAmt;
										this.FIOrdAmt = i.FIOrdAmt;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_TaskLedgersFactory : Common.Business.PM_TaskLedgers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_TaskLedger
                        select PM_TaskLedgerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_TaskLedger
                        select PM_TaskLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_TaskLedger>();
                var i = (from p in ctx.DataContext.PM_TaskLedger.Where(exp)
                         select PM_TaskLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_TaskLedger>();
                var i = from p in ctx.DataContext.PM_TaskLedger.Where(exp)
                         select PM_TaskLedgerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
