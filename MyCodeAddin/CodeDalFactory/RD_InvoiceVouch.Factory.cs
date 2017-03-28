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
	public class RD_InvoiceVouchFactory:Common.Business.RD_InvoiceVouch
    {
        public static Common.Business.RD_InvoiceVouch Fetch(RD_InvoiceVouch data)
        {
            Common.Business.RD_InvoiceVouch item = (Common.Business.RD_InvoiceVouch)Activator.CreateInstance(typeof(Common.Business.RD_InvoiceVouch));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.InvoiceCode = data.InvoiceCode;
				                item.InvoiceNo = data.InvoiceNo;
				                item.InvoiceDate = data.InvoiceDate;
				                item.IndustryClass = data.IndustryClass;
				                item.TotalAmt = data.TotalAmt;
				                item.RecipName = data.RecipName;
				                item.RecipNameTaxRegID = data.RecipNameTaxRegID;
				                item.PayeeUnit = data.PayeeUnit;
				                item.PayeeUnitTaxRegID = data.PayeeUnitTaxRegID;
				                item.InvoiceMemo = data.InvoiceMemo;
				                item.TaxCode = data.TaxCode;
				                item.InvoiceDrawer = data.InvoiceDrawer;
				                item.InvoicePayeer = data.InvoicePayeer;
				                item.InvoiceType = data.InvoiceType;
				                item.TotalMoneyCanceled = data.TotalMoneyCanceled;
				                item.ExecuteAmt = data.ExecuteAmt;
				                item.ProjectManager = data.ProjectManager;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<RD_InvoiceVouch>();
                var i = (from p in ctx.DataContext.RD_InvoiceVouch.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.InvoiceCode = i.InvoiceCode;
										this.InvoiceNo = i.InvoiceNo;
										this.InvoiceDate = i.InvoiceDate;
										this.IndustryClass = i.IndustryClass;
										this.TotalAmt = i.TotalAmt;
										this.RecipName = i.RecipName;
										this.RecipNameTaxRegID = i.RecipNameTaxRegID;
										this.PayeeUnit = i.PayeeUnit;
										this.PayeeUnitTaxRegID = i.PayeeUnitTaxRegID;
										this.InvoiceMemo = i.InvoiceMemo;
										this.TaxCode = i.TaxCode;
										this.InvoiceDrawer = i.InvoiceDrawer;
										this.InvoicePayeer = i.InvoicePayeer;
										this.InvoiceType = i.InvoiceType;
										this.TotalMoneyCanceled = i.TotalMoneyCanceled;
										this.ExecuteAmt = i.ExecuteAmt;
										this.ProjectManager = i.ProjectManager;
					}
            }
        }
	}

	public class RD_InvoiceVouchsFactory : Common.Business.RD_InvoiceVouchs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.RD_InvoiceVouch
                        select RD_InvoiceVouchFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.RD_InvoiceVouch
                        select RD_InvoiceVouchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<RD_InvoiceVouch>();
                var i = (from p in ctx.DataContext.RD_InvoiceVouch.Where(exp)
                         select RD_InvoiceVouchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<RD_InvoiceVouch>();
                var i = from p in ctx.DataContext.RD_InvoiceVouch.Where(exp)
                         select RD_InvoiceVouchFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
