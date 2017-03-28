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
	public class HR_SalaryFactory:Common.Business.HR_Salary
    {
        public static Common.Business.HR_Salary Fetch(HR_Salary data)
        {
            Common.Business.HR_Salary item = (Common.Business.HR_Salary)Activator.CreateInstance(typeof(Common.Business.HR_Salary));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SalaryCode = data.SalaryCode;
				                item.Period = data.Period;
				                item.PersonId = data.PersonId;
				                item.SalaryItemCode = data.SalaryItemCode;
				                item.SalaryItemName = data.SalaryItemName;
				                item.SalaryAmt = data.SalaryAmt;
				                item.ResouItemCode = data.ResouItemCode;
				                item.TaxTypeCode = data.TaxTypeCode;
				                item.IsIncrease = data.IsIncrease;
				                item.IsFixed = data.IsFixed;
				                item.IsFreeTax = data.IsFreeTax;
				                item.Sort = data.Sort;
				                item.DepCode = data.DepCode;
				                item.CostCtr = data.CostCtr;
				                item.IsFixedTaxRate = data.IsFixedTaxRate;
				                item.TaxRate = data.TaxRate;
				                item.TaxMinIncome = data.TaxMinIncome;
				                item.TaxPeriod = data.TaxPeriod;
				                item.Staff = data.Staff;
				                item.UType = data.UType;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemId = data.ExpItemId;
				                item.ExpItemCode = data.ExpItemCode;
				                item.Description = data.Description;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_Salary>();
                var i = (from p in ctx.DataContext.HR_Salary.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SalaryCode = i.SalaryCode;
										this.Period = i.Period;
										this.PersonId = i.PersonId;
										this.SalaryItemCode = i.SalaryItemCode;
										this.SalaryItemName = i.SalaryItemName;
										this.SalaryAmt = i.SalaryAmt;
										this.ResouItemCode = i.ResouItemCode;
										this.TaxTypeCode = i.TaxTypeCode;
										this.IsIncrease = i.IsIncrease;
										this.IsFixed = i.IsFixed;
										this.IsFreeTax = i.IsFreeTax;
										this.Sort = i.Sort;
										this.DepCode = i.DepCode;
										this.CostCtr = i.CostCtr;
										this.IsFixedTaxRate = i.IsFixedTaxRate;
										this.TaxRate = i.TaxRate;
										this.TaxMinIncome = i.TaxMinIncome;
										this.TaxPeriod = i.TaxPeriod;
										this.Staff = i.Staff;
										this.UType = i.UType;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ExpItemId = i.ExpItemId;
										this.ExpItemCode = i.ExpItemCode;
										this.Description = i.Description;
					}
            }
        }
	}

	public class HR_SalarysFactory : Common.Business.HR_Salarys
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_Salary
                        select HR_SalaryFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_Salary
                        select HR_SalaryFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_Salary>();
                var i = (from p in ctx.DataContext.HR_Salary.Where(exp)
                         select HR_SalaryFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_Salary>();
                var i = from p in ctx.DataContext.HR_Salary.Where(exp)
                         select HR_SalaryFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
