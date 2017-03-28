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
	public class FI_BankOrgFactory:Common.Business.FI_BankOrg
    {
        public static Common.Business.FI_BankOrg Fetch(FI_BankOrg data)
        {
            Common.Business.FI_BankOrg item = (Common.Business.FI_BankOrg)Activator.CreateInstance(typeof(Common.Business.FI_BankOrg));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.BankOrgCode = data.BankOrgCode;
				                item.BankOrgName = data.BankOrgName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_BankOrg>();
                var i = (from p in ctx.DataContext.FI_BankOrg.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.BankOrgCode = i.BankOrgCode;
										this.BankOrgName = i.BankOrgName;
					}
            }
        }
	}

	public class FI_BankOrgsFactory : Common.Business.FI_BankOrgs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BankOrg
                        select FI_BankOrgFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BankOrg
                        select FI_BankOrgFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BankOrg>();
                var i = (from p in ctx.DataContext.FI_BankOrg.Where(exp)
                         select FI_BankOrgFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BankOrg>();
                var i = from p in ctx.DataContext.FI_BankOrg.Where(exp)
                         select FI_BankOrgFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
