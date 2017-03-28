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
	public class PM_ProjectLedgerFactory:Common.Business.PM_ProjectLedger
    {
        public static Common.Business.PM_ProjectLedger Fetch(PM_ProjectLedger data)
        {
            Common.Business.PM_ProjectLedger item = (Common.Business.PM_ProjectLedger)Activator.CreateInstance(typeof(Common.Business.PM_ProjectLedger));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Year = data.Year;
				                item.ProjCode = data.ProjCode;
				                item.IsBudAppCtrl = data.IsBudAppCtrl;
				                item.IsFoucsAppro = data.IsFoucsAppro;
				                item.IsFlowAppro = data.IsFlowAppro;
				                item.IsAllotFund = data.IsAllotFund;
				                item.Active = data.Active;
				                item.Freeze = data.Freeze;
				                item.IsAdd = data.IsAdd;
				                item.StatusCode = data.StatusCode;
				                item.BudCheckMemo = data.BudCheckMemo;
				                item.ContrastCode1 = data.ContrastCode1;
				                item.ContrastCode2 = data.ContrastCode2;
				                item.MaxDeficit = data.MaxDeficit;
				                item.LRAmt = data.LRAmt;
				                item.FDAmt = data.FDAmt;
				                item.BudAmt = data.BudAmt;
				                item.AdjAmt = data.AdjAmt;
				                item.LRLoanAmt = data.LRLoanAmt;
				                item.LoanAmt = data.LoanAmt;
				                item.WoffAmt = data.WoffAmt;
				                item.ExpAmt = data.ExpAmt;
				                item.OrdAmt = data.OrdAmt;
				                item.FIOrdAmt = data.FIOrdAmt;
				                item.RateAmt = data.RateAmt;
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
				var exp = lambda.Resolve<PM_ProjectLedger>();
                var i = (from p in ctx.DataContext.PM_ProjectLedger.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Year = i.Year;
										this.ProjCode = i.ProjCode;
										this.IsBudAppCtrl = i.IsBudAppCtrl;
										this.IsFoucsAppro = i.IsFoucsAppro;
										this.IsFlowAppro = i.IsFlowAppro;
										this.IsAllotFund = i.IsAllotFund;
										this.Active = i.Active;
										this.Freeze = i.Freeze;
										this.IsAdd = i.IsAdd;
										this.StatusCode = i.StatusCode;
										this.BudCheckMemo = i.BudCheckMemo;
										this.ContrastCode1 = i.ContrastCode1;
										this.ContrastCode2 = i.ContrastCode2;
										this.MaxDeficit = i.MaxDeficit;
										this.LRAmt = i.LRAmt;
										this.FDAmt = i.FDAmt;
										this.BudAmt = i.BudAmt;
										this.AdjAmt = i.AdjAmt;
										this.LRLoanAmt = i.LRLoanAmt;
										this.LoanAmt = i.LoanAmt;
										this.WoffAmt = i.WoffAmt;
										this.ExpAmt = i.ExpAmt;
										this.OrdAmt = i.OrdAmt;
										this.FIOrdAmt = i.FIOrdAmt;
										this.RateAmt = i.RateAmt;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_ProjectLedgersFactory : Common.Business.PM_ProjectLedgers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ProjectLedger
                        select PM_ProjectLedgerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ProjectLedger
                        select PM_ProjectLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ProjectLedger>();
                var i = (from p in ctx.DataContext.PM_ProjectLedger.Where(exp)
                         select PM_ProjectLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ProjectLedger>();
                var i = from p in ctx.DataContext.PM_ProjectLedger.Where(exp)
                         select PM_ProjectLedgerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
