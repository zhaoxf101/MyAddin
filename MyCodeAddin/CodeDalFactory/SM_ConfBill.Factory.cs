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
	public class SM_ConfBillFactory:Common.Business.SM_ConfBill
    {
        public static Common.Business.SM_ConfBill Fetch(SM_ConfBill data)
        {
            Common.Business.SM_ConfBill item = (Common.Business.SM_ConfBill)Activator.CreateInstance(typeof(Common.Business.SM_ConfBill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ConfCode = data.ConfCode;
				                item.ConfText = data.ConfText;
				                item.StartTime = data.StartTime;
				                item.EndTime = data.EndTime;
				                item.VendorCode = data.VendorCode;
				                item.GLMark = data.GLMark;
				                item.IsSubmit = data.IsSubmit;
				                item.Appoved = data.Appoved;
				                item.AccDateTime = data.AccDateTime;
				                item.GenVouX = data.GenVouX;
				                item.VouchNo = data.VouchNo;
				                item.VouchText = data.VouchText;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.CheckUser = data.CheckUser;
				                item.CheckDate = data.CheckDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<SM_ConfBill>();
                var i = (from p in ctx.DataContext.SM_ConfBill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ConfCode = i.ConfCode;
										this.ConfText = i.ConfText;
										this.StartTime = i.StartTime;
										this.EndTime = i.EndTime;
										this.VendorCode = i.VendorCode;
										this.GLMark = i.GLMark;
										this.IsSubmit = i.IsSubmit;
										this.Appoved = i.Appoved;
										this.AccDateTime = i.AccDateTime;
										this.GenVouX = i.GenVouX;
										this.VouchNo = i.VouchNo;
										this.VouchText = i.VouchText;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.CheckUser = i.CheckUser;
										this.CheckDate = i.CheckDate;
					}
            }
        }
	}

	public class SM_ConfBillsFactory : Common.Business.SM_ConfBills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_ConfBill
                        select SM_ConfBillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_ConfBill
                        select SM_ConfBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_ConfBill>();
                var i = (from p in ctx.DataContext.SM_ConfBill.Where(exp)
                         select SM_ConfBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_ConfBill>();
                var i = from p in ctx.DataContext.SM_ConfBill.Where(exp)
                         select SM_ConfBillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
