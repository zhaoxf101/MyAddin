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
	public class FI_ExpBusVendorFactory:Common.Business.FI_ExpBusVendor
    {
        public static Common.Business.FI_ExpBusVendor Fetch(FI_ExpBusVendor data)
        {
            Common.Business.FI_ExpBusVendor item = (Common.Business.FI_ExpBusVendor)Activator.CreateInstance(typeof(Common.Business.FI_ExpBusVendor));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpBusCode = data.ExpBusCode;
				                item.VendorCode = data.VendorCode;
				                item.GLMark = data.GLMark;
				                item.ItemText = data.ItemText;
				                item.Amt = data.Amt;
				                item.ActAmt = data.ActAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ExpBusVendor>();
                var i = (from p in ctx.DataContext.FI_ExpBusVendor.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpBusCode = i.ExpBusCode;
										this.VendorCode = i.VendorCode;
										this.GLMark = i.GLMark;
										this.ItemText = i.ItemText;
										this.Amt = i.Amt;
										this.ActAmt = i.ActAmt;
					}
            }
        }
	}

	public class FI_ExpBusVendorsFactory : Common.Business.FI_ExpBusVendors
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpBusVendor
                        select FI_ExpBusVendorFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpBusVendor
                        select FI_ExpBusVendorFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpBusVendor>();
                var i = (from p in ctx.DataContext.FI_ExpBusVendor.Where(exp)
                         select FI_ExpBusVendorFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpBusVendor>();
                var i = from p in ctx.DataContext.FI_ExpBusVendor.Where(exp)
                         select FI_ExpBusVendorFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
