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
	public class EF_AppUserFactory:Common.Business.EF_AppUser
    {
        public static Common.Business.EF_AppUser Fetch(EF_AppUser data)
        {
            Common.Business.EF_AppUser item = (Common.Business.EF_AppUser)Activator.CreateInstance(typeof(Common.Business.EF_AppUser));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.AppId = data.AppId;
				                item.Client = data.Client;
				                item.Secret = data.Secret;
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
				var exp = lambda.Resolve<EF_AppUser>();
                var i = (from p in ctx.DataContext.EF_AppUser.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.AppId = i.AppId;
										this.Client = i.Client;
										this.Secret = i.Secret;
										this.DText = i.DText;
					}
            }
        }
	}

	public class EF_AppUsersFactory : Common.Business.EF_AppUsers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_AppUser
                        select EF_AppUserFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_AppUser
                        select EF_AppUserFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_AppUser>();
                var i = (from p in ctx.DataContext.EF_AppUser.Where(exp)
                         select EF_AppUserFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_AppUser>();
                var i = from p in ctx.DataContext.EF_AppUser.Where(exp)
                         select EF_AppUserFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
