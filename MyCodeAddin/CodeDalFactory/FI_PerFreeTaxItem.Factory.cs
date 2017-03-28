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
	public class FI_PerFreeTaxItemFactory:Common.Business.FI_PerFreeTaxItem
    {
        public static Common.Business.FI_PerFreeTaxItem Fetch(FI_PerFreeTaxItem data)
        {
            Common.Business.FI_PerFreeTaxItem item = (Common.Business.FI_PerFreeTaxItem)Activator.CreateInstance(typeof(Common.Business.FI_PerFreeTaxItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.TaxTypeCode = data.TaxTypeCode;
				                item.UType = data.UType;
				                item.EmpStatusCode = data.EmpStatusCode;
				                item.IsInReg = data.IsInReg;
				                item.IsFreeTax = data.IsFreeTax;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_PerFreeTaxItem>();
                var i = (from p in ctx.DataContext.FI_PerFreeTaxItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TaxTypeCode = i.TaxTypeCode;
										this.UType = i.UType;
										this.EmpStatusCode = i.EmpStatusCode;
										this.IsInReg = i.IsInReg;
										this.IsFreeTax = i.IsFreeTax;
					}
            }
        }
	}

	public class FI_PerFreeTaxItemsFactory : Common.Business.FI_PerFreeTaxItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PerFreeTaxItem
                        select FI_PerFreeTaxItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PerFreeTaxItem
                        select FI_PerFreeTaxItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PerFreeTaxItem>();
                var i = (from p in ctx.DataContext.FI_PerFreeTaxItem.Where(exp)
                         select FI_PerFreeTaxItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PerFreeTaxItem>();
                var i = from p in ctx.DataContext.FI_PerFreeTaxItem.Where(exp)
                         select FI_PerFreeTaxItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
