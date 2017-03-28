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
	public class FI_TaxTypeFactory:Common.Business.FI_TaxType
    {
        public static Common.Business.FI_TaxType Fetch(FI_TaxType data)
        {
            Common.Business.FI_TaxType item = (Common.Business.FI_TaxType)Activator.CreateInstance(typeof(Common.Business.FI_TaxType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TaxCode = data.TaxCode;
				                item.TaxName = data.TaxName;
				                item.TaxRate = data.TaxRate;
				                item.TaxType = data.TaxType;
				                item.AccCode = data.AccCode;
				                item.IsInPrice = data.IsInPrice;
				                item.IsInvTax = data.IsInvTax;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_TaxType>();
                var i = (from p in ctx.DataContext.FI_TaxType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TaxCode = i.TaxCode;
										this.TaxName = i.TaxName;
										this.TaxRate = i.TaxRate;
										this.TaxType = i.TaxType;
										this.AccCode = i.AccCode;
										this.IsInPrice = i.IsInPrice;
										this.IsInvTax = i.IsInvTax;
					}
            }
        }
	}

	public class FI_TaxTypesFactory : Common.Business.FI_TaxTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_TaxType
                        select FI_TaxTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_TaxType
                        select FI_TaxTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_TaxType>();
                var i = (from p in ctx.DataContext.FI_TaxType.Where(exp)
                         select FI_TaxTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_TaxType>();
                var i = from p in ctx.DataContext.FI_TaxType.Where(exp)
                         select FI_TaxTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
