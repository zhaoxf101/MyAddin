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
	public class EF_RoleAuthObjFactory:Common.Business.EF_RoleAuthObj
    {
        public static Common.Business.EF_RoleAuthObj Fetch(EF_RoleAuthObj data)
        {
            Common.Business.EF_RoleAuthObj item = (Common.Business.EF_RoleAuthObj)Activator.CreateInstance(typeof(Common.Business.EF_RoleAuthObj));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.RoleName = data.RoleName;
				                item.Object = data.Object;
				                item.Active = data.Active;
				                item.Modiied = data.Modiied;
				                item.DText = data.DText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_RoleAuthObj>();
                var i = (from p in ctx.DataContext.EF_RoleAuthObj.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.RoleName = i.RoleName;
										this.Object = i.Object;
										this.Active = i.Active;
										this.Modiied = i.Modiied;
										this.DText = i.DText;
					}
            }
        }
	}

	public class EF_RoleAuthObjsFactory : Common.Business.EF_RoleAuthObjs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_RoleAuthObj
                        select EF_RoleAuthObjFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_RoleAuthObj
                        select EF_RoleAuthObjFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_RoleAuthObj>();
                var i = (from p in ctx.DataContext.EF_RoleAuthObj.Where(exp)
                         select EF_RoleAuthObjFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_RoleAuthObj>();
                var i = from p in ctx.DataContext.EF_RoleAuthObj.Where(exp)
                         select EF_RoleAuthObjFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
