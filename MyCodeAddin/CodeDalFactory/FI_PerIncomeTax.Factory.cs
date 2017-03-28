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
	public class FI_PerIncomeTaxFactory:Common.Business.FI_PerIncomeTax
    {
        public static Common.Business.FI_PerIncomeTax Fetch(FI_PerIncomeTax data)
        {
            Common.Business.FI_PerIncomeTax item = (Common.Business.FI_PerIncomeTax)Activator.CreateInstance(typeof(Common.Business.FI_PerIncomeTax));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.RowDeal = data.RowDeal;
				                item.AccYear = data.AccYear;
				                item.Period = data.Period;
				                item.PersonId = data.PersonId;
				                item.BusTypeCode = data.BusTypeCode;
				                item.BusBillCode = data.BusBillCode;
				                item.RowId = data.RowId;
				                item.TaxTypeCode = data.TaxTypeCode;
				                item.Description = data.Description;
				                item.IncomeItem = data.IncomeItem;
				                item.Income = data.Income;
				                item.Payment = data.Payment;
				                item.FreeTaxIncome = data.FreeTaxIncome;
				                item.TaxIncome = data.TaxIncome;
				                item.TaxRate = data.TaxRate;
				                item.AccruedTax = data.AccruedTax;
				                item.WaitTaxAmt = data.WaitTaxAmt;
				                item.PaidTax = data.PaidTax;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.DepCode = data.DepCode;
				                item.IsCalTax = data.IsCalTax;
				                item.IsPaidTax = data.IsPaidTax;
				                item.IsQuery = data.IsQuery;
				                item.ResouSalaryItemCode = data.ResouSalaryItemCode;
				                item.ResouSalaryItemName = data.ResouSalaryItemName;
				                item.IsResouItem = data.IsResouItem;
				                item.IsIncrease = data.IsIncrease;
				                item.IsSum = data.IsSum;
				                item.CostCtr = data.CostCtr;
				                item.UserType = data.UserType;
				                item.UserID = data.UserID;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_PerIncomeTax>();
                var i = (from p in ctx.DataContext.FI_PerIncomeTax.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.RowDeal = i.RowDeal;
										this.AccYear = i.AccYear;
										this.Period = i.Period;
										this.PersonId = i.PersonId;
										this.BusTypeCode = i.BusTypeCode;
										this.BusBillCode = i.BusBillCode;
										this.RowId = i.RowId;
										this.TaxTypeCode = i.TaxTypeCode;
										this.Description = i.Description;
										this.IncomeItem = i.IncomeItem;
										this.Income = i.Income;
										this.Payment = i.Payment;
										this.FreeTaxIncome = i.FreeTaxIncome;
										this.TaxIncome = i.TaxIncome;
										this.TaxRate = i.TaxRate;
										this.AccruedTax = i.AccruedTax;
										this.WaitTaxAmt = i.WaitTaxAmt;
										this.PaidTax = i.PaidTax;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.DepCode = i.DepCode;
										this.IsCalTax = i.IsCalTax;
										this.IsPaidTax = i.IsPaidTax;
										this.IsQuery = i.IsQuery;
										this.ResouSalaryItemCode = i.ResouSalaryItemCode;
										this.ResouSalaryItemName = i.ResouSalaryItemName;
										this.IsResouItem = i.IsResouItem;
										this.IsIncrease = i.IsIncrease;
										this.IsSum = i.IsSum;
										this.CostCtr = i.CostCtr;
										this.UserType = i.UserType;
										this.UserID = i.UserID;
					}
            }
        }
	}

	public class FI_PerIncomeTaxsFactory : Common.Business.FI_PerIncomeTaxs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PerIncomeTax
                        select FI_PerIncomeTaxFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PerIncomeTax
                        select FI_PerIncomeTaxFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PerIncomeTax>();
                var i = (from p in ctx.DataContext.FI_PerIncomeTax.Where(exp)
                         select FI_PerIncomeTaxFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PerIncomeTax>();
                var i = from p in ctx.DataContext.FI_PerIncomeTax.Where(exp)
                         select FI_PerIncomeTaxFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
