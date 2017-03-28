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
	public class FI_PayMsgHeadFactory:Common.Business.FI_PayMsgHead
    {
        public static Common.Business.FI_PayMsgHead Fetch(FI_PayMsgHead data)
        {
            Common.Business.FI_PayMsgHead item = (Common.Business.FI_PayMsgHead)Activator.CreateInstance(typeof(Common.Business.FI_PayMsgHead));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.MsgId = data.MsgId;
				                item.IsSend = data.IsSend;
				                item.IsBankMsg = data.IsBankMsg;
				                item.State = data.State;
				                item.IsProxy = data.IsProxy;
				                item.BKCode = data.BKCode;
				                item.ParkVouchNo = data.ParkVouchNo;
				                item.ProxyMsgId = data.ProxyMsgId;
				                item.TranCode = data.TranCode;
				                item.SendUser = data.SendUser;
				                item.SendDateTime = data.SendDateTime;
				                item.ReturnDateTime = data.ReturnDateTime;
				                item.ReturnCode = data.ReturnCode;
				                item.ReutrnMeg = data.ReutrnMeg;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.CheckUser = data.CheckUser;
				                item.CheckDate = data.CheckDate;
				                item.IsNotice = data.IsNotice;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_PayMsgHead>();
                var i = (from p in ctx.DataContext.FI_PayMsgHead.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.MsgId = i.MsgId;
										this.IsSend = i.IsSend;
										this.IsBankMsg = i.IsBankMsg;
										this.State = i.State;
										this.IsProxy = i.IsProxy;
										this.BKCode = i.BKCode;
										this.ParkVouchNo = i.ParkVouchNo;
										this.ProxyMsgId = i.ProxyMsgId;
										this.TranCode = i.TranCode;
										this.SendUser = i.SendUser;
										this.SendDateTime = i.SendDateTime;
										this.ReturnDateTime = i.ReturnDateTime;
										this.ReturnCode = i.ReturnCode;
										this.ReutrnMeg = i.ReutrnMeg;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.CheckUser = i.CheckUser;
										this.CheckDate = i.CheckDate;
										this.IsNotice = i.IsNotice;
					}
            }
        }
	}

	public class FI_PayMsgHeadsFactory : Common.Business.FI_PayMsgHeads
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PayMsgHead
                        select FI_PayMsgHeadFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PayMsgHead
                        select FI_PayMsgHeadFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PayMsgHead>();
                var i = (from p in ctx.DataContext.FI_PayMsgHead.Where(exp)
                         select FI_PayMsgHeadFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PayMsgHead>();
                var i = from p in ctx.DataContext.FI_PayMsgHead.Where(exp)
                         select FI_PayMsgHeadFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
