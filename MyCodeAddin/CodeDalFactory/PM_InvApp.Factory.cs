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
	public class PM_InvAppFactory:Common.Business.PM_InvApp
    {
        public static Common.Business.PM_InvApp Fetch(PM_InvApp data)
        {
            Common.Business.PM_InvApp item = (Common.Business.PM_InvApp)Activator.CreateInstance(typeof(Common.Business.PM_InvApp));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.InvAppNo = data.InvAppNo;
				                item.AppType = data.AppType;
				                item.BusType = data.BusType;
				                item.BarCode = data.BarCode;
				                item.ProjCode = data.ProjCode;
				                item.LPersonId = data.LPersonId;
				                item.ContractNO = data.ContractNO;
				                item.VendorCode = data.VendorCode;
				                item.OEntity = data.OEntity;
				                item.InvItemCode = data.InvItemCode;
				                item.InvContent = data.InvContent;
				                item.FDAmt = data.FDAmt;
				                item.UnNeedTaxAmt = data.UnNeedTaxAmt;
				                item.NeedTaxAmt = data.NeedTaxAmt;
				                item.TaxAmt = data.TaxAmt;
				                item.TaxCode = data.TaxCode;
				                item.RDAppAmt = data.RDAppAmt;
				                item.RcvApper = data.RcvApper;
				                item.ConTel = data.ConTel;
				                item.ConPhone = data.ConPhone;
				                item.ProfitCtr = data.ProfitCtr;
				                item.IncDetCode = data.IncDetCode;
				                item.IsProjInv = data.IsProjInv;
				                item.IsAppr = data.IsAppr;
				                item.IsChk = data.IsChk;
				                item.Cancelled = data.Cancelled;
				                item.Approved = data.Approved;
				                item.IsReAppr = data.IsReAppr;
				                item.IsReCHK = data.IsReCHK;
				                item.ReApproved = data.ReApproved;
				                item.ReCancelled = data.ReCancelled;
				                item.InvNo = data.InvNo;
				                item.Memo = data.Memo;
				                item.AccDateTime = data.AccDateTime;
				                item.GenVouX = data.GenVouX;
				                item.ReGenVouX = data.ReGenVouX;
				                item.VouchNo = data.VouchNo;
				                item.VouchText = data.VouchText;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.CheckedUser = data.CheckedUser;
				                item.CheckedDate = data.CheckedDate;
				                item.FICheckedUser = data.FICheckedUser;
				                item.FICheckedDate = data.FICheckedDate;
				                item.ReCreatedUser = data.ReCreatedUser;
				                item.ReCreatedDate = data.ReCreatedDate;
				                item.ReCheckedUser = data.ReCheckedUser;
				                item.ReCheckedDate = data.ReCheckedDate;
				                item.ReFICheckedUser = data.ReFICheckedUser;
				                item.ReFICheckedDate = data.ReFICheckedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_InvApp>();
                var i = (from p in ctx.DataContext.PM_InvApp.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.InvAppNo = i.InvAppNo;
										this.AppType = i.AppType;
										this.BusType = i.BusType;
										this.BarCode = i.BarCode;
										this.ProjCode = i.ProjCode;
										this.LPersonId = i.LPersonId;
										this.ContractNO = i.ContractNO;
										this.VendorCode = i.VendorCode;
										this.OEntity = i.OEntity;
										this.InvItemCode = i.InvItemCode;
										this.InvContent = i.InvContent;
										this.FDAmt = i.FDAmt;
										this.UnNeedTaxAmt = i.UnNeedTaxAmt;
										this.NeedTaxAmt = i.NeedTaxAmt;
										this.TaxAmt = i.TaxAmt;
										this.TaxCode = i.TaxCode;
										this.RDAppAmt = i.RDAppAmt;
										this.RcvApper = i.RcvApper;
										this.ConTel = i.ConTel;
										this.ConPhone = i.ConPhone;
										this.ProfitCtr = i.ProfitCtr;
										this.IncDetCode = i.IncDetCode;
										this.IsProjInv = i.IsProjInv;
										this.IsAppr = i.IsAppr;
										this.IsChk = i.IsChk;
										this.Cancelled = i.Cancelled;
										this.Approved = i.Approved;
										this.IsReAppr = i.IsReAppr;
										this.IsReCHK = i.IsReCHK;
										this.ReApproved = i.ReApproved;
										this.ReCancelled = i.ReCancelled;
										this.InvNo = i.InvNo;
										this.Memo = i.Memo;
										this.AccDateTime = i.AccDateTime;
										this.GenVouX = i.GenVouX;
										this.ReGenVouX = i.ReGenVouX;
										this.VouchNo = i.VouchNo;
										this.VouchText = i.VouchText;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.CheckedUser = i.CheckedUser;
										this.CheckedDate = i.CheckedDate;
										this.FICheckedUser = i.FICheckedUser;
										this.FICheckedDate = i.FICheckedDate;
										this.ReCreatedUser = i.ReCreatedUser;
										this.ReCreatedDate = i.ReCreatedDate;
										this.ReCheckedUser = i.ReCheckedUser;
										this.ReCheckedDate = i.ReCheckedDate;
										this.ReFICheckedUser = i.ReFICheckedUser;
										this.ReFICheckedDate = i.ReFICheckedDate;
					}
            }
        }
	}

	public class PM_InvAppsFactory : Common.Business.PM_InvApps
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_InvApp
                        select PM_InvAppFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_InvApp
                        select PM_InvAppFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_InvApp>();
                var i = (from p in ctx.DataContext.PM_InvApp.Where(exp)
                         select PM_InvAppFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_InvApp>();
                var i = from p in ctx.DataContext.PM_InvApp.Where(exp)
                         select PM_InvAppFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
