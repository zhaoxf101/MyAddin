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
	public class FI_BankInstitutionsFactory:Common.Business.FI_BankInstitutions
    {
        public static Common.Business.FI_BankInstitutions Fetch(FI_BankInstitutions data)
        {
            Common.Business.FI_BankInstitutions item = (Common.Business.FI_BankInstitutions)Activator.CreateInstance(typeof(Common.Business.FI_BankInstitutions));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.BankInstitutionsCode = data.BankInstitutionsCode;
				                item.BankInstitutionsName = data.BankInstitutionsName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_BankInstitutions>();
                var i = (from p in ctx.DataContext.FI_BankInstitutions.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.BankInstitutionsCode = i.BankInstitutionsCode;
										this.BankInstitutionsName = i.BankInstitutionsName;
					}
            }
        }
	}

	public class FI_BankInstitutionssFactory : Common.Business.FI_BankInstitutionss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BankInstitutions
                        select FI_BankInstitutionsFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BankInstitutions
                        select FI_BankInstitutionsFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BankInstitutions>();
                var i = (from p in ctx.DataContext.FI_BankInstitutions.Where(exp)
                         select FI_BankInstitutionsFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BankInstitutions>();
                var i = from p in ctx.DataContext.FI_BankInstitutions.Where(exp)
                         select FI_BankInstitutionsFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
