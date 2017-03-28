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
	public class RD_InvoiceItemFactory:Common.Business.RD_InvoiceItem
    {
        public static Common.Business.RD_InvoiceItem Fetch(RD_InvoiceItem data)
        {
            Common.Business.RD_InvoiceItem item = (Common.Business.RD_InvoiceItem)Activator.CreateInstance(typeof(Common.Business.RD_InvoiceItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.InvoiceItem = data.InvoiceItem;
				                item.Flag = data.Flag;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<RD_InvoiceItem>();
                var i = (from p in ctx.DataContext.RD_InvoiceItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.InvoiceItem = i.InvoiceItem;
										this.Flag = i.Flag;
					}
            }
        }
	}

	public class RD_InvoiceItemsFactory : Common.Business.RD_InvoiceItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.RD_InvoiceItem
                        select RD_InvoiceItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.RD_InvoiceItem
                        select RD_InvoiceItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<RD_InvoiceItem>();
                var i = (from p in ctx.DataContext.RD_InvoiceItem.Where(exp)
                         select RD_InvoiceItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<RD_InvoiceItem>();
                var i = from p in ctx.DataContext.RD_InvoiceItem.Where(exp)
                         select RD_InvoiceItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
