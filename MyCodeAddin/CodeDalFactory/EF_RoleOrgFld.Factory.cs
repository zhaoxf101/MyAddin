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
	public class EF_RoleOrgFldFactory:Common.Business.EF_RoleOrgFld
    {
        public static Common.Business.EF_RoleOrgFld Fetch(EF_RoleOrgFld data)
        {
            Common.Business.EF_RoleOrgFld item = (Common.Business.EF_RoleOrgFld)Activator.CreateInstance(typeof(Common.Business.EF_RoleOrgFld));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.RoleName = data.RoleName;
				                item.Active = data.Active;
				                item.Counter = data.Counter;
				                item.OrgField = data.OrgField;
				                item.Low = data.Low;
				                item.High = data.High;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_RoleOrgFld>();
                var i = (from p in ctx.DataContext.EF_RoleOrgFld.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.RoleName = i.RoleName;
										this.Active = i.Active;
										this.Counter = i.Counter;
										this.OrgField = i.OrgField;
										this.Low = i.Low;
										this.High = i.High;
					}
            }
        }
	}

	public class EF_RoleOrgFldsFactory : Common.Business.EF_RoleOrgFlds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_RoleOrgFld
                        select EF_RoleOrgFldFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_RoleOrgFld
                        select EF_RoleOrgFldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_RoleOrgFld>();
                var i = (from p in ctx.DataContext.EF_RoleOrgFld.Where(exp)
                         select EF_RoleOrgFldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_RoleOrgFld>();
                var i = from p in ctx.DataContext.EF_RoleOrgFld.Where(exp)
                         select EF_RoleOrgFldFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
