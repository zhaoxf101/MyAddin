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
	public class PM_ResouItemCLTFactory:Common.Business.PM_ResouItemCLT
    {
        public static Common.Business.PM_ResouItemCLT Fetch(PM_ResouItemCLT data)
        {
            Common.Business.PM_ResouItemCLT item = (Common.Business.PM_ResouItemCLT)Activator.CreateInstance(typeof(Common.Business.PM_ResouItemCLT));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ResouItemCode = data.ResouItemCode;
				                item.TaxTypeCode = data.TaxTypeCode;
				                item.IsTimelyTax = data.IsTimelyTax;
				                item.IsCalTax = data.IsCalTax;
				                item.TaxMinIncome = data.TaxMinIncome;
				                item.TaxPeriod = data.TaxPeriod;
				                item.IsSubsidy = data.IsSubsidy;
				                item.SubsidyStand = data.SubsidyStand;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_ResouItemCLT>();
                var i = (from p in ctx.DataContext.PM_ResouItemCLT.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ResouItemCode = i.ResouItemCode;
										this.TaxTypeCode = i.TaxTypeCode;
										this.IsTimelyTax = i.IsTimelyTax;
										this.IsCalTax = i.IsCalTax;
										this.TaxMinIncome = i.TaxMinIncome;
										this.TaxPeriod = i.TaxPeriod;
										this.IsSubsidy = i.IsSubsidy;
										this.SubsidyStand = i.SubsidyStand;
					}
            }
        }
	}

	public class PM_ResouItemCLTsFactory : Common.Business.PM_ResouItemCLTs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ResouItemCLT
                        select PM_ResouItemCLTFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ResouItemCLT
                        select PM_ResouItemCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ResouItemCLT>();
                var i = (from p in ctx.DataContext.PM_ResouItemCLT.Where(exp)
                         select PM_ResouItemCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ResouItemCLT>();
                var i = from p in ctx.DataContext.PM_ResouItemCLT.Where(exp)
                         select PM_ResouItemCLTFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
