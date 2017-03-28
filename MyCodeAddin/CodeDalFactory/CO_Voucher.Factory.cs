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
	public class CO_VoucherFactory:Common.Business.CO_Voucher
    {
        public static Common.Business.CO_Voucher Fetch(CO_Voucher data)
        {
            Common.Business.CO_Voucher item = (Common.Business.CO_Voucher)Activator.CreateInstance(typeof(Common.Business.CO_Voucher));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.CostArea = data.CostArea;
				                item.AccYear = data.AccYear;
				                item.VouchNo = data.VouchNo;
				                item.AccPid = data.AccPid;
				                item.VouType = data.VouType;
				                item.VouDate = data.VouDate;
				                item.PostDate = data.PostDate;
				                item.VouText = data.VouText;
				                item.CurrCode = data.CurrCode;
				                item.OffsetNo = data.OffsetNo;
				                item.OffsetYear = data.OffsetYear;
				                item.OffSetMark = data.OffSetMark;
				                item.RefCLT = data.RefCLT;
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
				var exp = lambda.Resolve<CO_Voucher>();
                var i = (from p in ctx.DataContext.CO_Voucher.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.CostArea = i.CostArea;
										this.AccYear = i.AccYear;
										this.VouchNo = i.VouchNo;
										this.AccPid = i.AccPid;
										this.VouType = i.VouType;
										this.VouDate = i.VouDate;
										this.PostDate = i.PostDate;
										this.VouText = i.VouText;
										this.CurrCode = i.CurrCode;
										this.OffsetNo = i.OffsetNo;
										this.OffsetYear = i.OffsetYear;
										this.OffSetMark = i.OffSetMark;
										this.RefCLT = i.RefCLT;
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

	public class CO_VouchersFactory : Common.Business.CO_Vouchers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CO_Voucher
                        select CO_VoucherFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CO_Voucher
                        select CO_VoucherFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CO_Voucher>();
                var i = (from p in ctx.DataContext.CO_Voucher.Where(exp)
                         select CO_VoucherFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CO_Voucher>();
                var i = from p in ctx.DataContext.CO_Voucher.Where(exp)
                         select CO_VoucherFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
