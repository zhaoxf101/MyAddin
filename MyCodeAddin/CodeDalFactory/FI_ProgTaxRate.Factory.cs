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
	public class FI_ProgTaxRateFactory:Common.Business.FI_ProgTaxRate
    {
        public static Common.Business.FI_ProgTaxRate Fetch(FI_ProgTaxRate data)
        {
            Common.Business.FI_ProgTaxRate item = (Common.Business.FI_ProgTaxRate)Activator.CreateInstance(typeof(Common.Business.FI_ProgTaxRate));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ProgTaxItemCode = data.ProgTaxItemCode;
				                item.ProgTaxItemName = data.ProgTaxItemName;
				                item.TaxLevel = data.TaxLevel;
				                item.FreeTax = data.FreeTax;
				                item.TaxIncomeL = data.TaxIncomeL;
				                item.TaxIncomeH = data.TaxIncomeH;
				                item.TaxRate = data.TaxRate;
				                item.QDeduction = data.QDeduction;
				                item.ReportLevel = data.ReportLevel;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ProgTaxRate>();
                var i = (from p in ctx.DataContext.FI_ProgTaxRate.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ProgTaxItemCode = i.ProgTaxItemCode;
										this.ProgTaxItemName = i.ProgTaxItemName;
										this.TaxLevel = i.TaxLevel;
										this.FreeTax = i.FreeTax;
										this.TaxIncomeL = i.TaxIncomeL;
										this.TaxIncomeH = i.TaxIncomeH;
										this.TaxRate = i.TaxRate;
										this.QDeduction = i.QDeduction;
										this.ReportLevel = i.ReportLevel;
					}
            }
        }
	}

	public class FI_ProgTaxRatesFactory : Common.Business.FI_ProgTaxRates
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ProgTaxRate
                        select FI_ProgTaxRateFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ProgTaxRate
                        select FI_ProgTaxRateFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ProgTaxRate>();
                var i = (from p in ctx.DataContext.FI_ProgTaxRate.Where(exp)
                         select FI_ProgTaxRateFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ProgTaxRate>();
                var i = from p in ctx.DataContext.FI_ProgTaxRate.Where(exp)
                         select FI_ProgTaxRateFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
