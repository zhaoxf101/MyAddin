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
	public class PM_AllotItemFactory:Common.Business.PM_AllotItem
    {
        public static Common.Business.PM_AllotItem Fetch(PM_AllotItem data)
        {
            Common.Business.PM_AllotItem item = (Common.Business.PM_AllotItem)Activator.CreateInstance(typeof(Common.Business.PM_AllotItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AllotItemCode = data.AllotItemCode;
				                item.AllotItemName = data.AllotItemName;
				                item.AllotAreaCode = data.AllotAreaCode;
				                item.IsManaFee = data.IsManaFee;
				                item.IsTax = data.IsTax;
				                item.IsFixFee = data.IsFixFee;
				                item.Memo = data.Memo;
				                item.Active = data.Active;
				                item.ResouItemCode = data.ResouItemCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
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
				var exp = lambda.Resolve<PM_AllotItem>();
                var i = (from p in ctx.DataContext.PM_AllotItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AllotItemCode = i.AllotItemCode;
										this.AllotItemName = i.AllotItemName;
										this.AllotAreaCode = i.AllotAreaCode;
										this.IsManaFee = i.IsManaFee;
										this.IsTax = i.IsTax;
										this.IsFixFee = i.IsFixFee;
										this.Memo = i.Memo;
										this.Active = i.Active;
										this.ResouItemCode = i.ResouItemCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_AllotItemsFactory : Common.Business.PM_AllotItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_AllotItem
                        select PM_AllotItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_AllotItem
                        select PM_AllotItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_AllotItem>();
                var i = (from p in ctx.DataContext.PM_AllotItem.Where(exp)
                         select PM_AllotItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_AllotItem>();
                var i = from p in ctx.DataContext.PM_AllotItem.Where(exp)
                         select PM_AllotItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
