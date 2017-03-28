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
	public class PM_BudFDResListFactory:Common.Business.PM_BudFDResList
    {
        public static Common.Business.PM_BudFDResList Fetch(PM_BudFDResList data)
        {
            Common.Business.PM_BudFDResList item = (Common.Business.PM_BudFDResList)Activator.CreateInstance(typeof(Common.Business.PM_BudFDResList));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AppNo = data.AppNo;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemRow = data.ExpItemRow;
				                item.ResRow = data.ResRow;
				                item.Year = data.Year;
				                item.ProjCode = data.ProjCode;
				                item.ResouItemCode = data.ResouItemCode;
				                item.ResName = data.ResName;
				                item.SpecType = data.SpecType;
				                item.UnitCode = data.UnitCode;
				                item.Mfrs = data.Mfrs;
				                item.Memo = data.Memo;
				                item.TechReq = data.TechReq;
				                item.Freeze = data.Freeze;
				                item.FDAmt = data.FDAmt;
				                item.BudAmt = data.BudAmt;
				                item.FDQty = data.FDQty;
				                item.BudQty = data.BudQty;
				                item.IsPbuy = data.IsPbuy;
				                item.MaterialCode = data.MaterialCode;
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
				var exp = lambda.Resolve<PM_BudFDResList>();
                var i = (from p in ctx.DataContext.PM_BudFDResList.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AppNo = i.AppNo;
										this.TaskCode = i.TaskCode;
										this.ExpItemRow = i.ExpItemRow;
										this.ResRow = i.ResRow;
										this.Year = i.Year;
										this.ProjCode = i.ProjCode;
										this.ResouItemCode = i.ResouItemCode;
										this.ResName = i.ResName;
										this.SpecType = i.SpecType;
										this.UnitCode = i.UnitCode;
										this.Mfrs = i.Mfrs;
										this.Memo = i.Memo;
										this.TechReq = i.TechReq;
										this.Freeze = i.Freeze;
										this.FDAmt = i.FDAmt;
										this.BudAmt = i.BudAmt;
										this.FDQty = i.FDQty;
										this.BudQty = i.BudQty;
										this.IsPbuy = i.IsPbuy;
										this.MaterialCode = i.MaterialCode;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_BudFDResListsFactory : Common.Business.PM_BudFDResLists
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_BudFDResList
                        select PM_BudFDResListFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_BudFDResList
                        select PM_BudFDResListFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_BudFDResList>();
                var i = (from p in ctx.DataContext.PM_BudFDResList.Where(exp)
                         select PM_BudFDResListFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_BudFDResList>();
                var i = from p in ctx.DataContext.PM_BudFDResList.Where(exp)
                         select PM_BudFDResListFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
