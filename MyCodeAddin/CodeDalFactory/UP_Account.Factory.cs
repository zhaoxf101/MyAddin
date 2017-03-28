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
	public class UP_AccountFactory:Common.Business.UP_Account
    {
        public static Common.Business.UP_Account Fetch(UP_Account data)
        {
            Common.Business.UP_Account item = (Common.Business.UP_Account)Activator.CreateInstance(typeof(Common.Business.UP_Account));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.AccountNo = data.AccountNo;
				                item.AccountName = data.AccountName;
				                item.UserCode = data.UserCode;
				                item.InAmount = data.InAmount;
				                item.ExpAccount = data.ExpAccount;
				                item.AccTypeCode = data.AccTypeCode;
				                item.AccountGroupId = data.AccountGroupId;
				                item.Status = data.Status;
				                item.RowStatus = data.RowStatus;
				                item.IsUse = data.IsUse;
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
				var exp = lambda.Resolve<UP_Account>();
                var i = (from p in ctx.DataContext.UP_Account.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.AccountNo = i.AccountNo;
										this.AccountName = i.AccountName;
										this.UserCode = i.UserCode;
										this.InAmount = i.InAmount;
										this.ExpAccount = i.ExpAccount;
										this.AccTypeCode = i.AccTypeCode;
										this.AccountGroupId = i.AccountGroupId;
										this.Status = i.Status;
										this.RowStatus = i.RowStatus;
										this.IsUse = i.IsUse;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
					}
            }
        }
	}

	public class UP_AccountsFactory : Common.Business.UP_Accounts
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_Account
                        select UP_AccountFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_Account
                        select UP_AccountFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_Account>();
                var i = (from p in ctx.DataContext.UP_Account.Where(exp)
                         select UP_AccountFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_Account>();
                var i = from p in ctx.DataContext.UP_Account.Where(exp)
                         select UP_AccountFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
