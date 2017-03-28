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
	public class RD_InvoiceApplyFactory:Common.Business.RD_InvoiceApply
    {
        public static Common.Business.RD_InvoiceApply Fetch(RD_InvoiceApply data)
        {
            Common.Business.RD_InvoiceApply item = (Common.Business.RD_InvoiceApply)Activator.CreateInstance(typeof(Common.Business.RD_InvoiceApply));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.InvAppBillNo = data.InvAppBillNo;
				                item.ApplyDate = data.ApplyDate;
				                item.ProjectCode = data.ProjectCode;
				                item.ProjectName = data.ProjectName;
				                item.ProjectManager = data.ProjectManager;
				                item.ProjectAmt = data.ProjectAmt;
				                item.InvoicedAmt = data.InvoicedAmt;
				                item.InvoiceAmt = data.InvoiceAmt;
				                item.ReceivedAmt = data.ReceivedAmt;
				                item.ProjectType = data.ProjectType;
				                item.OtherUnit = data.OtherUnit;
				                item.InvoiceContent = data.InvoiceContent;
				                item.ContractNO = data.ContractNO;
				                item.ContractRegYN = data.ContractRegYN;
				                item.InvoiceApplyer = data.InvoiceApplyer;
				                item.RDAudit = data.RDAudit;
				                item.FIAudit = data.FIAudit;
				                item.InvoiceDrawer = data.InvoiceDrawer;
				                item.InvoiceYN = data.InvoiceYN;
				                item.InvoiceNo = data.InvoiceNo;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<RD_InvoiceApply>();
                var i = (from p in ctx.DataContext.RD_InvoiceApply.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.InvAppBillNo = i.InvAppBillNo;
										this.ApplyDate = i.ApplyDate;
										this.ProjectCode = i.ProjectCode;
										this.ProjectName = i.ProjectName;
										this.ProjectManager = i.ProjectManager;
										this.ProjectAmt = i.ProjectAmt;
										this.InvoicedAmt = i.InvoicedAmt;
										this.InvoiceAmt = i.InvoiceAmt;
										this.ReceivedAmt = i.ReceivedAmt;
										this.ProjectType = i.ProjectType;
										this.OtherUnit = i.OtherUnit;
										this.InvoiceContent = i.InvoiceContent;
										this.ContractNO = i.ContractNO;
										this.ContractRegYN = i.ContractRegYN;
										this.InvoiceApplyer = i.InvoiceApplyer;
										this.RDAudit = i.RDAudit;
										this.FIAudit = i.FIAudit;
										this.InvoiceDrawer = i.InvoiceDrawer;
										this.InvoiceYN = i.InvoiceYN;
										this.InvoiceNo = i.InvoiceNo;
					}
            }
        }
	}

	public class RD_InvoiceApplysFactory : Common.Business.RD_InvoiceApplys
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.RD_InvoiceApply
                        select RD_InvoiceApplyFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.RD_InvoiceApply
                        select RD_InvoiceApplyFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<RD_InvoiceApply>();
                var i = (from p in ctx.DataContext.RD_InvoiceApply.Where(exp)
                         select RD_InvoiceApplyFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<RD_InvoiceApply>();
                var i = from p in ctx.DataContext.RD_InvoiceApply.Where(exp)
                         select RD_InvoiceApplyFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
