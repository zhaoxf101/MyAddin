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
	public class PM_InvAppTaxFactory:Common.Business.PM_InvAppTax
    {
        public static Common.Business.PM_InvAppTax Fetch(PM_InvAppTax data)
        {
            Common.Business.PM_InvAppTax item = (Common.Business.PM_InvAppTax)Activator.CreateInstance(typeof(Common.Business.PM_InvAppTax));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.InvAppNo = data.InvAppNo;
				                item.TaxCode = data.TaxCode;
				                item.TaxRate = data.TaxRate;
				                item.TaxType = data.TaxType;
				                item.TaxAmt = data.TaxAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_InvAppTax>();
                var i = (from p in ctx.DataContext.PM_InvAppTax.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.InvAppNo = i.InvAppNo;
										this.TaxCode = i.TaxCode;
										this.TaxRate = i.TaxRate;
										this.TaxType = i.TaxType;
										this.TaxAmt = i.TaxAmt;
					}
            }
        }
	}

	public class PM_InvAppTaxsFactory : Common.Business.PM_InvAppTaxs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_InvAppTax
                        select PM_InvAppTaxFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_InvAppTax
                        select PM_InvAppTaxFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_InvAppTax>();
                var i = (from p in ctx.DataContext.PM_InvAppTax.Where(exp)
                         select PM_InvAppTaxFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_InvAppTax>();
                var i = from p in ctx.DataContext.PM_InvAppTax.Where(exp)
                         select PM_InvAppTaxFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
