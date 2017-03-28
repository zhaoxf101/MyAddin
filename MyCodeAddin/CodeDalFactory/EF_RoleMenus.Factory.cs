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
	public class EF_RoleMenusFactory:Common.Business.EF_RoleMenus
    {
        public static Common.Business.EF_RoleMenus Fetch(EF_RoleMenus data)
        {
            Common.Business.EF_RoleMenus item = (Common.Business.EF_RoleMenus)Activator.CreateInstance(typeof(Common.Business.EF_RoleMenus));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.RoleName = data.RoleName;
				                item.ObjectId = data.ObjectId;
				                item.ParentId = data.ParentId;
				                item.SortOrder = data.SortOrder;
				                item.Folder = data.Folder;
				                item.TCode = data.TCode;
				                item.DText = data.DText;
				                item.Flags = data.Flags;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_RoleMenus>();
                var i = (from p in ctx.DataContext.EF_RoleMenus.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.RoleName = i.RoleName;
										this.ObjectId = i.ObjectId;
										this.ParentId = i.ParentId;
										this.SortOrder = i.SortOrder;
										this.Folder = i.Folder;
										this.TCode = i.TCode;
										this.DText = i.DText;
										this.Flags = i.Flags;
					}
            }
        }
	}

	public class EF_RoleMenussFactory : Common.Business.EF_RoleMenuss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_RoleMenus
                        select EF_RoleMenusFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_RoleMenus
                        select EF_RoleMenusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_RoleMenus>();
                var i = (from p in ctx.DataContext.EF_RoleMenus.Where(exp)
                         select EF_RoleMenusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_RoleMenus>();
                var i = from p in ctx.DataContext.EF_RoleMenus.Where(exp)
                         select EF_RoleMenusFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
