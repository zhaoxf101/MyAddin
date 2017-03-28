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
	public class FI_ParkVoucherFactory:Common.Business.FI_ParkVoucher
    {
        public static Common.Business.FI_ParkVoucher Fetch(FI_ParkVoucher data)
        {
            Common.Business.FI_ParkVoucher item = (Common.Business.FI_ParkVoucher)Activator.CreateInstance(typeof(Common.Business.FI_ParkVoucher));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.VouchNo = data.VouchNo;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.VouType = data.VouType;
				                item.BusType = data.BusType;
				                item.VouDate = data.VouDate;
				                item.PostDate = data.PostDate;
				                item.ReferenceNo = data.ReferenceNo;
				                item.RelatedInvBusNo = data.RelatedInvBusNo;
				                item.VouText = data.VouText;
				                item.CurrCode = data.CurrCode;
				                item.ExchRate = data.ExchRate;
				                item.BarCode = data.BarCode;
				                item.Businesser = data.Businesser;
				                item.BillQty = data.BillQty;
				                item.VouCls = data.VouCls;
				                item.ChiefPayX = data.ChiefPayX;
				                item.GovPayX = data.GovPayX;
				                item.CashPayX = data.CashPayX;
				                item.PayMsgX = data.PayMsgX;
				                item.ProxyPayX = data.ProxyPayX;
				                item.ParkCkX = data.ParkCkX;
				                item.ChiefCkX = data.ChiefCkX;
				                item.GovCkX = data.GovCkX;
				                item.CashCkX = data.CashCkX;
				                item.ParkUser = data.ParkUser;
				                item.ChiefUser = data.ChiefUser;
				                item.GovUser = data.GovUser;
				                item.CashUser = data.CashUser;
				                item.AutoVouch = data.AutoVouch;
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
				var exp = lambda.Resolve<FI_ParkVoucher>();
                var i = (from p in ctx.DataContext.FI_ParkVoucher.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.VouchNo = i.VouchNo;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.VouType = i.VouType;
										this.BusType = i.BusType;
										this.VouDate = i.VouDate;
										this.PostDate = i.PostDate;
										this.ReferenceNo = i.ReferenceNo;
										this.RelatedInvBusNo = i.RelatedInvBusNo;
										this.VouText = i.VouText;
										this.CurrCode = i.CurrCode;
										this.ExchRate = i.ExchRate;
										this.BarCode = i.BarCode;
										this.Businesser = i.Businesser;
										this.BillQty = i.BillQty;
										this.VouCls = i.VouCls;
										this.ChiefPayX = i.ChiefPayX;
										this.GovPayX = i.GovPayX;
										this.CashPayX = i.CashPayX;
										this.PayMsgX = i.PayMsgX;
										this.ProxyPayX = i.ProxyPayX;
										this.ParkCkX = i.ParkCkX;
										this.ChiefCkX = i.ChiefCkX;
										this.GovCkX = i.GovCkX;
										this.CashCkX = i.CashCkX;
										this.ParkUser = i.ParkUser;
										this.ChiefUser = i.ChiefUser;
										this.GovUser = i.GovUser;
										this.CashUser = i.CashUser;
										this.AutoVouch = i.AutoVouch;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_ParkVouchersFactory : Common.Business.FI_ParkVouchers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ParkVoucher
                        select FI_ParkVoucherFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ParkVoucher
                        select FI_ParkVoucherFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ParkVoucher>();
                var i = (from p in ctx.DataContext.FI_ParkVoucher.Where(exp)
                         select FI_ParkVoucherFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ParkVoucher>();
                var i = from p in ctx.DataContext.FI_ParkVoucher.Where(exp)
                         select FI_ParkVoucherFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
