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
	public class FI_VoucherFactory:Common.Business.FI_Voucher
    {
        public static Common.Business.FI_Voucher Fetch(FI_Voucher data)
        {
            Common.Business.FI_Voucher item = (Common.Business.FI_Voucher)Activator.CreateInstance(typeof(Common.Business.FI_Voucher));
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
				                item.OffsetNo = data.OffsetNo;
				                item.OffsetYear = data.OffsetYear;
				                item.OffsetPid = data.OffsetPid;
				                item.OffSetMark = data.OffSetMark;
				                item.ParkVouNo = data.ParkVouNo;
				                item.ChiefPayX = data.ChiefPayX;
				                item.GovPayX = data.GovPayX;
				                item.CashPayX = data.CashPayX;
				                item.PayMsgX = data.PayMsgX;
				                item.ProxyPayX = data.ProxyPayX;
				                item.ParkCkX = data.ParkCkX;
				                item.ChiefCkX = data.ChiefCkX;
				                item.GovCkX = data.GovCkX;
				                item.CashCkX = data.CashCkX;
				                item.ProxyCkX = data.ProxyCkX;
				                item.ParkUser = data.ParkUser;
				                item.ChiefUser = data.ChiefUser;
				                item.GovUser = data.GovUser;
				                item.CashUser = data.CashUser;
				                item.PostUser = data.PostUser;
				                item.ProxyUser = data.ProxyUser;
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
				var exp = lambda.Resolve<FI_Voucher>();
                var i = (from p in ctx.DataContext.FI_Voucher.Where(exp)
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
										this.OffsetNo = i.OffsetNo;
										this.OffsetYear = i.OffsetYear;
										this.OffsetPid = i.OffsetPid;
										this.OffSetMark = i.OffSetMark;
										this.ParkVouNo = i.ParkVouNo;
										this.ChiefPayX = i.ChiefPayX;
										this.GovPayX = i.GovPayX;
										this.CashPayX = i.CashPayX;
										this.PayMsgX = i.PayMsgX;
										this.ProxyPayX = i.ProxyPayX;
										this.ParkCkX = i.ParkCkX;
										this.ChiefCkX = i.ChiefCkX;
										this.GovCkX = i.GovCkX;
										this.CashCkX = i.CashCkX;
										this.ProxyCkX = i.ProxyCkX;
										this.ParkUser = i.ParkUser;
										this.ChiefUser = i.ChiefUser;
										this.GovUser = i.GovUser;
										this.CashUser = i.CashUser;
										this.PostUser = i.PostUser;
										this.ProxyUser = i.ProxyUser;
										this.AutoVouch = i.AutoVouch;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_VouchersFactory : Common.Business.FI_Vouchers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_Voucher
                        select FI_VoucherFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_Voucher
                        select FI_VoucherFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_Voucher>();
                var i = (from p in ctx.DataContext.FI_Voucher.Where(exp)
                         select FI_VoucherFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_Voucher>();
                var i = from p in ctx.DataContext.FI_Voucher.Where(exp)
                         select FI_VoucherFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
