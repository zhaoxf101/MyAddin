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
	public class FE_BalanceFactory:Common.Business.FE_Balance
    {
        public static Common.Business.FE_Balance Fetch(FE_Balance data)
        {
            Common.Business.FE_Balance item = (Common.Business.FE_Balance)Activator.CreateInstance(typeof(Common.Business.FE_Balance));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Mch_Id = data.Mch_Id;
				                item.DebitDate = data.DebitDate;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.TransactionFee = data.TransactionFee;
				                item.TransactionCount = data.TransactionCount;
				                item.RefundFee = data.RefundFee;
				                item.RefundCount = data.RefundCount;
				                item.PayFee = data.PayFee;
				                item.poundage = data.poundage;
				                item.BalanceFee = data.BalanceFee;
				                item.IsChecked = data.IsChecked;
				                item.BillNo = data.BillNo;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_Balance>();
                var i = (from p in ctx.DataContext.FE_Balance.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Mch_Id = i.Mch_Id;
										this.DebitDate = i.DebitDate;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.TransactionFee = i.TransactionFee;
										this.TransactionCount = i.TransactionCount;
										this.RefundFee = i.RefundFee;
										this.RefundCount = i.RefundCount;
										this.PayFee = i.PayFee;
										this.poundage = i.poundage;
										this.BalanceFee = i.BalanceFee;
										this.IsChecked = i.IsChecked;
										this.BillNo = i.BillNo;
					}
            }
        }
	}

	public class FE_BalancesFactory : Common.Business.FE_Balances
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_Balance
                        select FE_BalanceFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_Balance
                        select FE_BalanceFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_Balance>();
                var i = (from p in ctx.DataContext.FE_Balance.Where(exp)
                         select FE_BalanceFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_Balance>();
                var i = from p in ctx.DataContext.FE_Balance.Where(exp)
                         select FE_BalanceFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
