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
	public class EF_CompositeRoleFactory:Common.Business.EF_CompositeRole
    {
        public static Common.Business.EF_CompositeRole Fetch(EF_CompositeRole data)
        {
            Common.Business.EF_CompositeRole item = (Common.Business.EF_CompositeRole)Activator.CreateInstance(typeof(Common.Business.EF_CompositeRole));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.RoleName = data.RoleName;
				                item.ChildRole = data.ChildRole;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_CompositeRole>();
                var i = (from p in ctx.DataContext.EF_CompositeRole.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.RoleName = i.RoleName;
										this.ChildRole = i.ChildRole;
					}
            }
        }
	}

	public class EF_CompositeRolesFactory : Common.Business.EF_CompositeRoles
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_CompositeRole
                        select EF_CompositeRoleFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_CompositeRole
                        select EF_CompositeRoleFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_CompositeRole>();
                var i = (from p in ctx.DataContext.EF_CompositeRole.Where(exp)
                         select EF_CompositeRoleFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_CompositeRole>();
                var i = from p in ctx.DataContext.EF_CompositeRole.Where(exp)
                         select EF_CompositeRoleFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
