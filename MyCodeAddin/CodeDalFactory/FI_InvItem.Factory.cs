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
	public class FI_InvItemFactory:Common.Business.FI_InvItem
    {
        public static Common.Business.FI_InvItem Fetch(FI_InvItem data)
        {
            Common.Business.FI_InvItem item = (Common.Business.FI_InvItem)Activator.CreateInstance(typeof(Common.Business.FI_InvItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.InvItemCode = data.InvItemCode;
				                item.InvItemName = data.InvItemName;
				                item.PermitItemCode = data.PermitItemCode;
				                item.InvTypCode = data.InvTypCode;
				                item.SIncItemCode = data.SIncItemCode;
				                item.IsToProjct = data.IsToProjct;
				                item.IsAutoCancInv = data.IsAutoCancInv;
				                item.IsRD = data.IsRD;
				                item.CAccCode = data.CAccCode;
				                item.DAccCode = data.DAccCode;
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
				var exp = lambda.Resolve<FI_InvItem>();
                var i = (from p in ctx.DataContext.FI_InvItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.InvItemCode = i.InvItemCode;
										this.InvItemName = i.InvItemName;
										this.PermitItemCode = i.PermitItemCode;
										this.InvTypCode = i.InvTypCode;
										this.SIncItemCode = i.SIncItemCode;
										this.IsToProjct = i.IsToProjct;
										this.IsAutoCancInv = i.IsAutoCancInv;
										this.IsRD = i.IsRD;
										this.CAccCode = i.CAccCode;
										this.DAccCode = i.DAccCode;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_InvItemsFactory : Common.Business.FI_InvItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_InvItem
                        select FI_InvItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_InvItem
                        select FI_InvItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_InvItem>();
                var i = (from p in ctx.DataContext.FI_InvItem.Where(exp)
                         select FI_InvItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_InvItem>();
                var i = from p in ctx.DataContext.FI_InvItem.Where(exp)
                         select FI_InvItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
