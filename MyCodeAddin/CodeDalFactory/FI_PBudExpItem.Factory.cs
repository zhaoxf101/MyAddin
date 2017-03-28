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
	public class FI_PBudExpItemFactory:Common.Business.FI_PBudExpItem
    {
        public static Common.Business.FI_PBudExpItem Fetch(FI_PBudExpItem data)
        {
            Common.Business.FI_PBudExpItem item = (Common.Business.FI_PBudExpItem)Activator.CreateInstance(typeof(Common.Business.FI_PBudExpItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PBudExpItemCode = data.PBudExpItemCode;
				                item.PBudExpItemName = data.PBudExpItemName;
				                item.PCode = data.PCode;
				                item.IsGroup = data.IsGroup;
				                item.IsSys = data.IsSys;
				                item.IsPub = data.IsPub;
				                item.PItemStaGrpCode = data.PItemStaGrpCode;
				                item.IsRoot = data.IsRoot;
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
				var exp = lambda.Resolve<FI_PBudExpItem>();
                var i = (from p in ctx.DataContext.FI_PBudExpItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PBudExpItemCode = i.PBudExpItemCode;
										this.PBudExpItemName = i.PBudExpItemName;
										this.PCode = i.PCode;
										this.IsGroup = i.IsGroup;
										this.IsSys = i.IsSys;
										this.IsPub = i.IsPub;
										this.PItemStaGrpCode = i.PItemStaGrpCode;
										this.IsRoot = i.IsRoot;
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

	public class FI_PBudExpItemsFactory : Common.Business.FI_PBudExpItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PBudExpItem
                        select FI_PBudExpItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PBudExpItem
                        select FI_PBudExpItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PBudExpItem>();
                var i = (from p in ctx.DataContext.FI_PBudExpItem.Where(exp)
                         select FI_PBudExpItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PBudExpItem>();
                var i = from p in ctx.DataContext.FI_PBudExpItem.Where(exp)
                         select FI_PBudExpItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
