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
	public class FI_ExpBusSubsidyFactory:Common.Business.FI_ExpBusSubsidy
    {
        public static Common.Business.FI_ExpBusSubsidy Fetch(FI_ExpBusSubsidy data)
        {
            Common.Business.FI_ExpBusSubsidy item = (Common.Business.FI_ExpBusSubsidy)Activator.CreateInstance(typeof(Common.Business.FI_ExpBusSubsidy));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpBusCode = data.ExpBusCode;
				                item.PersonId = data.PersonId;
				                item.PosId = data.PosId;
				                item.Staff = data.Staff;
				                item.UType = data.UType;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemId = data.ExpItemId;
				                item.PersonName = data.PersonName;
				                item.IdNo = data.IdNo;
				                item.ExpItemCode = data.ExpItemCode;
				                item.ResouItemCode = data.ResouItemCode;
				                item.ResouItemName = data.ResouItemName;
				                item.CostCtr = data.CostCtr;
				                item.TaxTypeCode = data.TaxTypeCode;
				                item.Amt = data.Amt;
				                item.ActAmt = data.ActAmt;
				                item.IsFixedTax = data.IsFixedTax;
				                item.IsFreeTax = data.IsFreeTax;
				                item.IsTimelyTax = data.IsTimelyTax;
				                item.IsCalTax = data.IsCalTax;
				                item.IsTax = data.IsTax;
				                item.IsIncrease = data.IsIncrease;
				                item.TaxPeriod = data.TaxPeriod;
				                item.TaxRate = data.TaxRate;
				                item.ActTaxRate = data.ActTaxRate;
				                item.FreeTax = data.FreeTax;
				                item.PayablTaxAmt = data.PayablTaxAmt;
				                item.TaxMinIncome = data.TaxMinIncome;
				                item.TaxIncome = data.TaxIncome;
				                item.WaitTaxAmt = data.WaitTaxAmt;
				                item.ActTaxAmt = data.ActTaxAmt;
				                item.PaidtAmt = data.PaidtAmt;
				                item.IsDeferItem = data.IsDeferItem;
				                item.Payment = data.Payment;
				                item.BankCode = data.BankCode;
				                item.BankName = data.BankName;
				                item.UnitedBankId = data.UnitedBankId;
				                item.IsPublic = data.IsPublic;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ExpBusSubsidy>();
                var i = (from p in ctx.DataContext.FI_ExpBusSubsidy.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpBusCode = i.ExpBusCode;
										this.PersonId = i.PersonId;
										this.PosId = i.PosId;
										this.Staff = i.Staff;
										this.UType = i.UType;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ExpItemId = i.ExpItemId;
										this.PersonName = i.PersonName;
										this.IdNo = i.IdNo;
										this.ExpItemCode = i.ExpItemCode;
										this.ResouItemCode = i.ResouItemCode;
										this.ResouItemName = i.ResouItemName;
										this.CostCtr = i.CostCtr;
										this.TaxTypeCode = i.TaxTypeCode;
										this.Amt = i.Amt;
										this.ActAmt = i.ActAmt;
										this.IsFixedTax = i.IsFixedTax;
										this.IsFreeTax = i.IsFreeTax;
										this.IsTimelyTax = i.IsTimelyTax;
										this.IsCalTax = i.IsCalTax;
										this.IsTax = i.IsTax;
										this.IsIncrease = i.IsIncrease;
										this.TaxPeriod = i.TaxPeriod;
										this.TaxRate = i.TaxRate;
										this.ActTaxRate = i.ActTaxRate;
										this.FreeTax = i.FreeTax;
										this.PayablTaxAmt = i.PayablTaxAmt;
										this.TaxMinIncome = i.TaxMinIncome;
										this.TaxIncome = i.TaxIncome;
										this.WaitTaxAmt = i.WaitTaxAmt;
										this.ActTaxAmt = i.ActTaxAmt;
										this.PaidtAmt = i.PaidtAmt;
										this.IsDeferItem = i.IsDeferItem;
										this.Payment = i.Payment;
										this.BankCode = i.BankCode;
										this.BankName = i.BankName;
										this.UnitedBankId = i.UnitedBankId;
										this.IsPublic = i.IsPublic;
					}
            }
        }
	}

	public class FI_ExpBusSubsidysFactory : Common.Business.FI_ExpBusSubsidys
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpBusSubsidy
                        select FI_ExpBusSubsidyFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpBusSubsidy
                        select FI_ExpBusSubsidyFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpBusSubsidy>();
                var i = (from p in ctx.DataContext.FI_ExpBusSubsidy.Where(exp)
                         select FI_ExpBusSubsidyFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpBusSubsidy>();
                var i = from p in ctx.DataContext.FI_ExpBusSubsidy.Where(exp)
                         select FI_ExpBusSubsidyFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
