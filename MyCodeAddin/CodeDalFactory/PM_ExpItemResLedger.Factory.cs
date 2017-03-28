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
	public class PM_ExpItemResLedgerFactory:Common.Business.PM_ExpItemResLedger
    {
        public static Common.Business.PM_ExpItemResLedger Fetch(PM_ExpItemResLedger data)
        {
            Common.Business.PM_ExpItemResLedger item = (Common.Business.PM_ExpItemResLedger)Activator.CreateInstance(typeof(Common.Business.PM_ExpItemResLedger));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Year = data.Year;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemRow = data.ExpItemRow;
				                item.ResouItemCode = data.ResouItemCode;
				                item.IsPBuy = data.IsPBuy;
				                item.Freeze = data.Freeze;
				                item.Active = data.Active;
				                item.FDQty = data.FDQty;
				                item.BudQty = data.BudQty;
				                item.LRAmt = data.LRAmt;
				                item.FDAmt = data.FDAmt;
				                item.BudAmt = data.BudAmt;
				                item.AdjAmt = data.AdjAmt;
				                item.ExpAmt = data.ExpAmt;
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
				var exp = lambda.Resolve<PM_ExpItemResLedger>();
                var i = (from p in ctx.DataContext.PM_ExpItemResLedger.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Year = i.Year;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ExpItemRow = i.ExpItemRow;
										this.ResouItemCode = i.ResouItemCode;
										this.IsPBuy = i.IsPBuy;
										this.Freeze = i.Freeze;
										this.Active = i.Active;
										this.FDQty = i.FDQty;
										this.BudQty = i.BudQty;
										this.LRAmt = i.LRAmt;
										this.FDAmt = i.FDAmt;
										this.BudAmt = i.BudAmt;
										this.AdjAmt = i.AdjAmt;
										this.ExpAmt = i.ExpAmt;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_ExpItemResLedgersFactory : Common.Business.PM_ExpItemResLedgers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ExpItemResLedger
                        select PM_ExpItemResLedgerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ExpItemResLedger
                        select PM_ExpItemResLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ExpItemResLedger>();
                var i = (from p in ctx.DataContext.PM_ExpItemResLedger.Where(exp)
                         select PM_ExpItemResLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ExpItemResLedger>();
                var i = from p in ctx.DataContext.PM_ExpItemResLedger.Where(exp)
                         select PM_ExpItemResLedgerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
