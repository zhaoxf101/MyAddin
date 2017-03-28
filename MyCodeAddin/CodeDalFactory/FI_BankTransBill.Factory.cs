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
	public class FI_BankTransBillFactory:Common.Business.FI_BankTransBill
    {
        public static Common.Business.FI_BankTransBill Fetch(FI_BankTransBill data)
        {
            Common.Business.FI_BankTransBill item = (Common.Business.FI_BankTransBill)Activator.CreateInstance(typeof(Common.Business.FI_BankTransBill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.TransBillNo = data.TransBillNo;
				                item.BankCode = data.BankCode;
				                item.IncConfTypeCode = data.IncConfTypeCode;
				                item.Period = data.Period;
				                item.AccDateTime = data.AccDateTime;
				                item.GenVouX = data.GenVouX;
				                item.VouchNo = data.VouchNo;
				                item.VouchText = data.VouchText;
				                item.Approve = data.Approve;
				                item.CheckUser = data.CheckUser;
				                item.CheckDate = data.CheckDate;
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
				var exp = lambda.Resolve<FI_BankTransBill>();
                var i = (from p in ctx.DataContext.FI_BankTransBill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TransBillNo = i.TransBillNo;
										this.BankCode = i.BankCode;
										this.IncConfTypeCode = i.IncConfTypeCode;
										this.Period = i.Period;
										this.AccDateTime = i.AccDateTime;
										this.GenVouX = i.GenVouX;
										this.VouchNo = i.VouchNo;
										this.VouchText = i.VouchText;
										this.Approve = i.Approve;
										this.CheckUser = i.CheckUser;
										this.CheckDate = i.CheckDate;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_BankTransBillsFactory : Common.Business.FI_BankTransBills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BankTransBill
                        select FI_BankTransBillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BankTransBill
                        select FI_BankTransBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BankTransBill>();
                var i = (from p in ctx.DataContext.FI_BankTransBill.Where(exp)
                         select FI_BankTransBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BankTransBill>();
                var i = from p in ctx.DataContext.FI_BankTransBill.Where(exp)
                         select FI_BankTransBillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
