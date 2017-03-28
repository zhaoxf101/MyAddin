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
	public class SM_TuitionBillFactory:Common.Business.SM_TuitionBill
    {
        public static Common.Business.SM_TuitionBill Fetch(SM_TuitionBill data)
        {
            Common.Business.SM_TuitionBill item = (Common.Business.SM_TuitionBill)Activator.CreateInstance(typeof(Common.Business.SM_TuitionBill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.iDealNo = data.iDealNo;
				                item.vPayWayCode = data.vPayWayCode;
				                item.cYear = data.cYear;
				                item.vFeeItemCode = data.vFeeItemCode;
				                item.nBankAmout = data.nBankAmout;
				                item.nCashAmount = data.nCashAmount;
				                item.nAmount = data.nAmount;
				                item.vCurrName = data.vCurrName;
				                item.nExchangeRate = data.nExchangeRate;
				                item.nForeignCurrency = data.nForeignCurrency;
				                item.nPayable = data.nPayable;
				                item.nPayableChange = data.nPayableChange;
				                item.nPaid = data.nPaid;
				                item.nowe = data.nowe;
				                item.vBillTypeCode = data.vBillTypeCode;
				                item.nBillAmount = data.nBillAmount;
				                item.bPrint = data.bPrint;
				                item.vTuitionBillPrintOrder = data.vTuitionBillPrintOrder;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<SM_TuitionBill>();
                var i = (from p in ctx.DataContext.SM_TuitionBill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.iDealNo = i.iDealNo;
										this.vPayWayCode = i.vPayWayCode;
										this.cYear = i.cYear;
										this.vFeeItemCode = i.vFeeItemCode;
										this.nBankAmout = i.nBankAmout;
										this.nCashAmount = i.nCashAmount;
										this.nAmount = i.nAmount;
										this.vCurrName = i.vCurrName;
										this.nExchangeRate = i.nExchangeRate;
										this.nForeignCurrency = i.nForeignCurrency;
										this.nPayable = i.nPayable;
										this.nPayableChange = i.nPayableChange;
										this.nPaid = i.nPaid;
										this.nowe = i.nowe;
										this.vBillTypeCode = i.vBillTypeCode;
										this.nBillAmount = i.nBillAmount;
										this.bPrint = i.bPrint;
										this.vTuitionBillPrintOrder = i.vTuitionBillPrintOrder;
					}
            }
        }
	}

	public class SM_TuitionBillsFactory : Common.Business.SM_TuitionBills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_TuitionBill
                        select SM_TuitionBillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_TuitionBill
                        select SM_TuitionBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_TuitionBill>();
                var i = (from p in ctx.DataContext.SM_TuitionBill.Where(exp)
                         select SM_TuitionBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_TuitionBill>();
                var i = from p in ctx.DataContext.SM_TuitionBill.Where(exp)
                         select SM_TuitionBillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
