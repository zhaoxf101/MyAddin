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
	public class HR_SalaryItemFactory:Common.Business.HR_SalaryItem
    {
        public static Common.Business.HR_SalaryItem Fetch(HR_SalaryItem data)
        {
            Common.Business.HR_SalaryItem item = (Common.Business.HR_SalaryItem)Activator.CreateInstance(typeof(Common.Business.HR_SalaryItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SalaryItemCode = data.SalaryItemCode;
				                item.SalaryItemName = data.SalaryItemName;
				                item.ResouItemCode = data.ResouItemCode;
				                item.IsIncrease = data.IsIncrease;
				                item.TaxTypeCode = data.TaxTypeCode;
				                item.AccType = data.AccType;
				                item.AccCode = data.AccCode;
				                item.BAccCode = data.BAccCode;
				                item.IsTimelyTax = data.IsTimelyTax;
				                item.IsCalTax = data.IsCalTax;
				                item.TaxMinIncome = data.TaxMinIncome;
				                item.TaxPeriod = data.TaxPeriod;
				                item.IsFixed = data.IsFixed;
				                item.IsFreeTax = data.IsFreeTax;
				                item.IsTax = data.IsTax;
				                item.IsSalaryItem = data.IsSalaryItem;
				                item.IsWithhold = data.IsWithhold;
				                item.IsUseAccCode = data.IsUseAccCode;
				                item.Sort = data.Sort;
				                item.SumGroup = data.SumGroup;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SalaryItem>();
                var i = (from p in ctx.DataContext.HR_SalaryItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SalaryItemCode = i.SalaryItemCode;
										this.SalaryItemName = i.SalaryItemName;
										this.ResouItemCode = i.ResouItemCode;
										this.IsIncrease = i.IsIncrease;
										this.TaxTypeCode = i.TaxTypeCode;
										this.AccType = i.AccType;
										this.AccCode = i.AccCode;
										this.BAccCode = i.BAccCode;
										this.IsTimelyTax = i.IsTimelyTax;
										this.IsCalTax = i.IsCalTax;
										this.TaxMinIncome = i.TaxMinIncome;
										this.TaxPeriod = i.TaxPeriod;
										this.IsFixed = i.IsFixed;
										this.IsFreeTax = i.IsFreeTax;
										this.IsTax = i.IsTax;
										this.IsSalaryItem = i.IsSalaryItem;
										this.IsWithhold = i.IsWithhold;
										this.IsUseAccCode = i.IsUseAccCode;
										this.Sort = i.Sort;
										this.SumGroup = i.SumGroup;
					}
            }
        }
	}

	public class HR_SalaryItemsFactory : Common.Business.HR_SalaryItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SalaryItem
                        select HR_SalaryItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SalaryItem
                        select HR_SalaryItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SalaryItem>();
                var i = (from p in ctx.DataContext.HR_SalaryItem.Where(exp)
                         select HR_SalaryItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SalaryItem>();
                var i = from p in ctx.DataContext.HR_SalaryItem.Where(exp)
                         select HR_SalaryItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
