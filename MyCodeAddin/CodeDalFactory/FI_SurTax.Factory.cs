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
	public class FI_SurTaxFactory:Common.Business.FI_SurTax
    {
        public static Common.Business.FI_SurTax Fetch(FI_SurTax data)
        {
            Common.Business.FI_SurTax item = (Common.Business.FI_SurTax)Activator.CreateInstance(typeof(Common.Business.FI_SurTax));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TaxCode = data.TaxCode;
				                item.SurCode = data.SurCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_SurTax>();
                var i = (from p in ctx.DataContext.FI_SurTax.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TaxCode = i.TaxCode;
										this.SurCode = i.SurCode;
					}
            }
        }
	}

	public class FI_SurTaxsFactory : Common.Business.FI_SurTaxs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_SurTax
                        select FI_SurTaxFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_SurTax
                        select FI_SurTaxFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_SurTax>();
                var i = (from p in ctx.DataContext.FI_SurTax.Where(exp)
                         select FI_SurTaxFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_SurTax>();
                var i = from p in ctx.DataContext.FI_SurTax.Where(exp)
                         select FI_SurTaxFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
