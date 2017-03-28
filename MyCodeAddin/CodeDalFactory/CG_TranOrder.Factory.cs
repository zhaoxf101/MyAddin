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
	public class CG_TranOrderFactory:Common.Business.CG_TranOrder
    {
        public static Common.Business.CG_TranOrder Fetch(CG_TranOrder data)
        {
            Common.Business.CG_TranOrder item = (Common.Business.CG_TranOrder)Activator.CreateInstance(typeof(Common.Business.CG_TranOrder));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.OrderNo = data.OrderNo;
				                item.OrderText = data.OrderText;
				                item.OrderMemo = data.OrderMemo;
				                item.OrderDate = data.OrderDate;
				                item.OrderDateTime = data.OrderDateTime;
				                item.OrderAmt = data.OrderAmt;
				                item.PayWayCode = data.PayWayCode;
				                item.PersonId = data.PersonId;
				                item.ClientIP = data.ClientIP;
				                item.ClientInfo = data.ClientInfo;
				                item.FeeType = data.FeeType;
				                item.Tel = data.Tel;
				                item.Email = data.Email;
				                item.Status = data.Status;
				                item.SBillNo = data.SBillNo;
				                item.SBillType = data.SBillType;
				                item.IsDelete = data.IsDelete;
				                item.OldId = data.OldId;
				                item.OutTranNo = data.OutTranNo;
				                item.OutDate = data.OutDate;
				                item.SuccessDate = data.SuccessDate;
				                item.CreateDate = data.CreateDate;
				                item.CreateUser = data.CreateUser;
				                item.TName = data.TName;
				                item.PayUnit = data.PayUnit;
				                item.IdNo = data.IdNo;
				                item.FeeOrderId = data.FeeOrderId;
				                item.FeeOrderNo = data.FeeOrderNo;
				                item.OutSign = data.OutSign;
				                item.IsVoice = data.IsVoice;
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
				var exp = lambda.Resolve<CG_TranOrder>();
                var i = (from p in ctx.DataContext.CG_TranOrder.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.OrderNo = i.OrderNo;
										this.OrderText = i.OrderText;
										this.OrderMemo = i.OrderMemo;
										this.OrderDate = i.OrderDate;
										this.OrderDateTime = i.OrderDateTime;
										this.OrderAmt = i.OrderAmt;
										this.PayWayCode = i.PayWayCode;
										this.PersonId = i.PersonId;
										this.ClientIP = i.ClientIP;
										this.ClientInfo = i.ClientInfo;
										this.FeeType = i.FeeType;
										this.Tel = i.Tel;
										this.Email = i.Email;
										this.Status = i.Status;
										this.SBillNo = i.SBillNo;
										this.SBillType = i.SBillType;
										this.IsDelete = i.IsDelete;
										this.OldId = i.OldId;
										this.OutTranNo = i.OutTranNo;
										this.OutDate = i.OutDate;
										this.SuccessDate = i.SuccessDate;
										this.CreateDate = i.CreateDate;
										this.CreateUser = i.CreateUser;
										this.TName = i.TName;
										this.PayUnit = i.PayUnit;
										this.IdNo = i.IdNo;
										this.FeeOrderId = i.FeeOrderId;
										this.FeeOrderNo = i.FeeOrderNo;
										this.OutSign = i.OutSign;
										this.IsVoice = i.IsVoice;
										this.IsOut = i.IsOut;
					}
            }
        }
	}

	public class CG_TranOrdersFactory : Common.Business.CG_TranOrders
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CG_TranOrder
                        select CG_TranOrderFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CG_TranOrder
                        select CG_TranOrderFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CG_TranOrder>();
                var i = (from p in ctx.DataContext.CG_TranOrder.Where(exp)
                         select CG_TranOrderFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CG_TranOrder>();
                var i = from p in ctx.DataContext.CG_TranOrder.Where(exp)
                         select CG_TranOrderFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
