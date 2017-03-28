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
	public class PM_ExpItemLedgerFactory:Common.Business.PM_ExpItemLedger
    {
        public static Common.Business.PM_ExpItemLedger Fetch(PM_ExpItemLedger data)
        {
            Common.Business.PM_ExpItemLedger item = (Common.Business.PM_ExpItemLedger)Activator.CreateInstance(typeof(Common.Business.PM_ExpItemLedger));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Year = data.Year;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemRow = data.ExpItemRow;
				                item.Freeze = data.Freeze;
				                item.ExpItemCode = data.ExpItemCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.PBudExpItemCode = data.PBudExpItemCode;
				                item.PBudExpFunCode = data.PBudExpFunCode;
				                item.IsBudCtrl = data.IsBudCtrl;
				                item.IsSpecial = data.IsSpecial;
				                item.MaterialCode = data.MaterialCode;
				                item.FDAmt = data.FDAmt;
				                item.LRAmt = data.LRAmt;
				                item.BudAmt = data.BudAmt;
				                item.AdjAmt = data.AdjAmt;
				                item.ExpAmt = data.ExpAmt;
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
				var exp = lambda.Resolve<PM_ExpItemLedger>();
                var i = (from p in ctx.DataContext.PM_ExpItemLedger.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Year = i.Year;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ExpItemRow = i.ExpItemRow;
										this.Freeze = i.Freeze;
										this.ExpItemCode = i.ExpItemCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.PBudExpItemCode = i.PBudExpItemCode;
										this.PBudExpFunCode = i.PBudExpFunCode;
										this.IsBudCtrl = i.IsBudCtrl;
										this.IsSpecial = i.IsSpecial;
										this.MaterialCode = i.MaterialCode;
										this.FDAmt = i.FDAmt;
										this.LRAmt = i.LRAmt;
										this.BudAmt = i.BudAmt;
										this.AdjAmt = i.AdjAmt;
										this.ExpAmt = i.ExpAmt;
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

	public class PM_ExpItemLedgersFactory : Common.Business.PM_ExpItemLedgers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ExpItemLedger
                        select PM_ExpItemLedgerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ExpItemLedger
                        select PM_ExpItemLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ExpItemLedger>();
                var i = (from p in ctx.DataContext.PM_ExpItemLedger.Where(exp)
                         select PM_ExpItemLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ExpItemLedger>();
                var i = from p in ctx.DataContext.PM_ExpItemLedger.Where(exp)
                         select PM_ExpItemLedgerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
