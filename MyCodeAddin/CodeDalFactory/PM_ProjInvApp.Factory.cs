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
	public class PM_ProjInvAppFactory:Common.Business.PM_ProjInvApp
    {
        public static Common.Business.PM_ProjInvApp Fetch(PM_ProjInvApp data)
        {
            Common.Business.PM_ProjInvApp item = (Common.Business.PM_ProjInvApp)Activator.CreateInstance(typeof(Common.Business.PM_ProjInvApp));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ProjInvAppNo = data.ProjInvAppNo;
				                item.ProjCode = data.ProjCode;
				                item.InvAppAmt = data.InvAppAmt;
				                item.ReceivedAmt = data.ReceivedAmt;
				                item.InvProjTypeCode = data.InvProjTypeCode;
				                item.OtherUnit = data.OtherUnit;
				                item.InvContent = data.InvContent;
				                item.ContractNo = data.ContractNo;
				                item.ContractRegYN = data.ContractRegYN;
				                item.InvoiceApplyer = data.InvoiceApplyer;
				                item.InvoiceDrawer = data.InvoiceDrawer;
				                item.InvoiceNo = data.InvoiceNo;
				                item.IsAppr = data.IsAppr;
				                item.YSWF = data.YSWF;
				                item.Cancelled = data.Cancelled;
				                item.Approved = data.Approved;
				                item.ObjectId = data.ObjectId;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_ProjInvApp>();
                var i = (from p in ctx.DataContext.PM_ProjInvApp.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ProjInvAppNo = i.ProjInvAppNo;
										this.ProjCode = i.ProjCode;
										this.InvAppAmt = i.InvAppAmt;
										this.ReceivedAmt = i.ReceivedAmt;
										this.InvProjTypeCode = i.InvProjTypeCode;
										this.OtherUnit = i.OtherUnit;
										this.InvContent = i.InvContent;
										this.ContractNo = i.ContractNo;
										this.ContractRegYN = i.ContractRegYN;
										this.InvoiceApplyer = i.InvoiceApplyer;
										this.InvoiceDrawer = i.InvoiceDrawer;
										this.InvoiceNo = i.InvoiceNo;
										this.IsAppr = i.IsAppr;
										this.YSWF = i.YSWF;
										this.Cancelled = i.Cancelled;
										this.Approved = i.Approved;
										this.ObjectId = i.ObjectId;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_ProjInvAppsFactory : Common.Business.PM_ProjInvApps
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ProjInvApp
                        select PM_ProjInvAppFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ProjInvApp
                        select PM_ProjInvAppFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ProjInvApp>();
                var i = (from p in ctx.DataContext.PM_ProjInvApp.Where(exp)
                         select PM_ProjInvAppFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ProjInvApp>();
                var i = from p in ctx.DataContext.PM_ProjInvApp.Where(exp)
                         select PM_ProjInvAppFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
