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
	public class FE_AdminUserFactory:Common.Business.FE_AdminUser
    {
        public static Common.Business.FE_AdminUser Fetch(FE_AdminUser data)
        {
            Common.Business.FE_AdminUser item = (Common.Business.FE_AdminUser)Activator.CreateInstance(typeof(Common.Business.FE_AdminUser));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.UserName = data.UserName;
				                item.PersonId = data.PersonId;
				                item.PassCode = data.PassCode;
				                item.UserGroup = data.UserGroup;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_AdminUser>();
                var i = (from p in ctx.DataContext.FE_AdminUser.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.UserName = i.UserName;
										this.PersonId = i.PersonId;
										this.PassCode = i.PassCode;
										this.UserGroup = i.UserGroup;
					}
            }
        }
	}

	public class FE_AdminUsersFactory : Common.Business.FE_AdminUsers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_AdminUser
                        select FE_AdminUserFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_AdminUser
                        select FE_AdminUserFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_AdminUser>();
                var i = (from p in ctx.DataContext.FE_AdminUser.Where(exp)
                         select FE_AdminUserFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_AdminUser>();
                var i = from p in ctx.DataContext.FE_AdminUser.Where(exp)
                         select FE_AdminUserFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
