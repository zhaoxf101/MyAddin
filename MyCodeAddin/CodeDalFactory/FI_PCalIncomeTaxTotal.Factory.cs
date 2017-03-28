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
	public class FI_PCalIncomeTaxTotalFactory:Common.Business.FI_PCalIncomeTaxTotal
    {
        public static Common.Business.FI_PCalIncomeTaxTotal Fetch(FI_PCalIncomeTaxTotal data)
        {
            Common.Business.FI_PCalIncomeTaxTotal item = (Common.Business.FI_PCalIncomeTaxTotal)Activator.CreateInstance(typeof(Common.Business.FI_PCalIncomeTaxTotal));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.PersonId = data.PersonId;
				                item.Period = data.Period;
				                item.Income = data.Income;
				                item.Payment = data.Payment;
				                item.FreeTax = data.FreeTax;
				                item.TaxIncome = data.TaxIncome;
				                item.SalaryAccruedTax = data.SalaryAccruedTax;
				                item.AccruedTax = data.AccruedTax;
				                item.PaidtTax = data.PaidtTax;
				                item.ToDeductTax = data.ToDeductTax;
				                item.ActTaxAmt = data.ActTaxAmt;
				                item.ReportIncome = data.ReportIncome;
				                item.WaitPaidTax = data.WaitPaidTax;
				                item.Salary = data.Salary;
				                item.UserType = data.UserType;
				                item.UserID = data.UserID;
				                item.IsAppovel = data.IsAppovel;
				                item.IsFreeTax = data.IsFreeTax;
				                item.TaxAdjUser = data.TaxAdjUser;
				                item.TaxAdjDateTime = data.TaxAdjDateTime;
				                item.TaxAdjText = data.TaxAdjText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_PCalIncomeTaxTotal>();
                var i = (from p in ctx.DataContext.FI_PCalIncomeTaxTotal.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.PersonId = i.PersonId;
										this.Period = i.Period;
										this.Income = i.Income;
										this.Payment = i.Payment;
										this.FreeTax = i.FreeTax;
										this.TaxIncome = i.TaxIncome;
										this.SalaryAccruedTax = i.SalaryAccruedTax;
										this.AccruedTax = i.AccruedTax;
										this.PaidtTax = i.PaidtTax;
										this.ToDeductTax = i.ToDeductTax;
										this.ActTaxAmt = i.ActTaxAmt;
										this.ReportIncome = i.ReportIncome;
										this.WaitPaidTax = i.WaitPaidTax;
										this.Salary = i.Salary;
										this.UserType = i.UserType;
										this.UserID = i.UserID;
										this.IsAppovel = i.IsAppovel;
										this.IsFreeTax = i.IsFreeTax;
										this.TaxAdjUser = i.TaxAdjUser;
										this.TaxAdjDateTime = i.TaxAdjDateTime;
										this.TaxAdjText = i.TaxAdjText;
					}
            }
        }
	}

	public class FI_PCalIncomeTaxTotalsFactory : Common.Business.FI_PCalIncomeTaxTotals
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PCalIncomeTaxTotal
                        select FI_PCalIncomeTaxTotalFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PCalIncomeTaxTotal
                        select FI_PCalIncomeTaxTotalFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PCalIncomeTaxTotal>();
                var i = (from p in ctx.DataContext.FI_PCalIncomeTaxTotal.Where(exp)
                         select FI_PCalIncomeTaxTotalFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PCalIncomeTaxTotal>();
                var i = from p in ctx.DataContext.FI_PCalIncomeTaxTotal.Where(exp)
                         select FI_PCalIncomeTaxTotalFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
