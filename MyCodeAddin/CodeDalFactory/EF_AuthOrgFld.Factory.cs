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
	public class EF_AuthOrgFldFactory:Common.Business.EF_AuthOrgFld
    {
        public static Common.Business.EF_AuthOrgFld Fetch(EF_AuthOrgFld data)
        {
            Common.Business.EF_AuthOrgFld item = (Common.Business.EF_AuthOrgFld)Activator.CreateInstance(typeof(Common.Business.EF_AuthOrgFld));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.OrgField = data.OrgField;
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
				var exp = lambda.Resolve<EF_AuthOrgFld>();
                var i = (from p in ctx.DataContext.EF_AuthOrgFld.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.OrgField = i.OrgField;
										this.DText = i.DText;
					}
            }
        }
	}

	public class EF_AuthOrgFldsFactory : Common.Business.EF_AuthOrgFlds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_AuthOrgFld
                        select EF_AuthOrgFldFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_AuthOrgFld
                        select EF_AuthOrgFldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_AuthOrgFld>();
                var i = (from p in ctx.DataContext.EF_AuthOrgFld.Where(exp)
                         select EF_AuthOrgFldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_AuthOrgFld>();
                var i = from p in ctx.DataContext.EF_AuthOrgFld.Where(exp)
                         select EF_AuthOrgFldFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
