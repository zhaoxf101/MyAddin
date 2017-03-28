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
	public class BK_BankAppInfoFactory:Common.Business.BK_BankAppInfo
    {
        public static Common.Business.BK_BankAppInfo Fetch(BK_BankAppInfo data)
        {
            Common.Business.BK_BankAppInfo item = (Common.Business.BK_BankAppInfo)Activator.CreateInstance(typeof(Common.Business.BK_BankAppInfo));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.MsgId = data.MsgId;
				                item.ItemId = data.ItemId;
				                item.ItemType = data.ItemType;
				                item.ItemText = data.ItemText;
				                item.Account = data.Account;
				                item.AccName = data.AccName;
				                item.BankName = data.BankName;
				                item.UnitedBankId = data.UnitedBankId;
				                item.VouchNo = data.VouchNo;
				                item.HandleUser = data.HandleUser;
				                item.State = data.State;
				                item.Message = data.Message;
				                item.CreateUser = data.CreateUser;
				                item.CreateDate = data.CreateDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<BK_BankAppInfo>();
                var i = (from p in ctx.DataContext.BK_BankAppInfo.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.MsgId = i.MsgId;
										this.ItemId = i.ItemId;
										this.ItemType = i.ItemType;
										this.ItemText = i.ItemText;
										this.Account = i.Account;
										this.AccName = i.AccName;
										this.BankName = i.BankName;
										this.UnitedBankId = i.UnitedBankId;
										this.VouchNo = i.VouchNo;
										this.HandleUser = i.HandleUser;
										this.State = i.State;
										this.Message = i.Message;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
					}
            }
        }
	}

	public class BK_BankAppInfosFactory : Common.Business.BK_BankAppInfos
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.BK_BankAppInfo
                        select BK_BankAppInfoFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.BK_BankAppInfo
                        select BK_BankAppInfoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<BK_BankAppInfo>();
                var i = (from p in ctx.DataContext.BK_BankAppInfo.Where(exp)
                         select BK_BankAppInfoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<BK_BankAppInfo>();
                var i = from p in ctx.DataContext.BK_BankAppInfo.Where(exp)
                         select BK_BankAppInfoFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
