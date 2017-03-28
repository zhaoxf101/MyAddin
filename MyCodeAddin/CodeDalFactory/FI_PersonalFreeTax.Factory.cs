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
	public class FI_PersonalFreeTaxFactory:Common.Business.FI_PersonalFreeTax
    {
        public static Common.Business.FI_PersonalFreeTax Fetch(FI_PersonalFreeTax data)
        {
            Common.Business.FI_PersonalFreeTax item = (Common.Business.FI_PersonalFreeTax)Activator.CreateInstance(typeof(Common.Business.FI_PersonalFreeTax));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.RowID = data.RowID;
				                item.EmpCode = data.EmpCode;
				                item.Description = data.Description;
				                item.TaxTypeCode = data.TaxTypeCode;
				                item.FreeTax = data.FreeTax;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_PersonalFreeTax>();
                var i = (from p in ctx.DataContext.FI_PersonalFreeTax.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.RowID = i.RowID;
										this.EmpCode = i.EmpCode;
										this.Description = i.Description;
										this.TaxTypeCode = i.TaxTypeCode;
										this.FreeTax = i.FreeTax;
					}
            }
        }
	}

	public class FI_PersonalFreeTaxsFactory : Common.Business.FI_PersonalFreeTaxs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PersonalFreeTax
                        select FI_PersonalFreeTaxFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PersonalFreeTax
                        select FI_PersonalFreeTaxFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PersonalFreeTax>();
                var i = (from p in ctx.DataContext.FI_PersonalFreeTax.Where(exp)
                         select FI_PersonalFreeTaxFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PersonalFreeTax>();
                var i = from p in ctx.DataContext.FI_PersonalFreeTax.Where(exp)
                         select FI_PersonalFreeTaxFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
