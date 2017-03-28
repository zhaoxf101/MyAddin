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
	public class PM_PurContPayItemFactory:Common.Business.PM_PurContPayItem
    {
        public static Common.Business.PM_PurContPayItem Fetch(PM_PurContPayItem data)
        {
            Common.Business.PM_PurContPayItem item = (Common.Business.PM_PurContPayItem)Activator.CreateInstance(typeof(Common.Business.PM_PurContPayItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PurContPayItemCode = data.PurContPayItemCode;
				                item.PurContPayItemName = data.PurContPayItemName;
				                item.IsExp = data.IsExp;
				                item.IsOther = data.IsOther;
				                item.Active = data.Active;
				                item.Memo = data.Memo;
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
				var exp = lambda.Resolve<PM_PurContPayItem>();
                var i = (from p in ctx.DataContext.PM_PurContPayItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PurContPayItemCode = i.PurContPayItemCode;
										this.PurContPayItemName = i.PurContPayItemName;
										this.IsExp = i.IsExp;
										this.IsOther = i.IsOther;
										this.Active = i.Active;
										this.Memo = i.Memo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_PurContPayItemsFactory : Common.Business.PM_PurContPayItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_PurContPayItem
                        select PM_PurContPayItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_PurContPayItem
                        select PM_PurContPayItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_PurContPayItem>();
                var i = (from p in ctx.DataContext.PM_PurContPayItem.Where(exp)
                         select PM_PurContPayItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_PurContPayItem>();
                var i = from p in ctx.DataContext.PM_PurContPayItem.Where(exp)
                         select PM_PurContPayItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
