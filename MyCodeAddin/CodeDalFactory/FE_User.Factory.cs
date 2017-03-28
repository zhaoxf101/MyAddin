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
	public class FE_UserFactory:Common.Business.FE_User
    {
        public static Common.Business.FE_User Fetch(FE_User data)
        {
            Common.Business.FE_User item = (Common.Business.FE_User)Activator.CreateInstance(typeof(Common.Business.FE_User));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.AppId = data.AppId;
				                item.OpenId = data.OpenId;
				                item.PersonId = data.PersonId;
				                item.Nickname = data.Nickname;
				                item.Remark = data.Remark;
				                item.Sex = data.Sex;
				                item.HeadImgUrl = data.HeadImgUrl;
				                item.SubscribeTime = data.SubscribeTime;
				                item.UnionID = data.UnionID;
				                item.GroupID = data.GroupID;
				                item.UserState = data.UserState;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_User>();
                var i = (from p in ctx.DataContext.FE_User.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.AppId = i.AppId;
										this.OpenId = i.OpenId;
										this.PersonId = i.PersonId;
										this.Nickname = i.Nickname;
										this.Remark = i.Remark;
										this.Sex = i.Sex;
										this.HeadImgUrl = i.HeadImgUrl;
										this.SubscribeTime = i.SubscribeTime;
										this.UnionID = i.UnionID;
										this.GroupID = i.GroupID;
										this.UserState = i.UserState;
					}
            }
        }
	}

	public class FE_UsersFactory : Common.Business.FE_Users
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_User
                        select FE_UserFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_User
                        select FE_UserFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_User>();
                var i = (from p in ctx.DataContext.FE_User.Where(exp)
                         select FE_UserFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_User>();
                var i = from p in ctx.DataContext.FE_User.Where(exp)
                         select FE_UserFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
