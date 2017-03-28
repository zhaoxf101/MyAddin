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
	public class EF_UserRolesFactory:Common.Business.EF_UserRoles
    {
        public static Common.Business.EF_UserRoles Fetch(EF_UserRoles data)
        {
            Common.Business.EF_UserRoles item = (Common.Business.EF_UserRoles)Activator.CreateInstance(typeof(Common.Business.EF_UserRoles));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.BName = data.BName;
				                item.RoleName = data.RoleName;
				                item.ValidFrom = data.ValidFrom;
				                item.ValidTo = data.ValidTo;
				                item.ChgDate = data.ChgDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_UserRoles>();
                var i = (from p in ctx.DataContext.EF_UserRoles.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.BName = i.BName;
										this.RoleName = i.RoleName;
										this.ValidFrom = i.ValidFrom;
										this.ValidTo = i.ValidTo;
										this.ChgDate = i.ChgDate;
					}
            }
        }
	}

	public class EF_UserRolessFactory : Common.Business.EF_UserRoless
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_UserRoles
                        select EF_UserRolesFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_UserRoles
                        select EF_UserRolesFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_UserRoles>();
                var i = (from p in ctx.DataContext.EF_UserRoles.Where(exp)
                         select EF_UserRolesFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_UserRoles>();
                var i = from p in ctx.DataContext.EF_UserRoles.Where(exp)
                         select EF_UserRolesFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
