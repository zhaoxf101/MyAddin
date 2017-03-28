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
	public class FI_ExpBusHangFactory:Common.Business.FI_ExpBusHang
    {
        public static Common.Business.FI_ExpBusHang Fetch(FI_ExpBusHang data)
        {
            Common.Business.FI_ExpBusHang item = (Common.Business.FI_ExpBusHang)Activator.CreateInstance(typeof(Common.Business.FI_ExpBusHang));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpBusCode = data.ExpBusCode;
				                item.ItemId = data.ItemId;
				                item.GLMark = data.GLMark;
				                item.VendorCode = data.VendorCode;
				                item.Amt = data.Amt;
				                item.ActAmt = data.ActAmt;
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
				var exp = lambda.Resolve<FI_ExpBusHang>();
                var i = (from p in ctx.DataContext.FI_ExpBusHang.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpBusCode = i.ExpBusCode;
										this.ItemId = i.ItemId;
										this.GLMark = i.GLMark;
										this.VendorCode = i.VendorCode;
										this.Amt = i.Amt;
										this.ActAmt = i.ActAmt;
										this.Description = i.Description;
					}
            }
        }
	}

	public class FI_ExpBusHangsFactory : Common.Business.FI_ExpBusHangs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpBusHang
                        select FI_ExpBusHangFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpBusHang
                        select FI_ExpBusHangFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpBusHang>();
                var i = (from p in ctx.DataContext.FI_ExpBusHang.Where(exp)
                         select FI_ExpBusHangFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpBusHang>();
                var i = from p in ctx.DataContext.FI_ExpBusHang.Where(exp)
                         select FI_ExpBusHangFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
