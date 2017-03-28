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
	public class UP_TransactionFactory:Common.Business.UP_Transaction
    {
        public static Common.Business.UP_Transaction Fetch(UP_Transaction data)
        {
            Common.Business.UP_Transaction item = (Common.Business.UP_Transaction)Activator.CreateInstance(typeof(Common.Business.UP_Transaction));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.TradeDate = data.TradeDate;
				                item.TradeNo = data.TradeNo;
				                item.BookDate = data.BookDate;
				                item.OrderId = data.OrderId;
				                item.OrderNo = data.OrderNo;
				                item.OrderDate = data.OrderDate;
				                item.AccountId = data.AccountId;
				                item.AccountNo = data.AccountNo;
				                item.UserCode = data.UserCode;
				                item.TradeTitle = data.TradeTitle;
				                item.Balance = data.Balance;
				                item.TradeAmt = data.TradeAmt;
				                item.TradeActAmt = data.TradeActAmt;
				                item.DeCrX = data.DeCrX;
				                item.Remark = data.Remark;
				                item.CreateUser = data.CreateUser;
				                item.CreateDate = data.CreateDate;
				                item.ChangeUser = data.ChangeUser;
				                item.ChangeDate = data.ChangeDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<UP_Transaction>();
                var i = (from p in ctx.DataContext.UP_Transaction.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.TradeDate = i.TradeDate;
										this.TradeNo = i.TradeNo;
										this.BookDate = i.BookDate;
										this.OrderId = i.OrderId;
										this.OrderNo = i.OrderNo;
										this.OrderDate = i.OrderDate;
										this.AccountId = i.AccountId;
										this.AccountNo = i.AccountNo;
										this.UserCode = i.UserCode;
										this.TradeTitle = i.TradeTitle;
										this.Balance = i.Balance;
										this.TradeAmt = i.TradeAmt;
										this.TradeActAmt = i.TradeActAmt;
										this.DeCrX = i.DeCrX;
										this.Remark = i.Remark;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
					}
            }
        }
	}

	public class UP_TransactionsFactory : Common.Business.UP_Transactions
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_Transaction
                        select UP_TransactionFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_Transaction
                        select UP_TransactionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_Transaction>();
                var i = (from p in ctx.DataContext.UP_Transaction.Where(exp)
                         select UP_TransactionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_Transaction>();
                var i = from p in ctx.DataContext.UP_Transaction.Where(exp)
                         select UP_TransactionFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
