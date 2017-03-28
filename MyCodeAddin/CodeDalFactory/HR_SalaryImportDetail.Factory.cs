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
	public class HR_SalaryImportDetailFactory:Common.Business.HR_SalaryImportDetail
    {
        public static Common.Business.HR_SalaryImportDetail Fetch(HR_SalaryImportDetail data)
        {
            Common.Business.HR_SalaryImportDetail item = (Common.Business.HR_SalaryImportDetail)Activator.CreateInstance(typeof(Common.Business.HR_SalaryImportDetail));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SalaryCode = data.SalaryCode;
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
				                item.IsFixedTaxRate = data.IsFixedTaxRate;
				                item.TaxRate = data.TaxRate;
				                item.TaxMinIncome = data.TaxMinIncome;
				                item.TaxPeriod = data.TaxPeriod;
				                item.CostCtr = data.CostCtr;
				                item.Staff = data.Staff;
				                item.UType = data.UType;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemId = data.ExpItemId;
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
				var exp = lambda.Resolve<HR_SalaryImportDetail>();
                var i = (from p in ctx.DataContext.HR_SalaryImportDetail.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SalaryCode = i.SalaryCode;
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
										this.IsFixedTaxRate = i.IsFixedTaxRate;
										this.TaxRate = i.TaxRate;
										this.TaxMinIncome = i.TaxMinIncome;
										this.TaxPeriod = i.TaxPeriod;
										this.CostCtr = i.CostCtr;
										this.Staff = i.Staff;
										this.UType = i.UType;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ExpItemId = i.ExpItemId;
										this.Description = i.Description;
					}
            }
        }
	}

	public class HR_SalaryImportDetailsFactory : Common.Business.HR_SalaryImportDetails
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SalaryImportDetail
                        select HR_SalaryImportDetailFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SalaryImportDetail
                        select HR_SalaryImportDetailFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SalaryImportDetail>();
                var i = (from p in ctx.DataContext.HR_SalaryImportDetail.Where(exp)
                         select HR_SalaryImportDetailFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SalaryImportDetail>();
                var i = from p in ctx.DataContext.HR_SalaryImportDetail.Where(exp)
                         select HR_SalaryImportDetailFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
