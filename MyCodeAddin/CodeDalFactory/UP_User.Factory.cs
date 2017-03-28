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
	public class UP_UserFactory:Common.Business.UP_User
    {
        public static Common.Business.UP_User Fetch(UP_User data)
        {
            Common.Business.UP_User item = (Common.Business.UP_User)Activator.CreateInstance(typeof(Common.Business.UP_User));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Id = data.Id;
				                item.UserCode = data.UserCode;
				                item.PayPassword = data.PayPassword;
				                item.IsNoPayPassword = data.IsNoPayPassword;
				                item.FreeAmt = data.FreeAmt;
				                item.PwdInitial = data.PwdInitial;
				                item.AccountId = data.AccountId;
				                item.PhoneNo = data.PhoneNo;
				                item.Email = data.Email;
				                item.Remark = data.Remark;
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
				var exp = lambda.Resolve<UP_User>();
                var i = (from p in ctx.DataContext.UP_User.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Id = i.Id;
										this.UserCode = i.UserCode;
										this.PayPassword = i.PayPassword;
										this.IsNoPayPassword = i.IsNoPayPassword;
										this.FreeAmt = i.FreeAmt;
										this.PwdInitial = i.PwdInitial;
										this.AccountId = i.AccountId;
										this.PhoneNo = i.PhoneNo;
										this.Email = i.Email;
										this.Remark = i.Remark;
										this.RowStatus = i.RowStatus;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
					}
            }
        }
	}

	public class UP_UsersFactory : Common.Business.UP_Users
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_User
                        select UP_UserFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_User
                        select UP_UserFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_User>();
                var i = (from p in ctx.DataContext.UP_User.Where(exp)
                         select UP_UserFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_User>();
                var i = from p in ctx.DataContext.UP_User.Where(exp)
                         select UP_UserFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
