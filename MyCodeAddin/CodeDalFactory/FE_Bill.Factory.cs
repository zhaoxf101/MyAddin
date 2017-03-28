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
	public class FE_BillFactory:Common.Business.FE_Bill
    {
        public static Common.Business.FE_Bill Fetch(FE_Bill data)
        {
            Common.Business.FE_Bill item = (Common.Business.FE_Bill)Activator.CreateInstance(typeof(Common.Business.FE_Bill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Bill_Id = data.Bill_Id;
				                item.TradeTime = data.TradeTime;
				                item.AppId = data.AppId;
				                item.Mch_Id = data.Mch_Id;
				                item.Sub_Mch_Id = data.Sub_Mch_Id;
				                item.Device_Info = data.Device_Info;
				                item.Transaction_Id = data.Transaction_Id;
				                item.Out_Trade_No = data.Out_Trade_No;
				                item.OpenId = data.OpenId;
				                item.Trade_Type = data.Trade_Type;
				                item.TradeStatus = data.TradeStatus;
				                item.Bank = data.Bank;
				                item.Fee_Type = data.Fee_Type;
				                item.Total_Fee = data.Total_Fee;
				                item.RedPacketMoney = data.RedPacketMoney;
				                item.WX_Refund_No = data.WX_Refund_No;
				                item.SH_Refund_No = data.SH_Refund_No;
				                item.RefundMoney = data.RefundMoney;
				                item.RedPacketRefund = data.RedPacketRefund;
				                item.RefundType = data.RefundType;
				                item.RefundStatus = data.RefundStatus;
				                item.Body = data.Body;
				                item.Attach = data.Attach;
				                item.Fee = data.Fee;
				                item.Fee_Rate = data.Fee_Rate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_Bill>();
                var i = (from p in ctx.DataContext.FE_Bill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Bill_Id = i.Bill_Id;
										this.TradeTime = i.TradeTime;
										this.AppId = i.AppId;
										this.Mch_Id = i.Mch_Id;
										this.Sub_Mch_Id = i.Sub_Mch_Id;
										this.Device_Info = i.Device_Info;
										this.Transaction_Id = i.Transaction_Id;
										this.Out_Trade_No = i.Out_Trade_No;
										this.OpenId = i.OpenId;
										this.Trade_Type = i.Trade_Type;
										this.TradeStatus = i.TradeStatus;
										this.Bank = i.Bank;
										this.Fee_Type = i.Fee_Type;
										this.Total_Fee = i.Total_Fee;
										this.RedPacketMoney = i.RedPacketMoney;
										this.WX_Refund_No = i.WX_Refund_No;
										this.SH_Refund_No = i.SH_Refund_No;
										this.RefundMoney = i.RefundMoney;
										this.RedPacketRefund = i.RedPacketRefund;
										this.RefundType = i.RefundType;
										this.RefundStatus = i.RefundStatus;
										this.Body = i.Body;
										this.Attach = i.Attach;
										this.Fee = i.Fee;
										this.Fee_Rate = i.Fee_Rate;
					}
            }
        }
	}

	public class FE_BillsFactory : Common.Business.FE_Bills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_Bill
                        select FE_BillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_Bill
                        select FE_BillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_Bill>();
                var i = (from p in ctx.DataContext.FE_Bill.Where(exp)
                         select FE_BillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_Bill>();
                var i = from p in ctx.DataContext.FE_Bill.Where(exp)
                         select FE_BillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
