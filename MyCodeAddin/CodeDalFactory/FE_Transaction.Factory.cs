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
	public class FE_TransactionFactory:Common.Business.FE_Transaction
    {
        public static Common.Business.FE_Transaction Fetch(FE_Transaction data)
        {
            Common.Business.FE_Transaction item = (Common.Business.FE_Transaction)Activator.CreateInstance(typeof(Common.Business.FE_Transaction));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Out_Trade_No = data.Out_Trade_No;
				                item.Mch_Id = data.Mch_Id;
				                item.AppId = data.AppId;
				                item.Device_Info = data.Device_Info;
				                item.Nonce_Str = data.Nonce_Str;
				                item.Sign = data.Sign;
				                item.Body = data.Body;
				                item.Detail = data.Detail;
				                item.Attach = data.Attach;
				                item.Fee_Type = data.Fee_Type;
				                item.Total_Fee = data.Total_Fee;
				                item.Spbill_Create_IP = data.Spbill_Create_IP;
				                item.Time_Start = data.Time_Start;
				                item.Time_Expire = data.Time_Expire;
				                item.Goods_Tag = data.Goods_Tag;
				                item.Trade_Type = data.Trade_Type;
				                item.Product_Id = data.Product_Id;
				                item.Limit_Pay = data.Limit_Pay;
				                item.OpenId = data.OpenId;
				                item.SignType = data.SignType;
				                item.PaySign = data.PaySign;
				                item.Package = data.Package;
				                item.Transaction_Id = data.Transaction_Id;
				                item.NotifyTime = data.NotifyTime;
				                item.End_Time = data.End_Time;
				                item.CreatedDate = data.CreatedDate;
				                item.BName = data.BName;
				                item.PersonId = data.PersonId;
				                item.TransactionState = data.TransactionState;
				                item.BillState = data.BillState;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_Transaction>();
                var i = (from p in ctx.DataContext.FE_Transaction.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Out_Trade_No = i.Out_Trade_No;
										this.Mch_Id = i.Mch_Id;
										this.AppId = i.AppId;
										this.Device_Info = i.Device_Info;
										this.Nonce_Str = i.Nonce_Str;
										this.Sign = i.Sign;
										this.Body = i.Body;
										this.Detail = i.Detail;
										this.Attach = i.Attach;
										this.Fee_Type = i.Fee_Type;
										this.Total_Fee = i.Total_Fee;
										this.Spbill_Create_IP = i.Spbill_Create_IP;
										this.Time_Start = i.Time_Start;
										this.Time_Expire = i.Time_Expire;
										this.Goods_Tag = i.Goods_Tag;
										this.Trade_Type = i.Trade_Type;
										this.Product_Id = i.Product_Id;
										this.Limit_Pay = i.Limit_Pay;
										this.OpenId = i.OpenId;
										this.SignType = i.SignType;
										this.PaySign = i.PaySign;
										this.Package = i.Package;
										this.Transaction_Id = i.Transaction_Id;
										this.NotifyTime = i.NotifyTime;
										this.End_Time = i.End_Time;
										this.CreatedDate = i.CreatedDate;
										this.BName = i.BName;
										this.PersonId = i.PersonId;
										this.TransactionState = i.TransactionState;
										this.BillState = i.BillState;
					}
            }
        }
	}

	public class FE_TransactionsFactory : Common.Business.FE_Transactions
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_Transaction
                        select FE_TransactionFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_Transaction
                        select FE_TransactionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_Transaction>();
                var i = (from p in ctx.DataContext.FE_Transaction.Where(exp)
                         select FE_TransactionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_Transaction>();
                var i = from p in ctx.DataContext.FE_Transaction.Where(exp)
                         select FE_TransactionFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
