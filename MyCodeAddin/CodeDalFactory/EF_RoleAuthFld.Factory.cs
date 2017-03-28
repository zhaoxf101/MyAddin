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
	public class EF_RoleAuthFldFactory:Common.Business.EF_RoleAuthFld
    {
        public static Common.Business.EF_RoleAuthFld Fetch(EF_RoleAuthFld data)
        {
            Common.Business.EF_RoleAuthFld item = (Common.Business.EF_RoleAuthFld)Activator.CreateInstance(typeof(Common.Business.EF_RoleAuthFld));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.RoleName = data.RoleName;
				                item.Active = data.Active;
				                item.Counter = data.Counter;
				                item.Object = data.Object;
				                item.FieldName = data.FieldName;
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
				var exp = lambda.Resolve<EF_RoleAuthFld>();
                var i = (from p in ctx.DataContext.EF_RoleAuthFld.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.RoleName = i.RoleName;
										this.Active = i.Active;
										this.Counter = i.Counter;
										this.Object = i.Object;
										this.FieldName = i.FieldName;
										this.Low = i.Low;
										this.High = i.High;
					}
            }
        }
	}

	public class EF_RoleAuthFldsFactory : Common.Business.EF_RoleAuthFlds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_RoleAuthFld
                        select EF_RoleAuthFldFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_RoleAuthFld
                        select EF_RoleAuthFldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_RoleAuthFld>();
                var i = (from p in ctx.DataContext.EF_RoleAuthFld.Where(exp)
                         select EF_RoleAuthFldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_RoleAuthFld>();
                var i = from p in ctx.DataContext.EF_RoleAuthFld.Where(exp)
                         select EF_RoleAuthFldFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
