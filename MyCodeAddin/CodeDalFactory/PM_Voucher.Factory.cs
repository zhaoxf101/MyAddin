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
	public class PM_VoucherFactory:Common.Business.PM_Voucher
    {
        public static Common.Business.PM_Voucher Fetch(PM_Voucher data)
        {
            Common.Business.PM_Voucher item = (Common.Business.PM_Voucher)Activator.CreateInstance(typeof(Common.Business.PM_Voucher));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AccYear = data.AccYear;
				                item.VouchNo = data.VouchNo;
				                item.VouType = data.VouType;
				                item.BusType = data.BusType;
				                item.VouDate = data.VouDate;
				                item.VouText = data.VouText;
				                item.CurrCode = data.CurrCode;
				                item.ReferenceNo = data.ReferenceNo;
				                item.OffsetNo = data.OffsetNo;
				                item.OffsetYear = data.OffsetYear;
				                item.OffSetMark = data.OffSetMark;
				                item.RefNo = data.RefNo;
				                item.RefYear = data.RefYear;
				                item.RefPid = data.RefPid;
				                item.AutoVouch = data.AutoVouch;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_Voucher>();
                var i = (from p in ctx.DataContext.PM_Voucher.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AccYear = i.AccYear;
										this.VouchNo = i.VouchNo;
										this.VouType = i.VouType;
										this.BusType = i.BusType;
										this.VouDate = i.VouDate;
										this.VouText = i.VouText;
										this.CurrCode = i.CurrCode;
										this.ReferenceNo = i.ReferenceNo;
										this.OffsetNo = i.OffsetNo;
										this.OffsetYear = i.OffsetYear;
										this.OffSetMark = i.OffSetMark;
										this.RefNo = i.RefNo;
										this.RefYear = i.RefYear;
										this.RefPid = i.RefPid;
										this.AutoVouch = i.AutoVouch;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
					}
            }
        }
	}

	public class PM_VouchersFactory : Common.Business.PM_Vouchers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_Voucher
                        select PM_VoucherFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_Voucher
                        select PM_VoucherFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_Voucher>();
                var i = (from p in ctx.DataContext.PM_Voucher.Where(exp)
                         select PM_VoucherFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_Voucher>();
                var i = from p in ctx.DataContext.PM_Voucher.Where(exp)
                         select PM_VoucherFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
