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
	public class RD_ReturnInvoiceFactory:Common.Business.RD_ReturnInvoice
    {
        public static Common.Business.RD_ReturnInvoice Fetch(RD_ReturnInvoice data)
        {
            Common.Business.RD_ReturnInvoice item = (Common.Business.RD_ReturnInvoice)Activator.CreateInstance(typeof(Common.Business.RD_ReturnInvoice));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.RetInvCode = data.RetInvCode;
				                item.RetInvTime = data.RetInvTime;
				                item.RetInvReason = data.RetInvReason;
				                item.InvoiceCode = data.InvoiceCode;
				                item.InvoiceDate = data.InvoiceDate;
				                item.InvoiceAmt = data.InvoiceAmt;
				                item.RecipName = data.RecipName;
				                item.RetInvApplyer = data.RetInvApplyer;
				                item.DepAudit = data.DepAudit;
				                item.RDAudit = data.RDAudit;
				                item.FIAudit = data.FIAudit;
				                item.RetInvDealer = data.RetInvDealer;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<RD_ReturnInvoice>();
                var i = (from p in ctx.DataContext.RD_ReturnInvoice.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.RetInvCode = i.RetInvCode;
										this.RetInvTime = i.RetInvTime;
										this.RetInvReason = i.RetInvReason;
										this.InvoiceCode = i.InvoiceCode;
										this.InvoiceDate = i.InvoiceDate;
										this.InvoiceAmt = i.InvoiceAmt;
										this.RecipName = i.RecipName;
										this.RetInvApplyer = i.RetInvApplyer;
										this.DepAudit = i.DepAudit;
										this.RDAudit = i.RDAudit;
										this.FIAudit = i.FIAudit;
										this.RetInvDealer = i.RetInvDealer;
					}
            }
        }
	}

	public class RD_ReturnInvoicesFactory : Common.Business.RD_ReturnInvoices
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.RD_ReturnInvoice
                        select RD_ReturnInvoiceFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.RD_ReturnInvoice
                        select RD_ReturnInvoiceFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<RD_ReturnInvoice>();
                var i = (from p in ctx.DataContext.RD_ReturnInvoice.Where(exp)
                         select RD_ReturnInvoiceFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<RD_ReturnInvoice>();
                var i = from p in ctx.DataContext.RD_ReturnInvoice.Where(exp)
                         select RD_ReturnInvoiceFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
