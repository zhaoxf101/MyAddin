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
	public class CG_OrderFactory:Common.Business.CG_Order
    {
        public static Common.Business.CG_Order Fetch(CG_Order data)
        {
            Common.Business.CG_Order item = (Common.Business.CG_Order)Activator.CreateInstance(typeof(Common.Business.CG_Order));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.OrderNo = data.OrderNo;
				                item.BillNo = data.BillNo;
				                item.IntervalCode = data.IntervalCode;
				                item.FeeItemCode = data.FeeItemCode;
				                item.BillText = data.BillText;
				                item.SText = data.SText;
				                item.Memo = data.Memo;
				                item.UserGroup = data.UserGroup;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.IsSub = data.IsSub;
				                item.IsSpecAmt = data.IsSpecAmt;
				                item.IsOnce = data.IsOnce;
				                item.CreateUser = data.CreateUser;
				                item.CreateDate = data.CreateDate;
				                item.ChangeUser = data.ChangeUser;
				                item.ChangeDate = data.ChangeDate;
				                item.OrderAmt = data.OrderAmt;
				                item.CAmt = data.CAmt;
				                item.AdjAmt = data.AdjAmt;
				                item.IsClose = data.IsClose;
				                item.DepCode = data.DepCode;
				                item.IsOut = data.IsOut;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CG_Order>();
                var i = (from p in ctx.DataContext.CG_Order.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.OrderNo = i.OrderNo;
										this.BillNo = i.BillNo;
										this.IntervalCode = i.IntervalCode;
										this.FeeItemCode = i.FeeItemCode;
										this.BillText = i.BillText;
										this.SText = i.SText;
										this.Memo = i.Memo;
										this.UserGroup = i.UserGroup;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.IsSub = i.IsSub;
										this.IsSpecAmt = i.IsSpecAmt;
										this.IsOnce = i.IsOnce;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
										this.OrderAmt = i.OrderAmt;
										this.CAmt = i.CAmt;
										this.AdjAmt = i.AdjAmt;
										this.IsClose = i.IsClose;
										this.DepCode = i.DepCode;
										this.IsOut = i.IsOut;
					}
            }
        }
	}

	public class CG_OrdersFactory : Common.Business.CG_Orders
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CG_Order
                        select CG_OrderFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CG_Order
                        select CG_OrderFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CG_Order>();
                var i = (from p in ctx.DataContext.CG_Order.Where(exp)
                         select CG_OrderFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CG_Order>();
                var i = from p in ctx.DataContext.CG_Order.Where(exp)
                         select CG_OrderFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
