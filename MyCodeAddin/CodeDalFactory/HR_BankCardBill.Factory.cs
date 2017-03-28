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
	public class HR_BankCardBillFactory:Common.Business.HR_BankCardBill
    {
        public static Common.Business.HR_BankCardBill Fetch(HR_BankCardBill data)
        {
            Common.Business.HR_BankCardBill item = (Common.Business.HR_BankCardBill)Activator.CreateInstance(typeof(Common.Business.HR_BankCardBill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.BillNo = data.BillNo;
				                item.EmpCode = data.EmpCode;
				                item.BankCardNo = data.BankCardNo;
				                item.BankName = data.BankName;
				                item.UnitedBankId = data.UnitedBankId;
				                item.BankCardTypeCode = data.BankCardTypeCode;
				                item.IsOffCard = data.IsOffCard;
				                item.IsExpBus = data.IsExpBus;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_BankCardBill>();
                var i = (from p in ctx.DataContext.HR_BankCardBill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.BillNo = i.BillNo;
										this.EmpCode = i.EmpCode;
										this.BankCardNo = i.BankCardNo;
										this.BankName = i.BankName;
										this.UnitedBankId = i.UnitedBankId;
										this.BankCardTypeCode = i.BankCardTypeCode;
										this.IsOffCard = i.IsOffCard;
										this.IsExpBus = i.IsExpBus;
					}
            }
        }
	}

	public class HR_BankCardBillsFactory : Common.Business.HR_BankCardBills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_BankCardBill
                        select HR_BankCardBillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_BankCardBill
                        select HR_BankCardBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_BankCardBill>();
                var i = (from p in ctx.DataContext.HR_BankCardBill.Where(exp)
                         select HR_BankCardBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_BankCardBill>();
                var i = from p in ctx.DataContext.HR_BankCardBill.Where(exp)
                         select HR_BankCardBillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
