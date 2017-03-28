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
	public class FI_PTaxRateTypeFactory:Common.Business.FI_PTaxRateType
    {
        public static Common.Business.FI_PTaxRateType Fetch(FI_PTaxRateType data)
        {
            Common.Business.FI_PTaxRateType item = (Common.Business.FI_PTaxRateType)Activator.CreateInstance(typeof(Common.Business.FI_PTaxRateType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.TaxTypeCode = data.TaxTypeCode;
				                item.TaxTypeName = data.TaxTypeName;
				                item.ProgTaxItemCode = data.ProgTaxItemCode;
				                item.TaxRat = data.TaxRat;
				                item.IsFixedTaxRate = data.IsFixedTaxRate;
				                item.IsFreeTax = data.IsFreeTax;
				                item.FreeTax = data.FreeTax;
				                item.IsMonthEndTax = data.IsMonthEndTax;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_PTaxRateType>();
                var i = (from p in ctx.DataContext.FI_PTaxRateType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TaxTypeCode = i.TaxTypeCode;
										this.TaxTypeName = i.TaxTypeName;
										this.ProgTaxItemCode = i.ProgTaxItemCode;
										this.TaxRat = i.TaxRat;
										this.IsFixedTaxRate = i.IsFixedTaxRate;
										this.IsFreeTax = i.IsFreeTax;
										this.FreeTax = i.FreeTax;
										this.IsMonthEndTax = i.IsMonthEndTax;
					}
            }
        }
	}

	public class FI_PTaxRateTypesFactory : Common.Business.FI_PTaxRateTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PTaxRateType
                        select FI_PTaxRateTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PTaxRateType
                        select FI_PTaxRateTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PTaxRateType>();
                var i = (from p in ctx.DataContext.FI_PTaxRateType.Where(exp)
                         select FI_PTaxRateTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PTaxRateType>();
                var i = from p in ctx.DataContext.FI_PTaxRateType.Where(exp)
                         select FI_PTaxRateTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
