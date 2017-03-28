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
	public class PM_AllotAppFactory:Common.Business.PM_AllotApp
    {
        public static Common.Business.PM_AllotApp Fetch(PM_AllotApp data)
        {
            Common.Business.PM_AllotApp item = (Common.Business.PM_AllotApp)Activator.CreateInstance(typeof(Common.Business.PM_AllotApp));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AllotAppNo = data.AllotAppNo;
				                item.BarCode = data.BarCode;
				                item.BusType = data.BusType;
				                item.AllotBusTypeCode = data.AllotBusTypeCode;
				                item.AllotTypeCode = data.AllotTypeCode;
				                item.IncDetCode = data.IncDetCode;
				                item.ItemText = data.ItemText;
				                item.IsFundIn = data.IsFundIn;
				                item.IsProjIn = data.IsProjIn;
				                item.ProjCode = data.ProjCode;
				                item.LStaff = data.LStaff;
				                item.CostCtr = data.CostCtr;
				                item.FDAmt = data.FDAmt;
				                item.EscorwAmt = data.EscorwAmt;
				                item.UnInProjAmt = data.UnInProjAmt;
				                item.AppAmt = data.AppAmt;
				                item.AlloAmt = data.AlloAmt;
				                item.MaxExpAmt = data.MaxExpAmt;
				                item.OrdExpAmt = data.OrdExpAmt;
				                item.ExpAmt = data.ExpAmt;
				                item.MaxFee = data.MaxFee;
				                item.FeeAmt = data.FeeAmt;
				                item.OrdFee = data.OrdFee;
				                item.Active = data.Active;
				                item.IsAllot = data.IsAllot;
				                item.IsAppr = data.IsAppr;
				                item.IsChk = data.IsChk;
				                item.Cancelled = data.Cancelled;
				                item.Approved = data.Approved;
				                item.IsCancel = data.IsCancel;
				                item.IsAllotEnd = data.IsAllotEnd;
				                item.IncAccCode = data.IncAccCode;
				                item.Memo = data.Memo;
				                item.AccDateTime = data.AccDateTime;
				                item.GenVouX = data.GenVouX;
				                item.PreVouchNo = data.PreVouchNo;
				                item.VouchText = data.VouchText;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.VouDate = data.VouDate;
				                item.VouchNo = data.VouchNo;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.RDCheckedUser = data.RDCheckedUser;
				                item.RDCheckedDate = data.RDCheckedDate;
				                item.FICheckedUser = data.FICheckedUser;
				                item.FICheckedDate = data.FICheckedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_AllotApp>();
                var i = (from p in ctx.DataContext.PM_AllotApp.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AllotAppNo = i.AllotAppNo;
										this.BarCode = i.BarCode;
										this.BusType = i.BusType;
										this.AllotBusTypeCode = i.AllotBusTypeCode;
										this.AllotTypeCode = i.AllotTypeCode;
										this.IncDetCode = i.IncDetCode;
										this.ItemText = i.ItemText;
										this.IsFundIn = i.IsFundIn;
										this.IsProjIn = i.IsProjIn;
										this.ProjCode = i.ProjCode;
										this.LStaff = i.LStaff;
										this.CostCtr = i.CostCtr;
										this.FDAmt = i.FDAmt;
										this.EscorwAmt = i.EscorwAmt;
										this.UnInProjAmt = i.UnInProjAmt;
										this.AppAmt = i.AppAmt;
										this.AlloAmt = i.AlloAmt;
										this.MaxExpAmt = i.MaxExpAmt;
										this.OrdExpAmt = i.OrdExpAmt;
										this.ExpAmt = i.ExpAmt;
										this.MaxFee = i.MaxFee;
										this.FeeAmt = i.FeeAmt;
										this.OrdFee = i.OrdFee;
										this.Active = i.Active;
										this.IsAllot = i.IsAllot;
										this.IsAppr = i.IsAppr;
										this.IsChk = i.IsChk;
										this.Cancelled = i.Cancelled;
										this.Approved = i.Approved;
										this.IsCancel = i.IsCancel;
										this.IsAllotEnd = i.IsAllotEnd;
										this.IncAccCode = i.IncAccCode;
										this.Memo = i.Memo;
										this.AccDateTime = i.AccDateTime;
										this.GenVouX = i.GenVouX;
										this.PreVouchNo = i.PreVouchNo;
										this.VouchText = i.VouchText;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.VouDate = i.VouDate;
										this.VouchNo = i.VouchNo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.RDCheckedUser = i.RDCheckedUser;
										this.RDCheckedDate = i.RDCheckedDate;
										this.FICheckedUser = i.FICheckedUser;
										this.FICheckedDate = i.FICheckedDate;
					}
            }
        }
	}

	public class PM_AllotAppsFactory : Common.Business.PM_AllotApps
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_AllotApp
                        select PM_AllotAppFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_AllotApp
                        select PM_AllotAppFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_AllotApp>();
                var i = (from p in ctx.DataContext.PM_AllotApp.Where(exp)
                         select PM_AllotAppFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_AllotApp>();
                var i = from p in ctx.DataContext.PM_AllotApp.Where(exp)
                         select PM_AllotAppFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
