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
	public class PM_ResListFactory:Common.Business.PM_ResList
    {
        public static Common.Business.PM_ResList Fetch(PM_ResList data)
        {
            Common.Business.PM_ResList item = (Common.Business.PM_ResList)Activator.CreateInstance(typeof(Common.Business.PM_ResList));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemRow = data.ExpItemRow;
				                item.ResouItemCode = data.ResouItemCode;
				                item.ResRow = data.ResRow;
				                item.Freeze = data.Freeze;
				                item.ResName = data.ResName;
				                item.SpecType = data.SpecType;
				                item.UnitCode = data.UnitCode;
				                item.Mfrs = data.Mfrs;
				                item.Memo = data.Memo;
				                item.IsPBuy = data.IsPBuy;
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
				var exp = lambda.Resolve<PM_ResList>();
                var i = (from p in ctx.DataContext.PM_ResList.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ExpItemRow = i.ExpItemRow;
										this.ResouItemCode = i.ResouItemCode;
										this.ResRow = i.ResRow;
										this.Freeze = i.Freeze;
										this.ResName = i.ResName;
										this.SpecType = i.SpecType;
										this.UnitCode = i.UnitCode;
										this.Mfrs = i.Mfrs;
										this.Memo = i.Memo;
										this.IsPBuy = i.IsPBuy;
										this.MaterialCode = i.MaterialCode;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_ResListsFactory : Common.Business.PM_ResLists
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ResList
                        select PM_ResListFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ResList
                        select PM_ResListFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ResList>();
                var i = (from p in ctx.DataContext.PM_ResList.Where(exp)
                         select PM_ResListFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ResList>();
                var i = from p in ctx.DataContext.PM_ResList.Where(exp)
                         select PM_ResListFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
