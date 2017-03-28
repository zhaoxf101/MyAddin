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
	public class UP_OrderFactory:Common.Business.UP_Order
    {
        public static Common.Business.UP_Order Fetch(UP_Order data)
        {
            Common.Business.UP_Order item = (Common.Business.UP_Order)Activator.CreateInstance(typeof(Common.Business.UP_Order));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.OrderNo = data.OrderNo;
				                item.OrderDate = data.OrderDate;
				                item.OrderTitle = data.OrderTitle;
				                item.RequestId = data.RequestId;
				                item.TradeTypeCode = data.TradeTypeCode;
				                item.ChargeWayCode = data.ChargeWayCode;
				                item.PUserCode = data.PUserCode;
				                item.PAccountNo = data.PAccountNo;
				                item.PAccountId = data.PAccountId;
				                item.RUserCode = data.RUserCode;
				                item.RAccountNo = data.RAccountNo;
				                item.RAccountId = data.RAccountId;
				                item.TradeAmt = data.TradeAmt;
				                item.TradeActAmt = data.TradeActAmt;
				                item.OrderStatus = data.OrderStatus;
				                item.ApiArgs = data.ApiArgs;
				                item.ApiStatus = data.ApiStatus;
				                item.MerchantId = data.MerchantId;
				                item.ShopId = data.ShopId;
				                item.PosId = data.PosId;
				                item.ShopOperator = data.ShopOperator;
				                item.BarCode = data.BarCode;
				                item.PhoneMac = data.PhoneMac;
				                item.Remark = data.Remark;
				                item.OutOrderNo = data.OutOrderNo;
				                item.TradeNo = data.TradeNo;
				                item.TradeDate = data.TradeDate;
				                item.OffsetNo = data.OffsetNo;
				                item.OffsetDate = data.OffsetDate;
				                item.OffsetMark = data.OffsetMark;
				                item.RowStatus = data.RowStatus;
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
				var exp = lambda.Resolve<UP_Order>();
                var i = (from p in ctx.DataContext.UP_Order.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.OrderNo = i.OrderNo;
										this.OrderDate = i.OrderDate;
										this.OrderTitle = i.OrderTitle;
										this.RequestId = i.RequestId;
										this.TradeTypeCode = i.TradeTypeCode;
										this.ChargeWayCode = i.ChargeWayCode;
										this.PUserCode = i.PUserCode;
										this.PAccountNo = i.PAccountNo;
										this.PAccountId = i.PAccountId;
										this.RUserCode = i.RUserCode;
										this.RAccountNo = i.RAccountNo;
										this.RAccountId = i.RAccountId;
										this.TradeAmt = i.TradeAmt;
										this.TradeActAmt = i.TradeActAmt;
										this.OrderStatus = i.OrderStatus;
										this.ApiArgs = i.ApiArgs;
										this.ApiStatus = i.ApiStatus;
										this.MerchantId = i.MerchantId;
										this.ShopId = i.ShopId;
										this.PosId = i.PosId;
										this.ShopOperator = i.ShopOperator;
										this.BarCode = i.BarCode;
										this.PhoneMac = i.PhoneMac;
										this.Remark = i.Remark;
										this.OutOrderNo = i.OutOrderNo;
										this.TradeNo = i.TradeNo;
										this.TradeDate = i.TradeDate;
										this.OffsetNo = i.OffsetNo;
										this.OffsetDate = i.OffsetDate;
										this.OffsetMark = i.OffsetMark;
										this.RowStatus = i.RowStatus;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
					}
            }
        }
	}

	public class UP_OrdersFactory : Common.Business.UP_Orders
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_Order
                        select UP_OrderFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_Order
                        select UP_OrderFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_Order>();
                var i = (from p in ctx.DataContext.UP_Order.Where(exp)
                         select UP_OrderFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_Order>();
                var i = from p in ctx.DataContext.UP_Order.Where(exp)
                         select UP_OrderFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
