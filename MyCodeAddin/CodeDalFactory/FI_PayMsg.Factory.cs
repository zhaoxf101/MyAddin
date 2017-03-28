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
	public class FI_PayMsgFactory:Common.Business.FI_PayMsg
    {
        public static Common.Business.FI_PayMsg Fetch(FI_PayMsg data)
        {
            Common.Business.FI_PayMsg item = (Common.Business.FI_PayMsg)Activator.CreateInstance(typeof(Common.Business.FI_PayMsg));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.MsgId = data.MsgId;
				                item.RowId = data.RowId;
				                item.PAccount = data.PAccount;
				                item.PAccName = data.PAccName;
				                item.PBankName = data.PBankName;
				                item.PUnitedBankId = data.PUnitedBankId;
				                item.PersonId = data.PersonId;
				                item.RAccount = data.RAccount;
				                item.RAccName = data.RAccName;
				                item.RBankName = data.RBankName;
				                item.RUnitedBankId = data.RUnitedBankId;
				                item.SysIOFlg = data.SysIOFlg;
				                item.IsPublic = data.IsPublic;
				                item.Amt = data.Amt;
				                item.MsgBillNo = data.MsgBillNo;
				                item.ErrorMsg = data.ErrorMsg;
				                item.UseText = data.UseText;
				                item.ReqText1 = data.ReqText1;
				                item.ReqText2 = data.ReqText2;
				                item.IsBankBack = data.IsBankBack;
				                item.IsHandle = data.IsHandle;
				                item.HandleMsgId = data.HandleMsgId;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_PayMsg>();
                var i = (from p in ctx.DataContext.FI_PayMsg.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.MsgId = i.MsgId;
										this.RowId = i.RowId;
										this.PAccount = i.PAccount;
										this.PAccName = i.PAccName;
										this.PBankName = i.PBankName;
										this.PUnitedBankId = i.PUnitedBankId;
										this.PersonId = i.PersonId;
										this.RAccount = i.RAccount;
										this.RAccName = i.RAccName;
										this.RBankName = i.RBankName;
										this.RUnitedBankId = i.RUnitedBankId;
										this.SysIOFlg = i.SysIOFlg;
										this.IsPublic = i.IsPublic;
										this.Amt = i.Amt;
										this.MsgBillNo = i.MsgBillNo;
										this.ErrorMsg = i.ErrorMsg;
										this.UseText = i.UseText;
										this.ReqText1 = i.ReqText1;
										this.ReqText2 = i.ReqText2;
										this.IsBankBack = i.IsBankBack;
										this.IsHandle = i.IsHandle;
										this.HandleMsgId = i.HandleMsgId;
					}
            }
        }
	}

	public class FI_PayMsgsFactory : Common.Business.FI_PayMsgs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PayMsg
                        select FI_PayMsgFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PayMsg
                        select FI_PayMsgFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PayMsg>();
                var i = (from p in ctx.DataContext.FI_PayMsg.Where(exp)
                         select FI_PayMsgFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PayMsg>();
                var i = from p in ctx.DataContext.FI_PayMsg.Where(exp)
                         select FI_PayMsgFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
