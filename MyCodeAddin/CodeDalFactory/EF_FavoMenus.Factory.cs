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
	public class EF_FavoMenusFactory:Common.Business.EF_FavoMenus
    {
        public static Common.Business.EF_FavoMenus Fetch(EF_FavoMenus data)
        {
            Common.Business.EF_FavoMenus item = (Common.Business.EF_FavoMenus)Activator.CreateInstance(typeof(Common.Business.EF_FavoMenus));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.BName = data.BName;
				                item.ObjectId = data.ObjectId;
				                item.UIType = data.UIType;
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
				var exp = lambda.Resolve<EF_FavoMenus>();
                var i = (from p in ctx.DataContext.EF_FavoMenus.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.BName = i.BName;
										this.ObjectId = i.ObjectId;
										this.UIType = i.UIType;
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

	public class EF_FavoMenussFactory : Common.Business.EF_FavoMenuss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_FavoMenus
                        select EF_FavoMenusFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_FavoMenus
                        select EF_FavoMenusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_FavoMenus>();
                var i = (from p in ctx.DataContext.EF_FavoMenus.Where(exp)
                         select EF_FavoMenusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_FavoMenus>();
                var i = from p in ctx.DataContext.EF_FavoMenus.Where(exp)
                         select EF_FavoMenusFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
