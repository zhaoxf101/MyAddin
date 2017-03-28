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
	public class RD_InvoiceVouchsFactory:Common.Business.RD_InvoiceVouchs
    {
        public static Common.Business.RD_InvoiceVouchs Fetch(RD_InvoiceVouchs data)
        {
            Common.Business.RD_InvoiceVouchs item = (Common.Business.RD_InvoiceVouchs)Activator.CreateInstance(typeof(Common.Business.RD_InvoiceVouchs));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.InvoiceNo = data.InvoiceNo;
				                item.RowNo = data.RowNo;
				                item.InvoiceItem = data.InvoiceItem;
				                item.ItemQty = data.ItemQty;
				                item.ItemPrice = data.ItemPrice;
				                item.ItemAmt = data.ItemAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<RD_InvoiceVouchs>();
                var i = (from p in ctx.DataContext.RD_InvoiceVouchs.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.InvoiceNo = i.InvoiceNo;
										this.RowNo = i.RowNo;
										this.InvoiceItem = i.InvoiceItem;
										this.ItemQty = i.ItemQty;
										this.ItemPrice = i.ItemPrice;
										this.ItemAmt = i.ItemAmt;
					}
            }
        }
	}

	public class RD_InvoiceVouchssFactory : Common.Business.RD_InvoiceVouchss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.RD_InvoiceVouchs
                        select RD_InvoiceVouchsFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.RD_InvoiceVouchs
                        select RD_InvoiceVouchsFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<RD_InvoiceVouchs>();
                var i = (from p in ctx.DataContext.RD_InvoiceVouchs.Where(exp)
                         select RD_InvoiceVouchsFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<RD_InvoiceVouchs>();
                var i = from p in ctx.DataContext.RD_InvoiceVouchs.Where(exp)
                         select RD_InvoiceVouchsFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
