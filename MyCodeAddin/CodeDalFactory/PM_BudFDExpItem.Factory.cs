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
	public class PM_BudFDExpItemFactory:Common.Business.PM_BudFDExpItem
    {
        public static Common.Business.PM_BudFDExpItem Fetch(PM_BudFDExpItem data)
        {
            Common.Business.PM_BudFDExpItem item = (Common.Business.PM_BudFDExpItem)Activator.CreateInstance(typeof(Common.Business.PM_BudFDExpItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AppNo = data.AppNo;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemRow = data.ExpItemRow;
				                item.Year = data.Year;
				                item.ProjCode = data.ProjCode;
				                item.ExpItemCode = data.ExpItemCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.PBudExpItemCode = data.PBudExpItemCode;
				                item.IsResBud = data.IsResBud;
				                item.Active = data.Active;
				                item.IsAdd = data.IsAdd;
				                item.CanChg = data.CanChg;
				                item.FDAmt = data.FDAmt;
				                item.ResFDSum = data.ResFDSum;
				                item.BudAmt = data.BudAmt;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.PFDAmt = data.PFDAmt;
				                item.TFDAmt = data.TFDAmt;
				                item.EFDAmt = data.EFDAmt;
				                item.PName = data.PName;
				                item.TName = data.TName;
				                item.ExpItemName = data.ExpItemName;
				                item.Ecode = data.Ecode;
				                item.EName = data.EName;
				                item.PBudAmt = data.PBudAmt;
				                item.TBudAmt = data.TBudAmt;
				                item.EBudAmt = data.EBudAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_BudFDExpItem>();
                var i = (from p in ctx.DataContext.PM_BudFDExpItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AppNo = i.AppNo;
										this.TaskCode = i.TaskCode;
										this.ExpItemRow = i.ExpItemRow;
										this.Year = i.Year;
										this.ProjCode = i.ProjCode;
										this.ExpItemCode = i.ExpItemCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.PBudExpItemCode = i.PBudExpItemCode;
										this.IsResBud = i.IsResBud;
										this.Active = i.Active;
										this.IsAdd = i.IsAdd;
										this.CanChg = i.CanChg;
										this.FDAmt = i.FDAmt;
										this.ResFDSum = i.ResFDSum;
										this.BudAmt = i.BudAmt;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.PFDAmt = i.PFDAmt;
										this.TFDAmt = i.TFDAmt;
										this.EFDAmt = i.EFDAmt;
										this.PName = i.PName;
										this.TName = i.TName;
										this.ExpItemName = i.ExpItemName;
										this.Ecode = i.Ecode;
										this.EName = i.EName;
										this.PBudAmt = i.PBudAmt;
										this.TBudAmt = i.TBudAmt;
										this.EBudAmt = i.EBudAmt;
					}
            }
        }
	}

	public class PM_BudFDExpItemsFactory : Common.Business.PM_BudFDExpItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_BudFDExpItem
                        select PM_BudFDExpItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_BudFDExpItem
                        select PM_BudFDExpItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_BudFDExpItem>();
                var i = (from p in ctx.DataContext.PM_BudFDExpItem.Where(exp)
                         select PM_BudFDExpItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_BudFDExpItem>();
                var i = from p in ctx.DataContext.PM_BudFDExpItem.Where(exp)
                         select PM_BudFDExpItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
