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
	public class PM_BudFDExpItemResFactory:Common.Business.PM_BudFDExpItemRes
    {
        public static Common.Business.PM_BudFDExpItemRes Fetch(PM_BudFDExpItemRes data)
        {
            Common.Business.PM_BudFDExpItemRes item = (Common.Business.PM_BudFDExpItemRes)Activator.CreateInstance(typeof(Common.Business.PM_BudFDExpItemRes));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AppNo = data.AppNo;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemRow = data.ExpItemRow;
				                item.ResouItemCode = data.ResouItemCode;
				                item.Year = data.Year;
				                item.ProjCode = data.ProjCode;
				                item.Active = data.Active;
				                item.IsAdd = data.IsAdd;
				                item.CanChg = data.CanChg;
				                item.FDAmt = data.FDAmt;
				                item.BudAmt = data.BudAmt;
				                item.FDQty = data.FDQty;
				                item.BudQty = data.BudQty;
				                item.IsPbuy = data.IsPbuy;
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
				var exp = lambda.Resolve<PM_BudFDExpItemRes>();
                var i = (from p in ctx.DataContext.PM_BudFDExpItemRes.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AppNo = i.AppNo;
										this.TaskCode = i.TaskCode;
										this.ExpItemRow = i.ExpItemRow;
										this.ResouItemCode = i.ResouItemCode;
										this.Year = i.Year;
										this.ProjCode = i.ProjCode;
										this.Active = i.Active;
										this.IsAdd = i.IsAdd;
										this.CanChg = i.CanChg;
										this.FDAmt = i.FDAmt;
										this.BudAmt = i.BudAmt;
										this.FDQty = i.FDQty;
										this.BudQty = i.BudQty;
										this.IsPbuy = i.IsPbuy;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_BudFDExpItemRessFactory : Common.Business.PM_BudFDExpItemRess
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_BudFDExpItemRes
                        select PM_BudFDExpItemResFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_BudFDExpItemRes
                        select PM_BudFDExpItemResFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_BudFDExpItemRes>();
                var i = (from p in ctx.DataContext.PM_BudFDExpItemRes.Where(exp)
                         select PM_BudFDExpItemResFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_BudFDExpItemRes>();
                var i = from p in ctx.DataContext.PM_BudFDExpItemRes.Where(exp)
                         select PM_BudFDExpItemResFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
