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
	public class UP_UserPhoneFactory:Common.Business.UP_UserPhone
    {
        public static Common.Business.UP_UserPhone Fetch(UP_UserPhone data)
        {
            Common.Business.UP_UserPhone item = (Common.Business.UP_UserPhone)Activator.CreateInstance(typeof(Common.Business.UP_UserPhone));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Id = data.Id;
				                item.UserCode = data.UserCode;
				                item.PhoneMac = data.PhoneMac;
				                item.LoginTime = data.LoginTime;
				                item.AndroidVersion = data.AndroidVersion;
				                item.PhoneModel = data.PhoneModel;
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
				var exp = lambda.Resolve<UP_UserPhone>();
                var i = (from p in ctx.DataContext.UP_UserPhone.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Id = i.Id;
										this.UserCode = i.UserCode;
										this.PhoneMac = i.PhoneMac;
										this.LoginTime = i.LoginTime;
										this.AndroidVersion = i.AndroidVersion;
										this.PhoneModel = i.PhoneModel;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
					}
            }
        }
	}

	public class UP_UserPhonesFactory : Common.Business.UP_UserPhones
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_UserPhone
                        select UP_UserPhoneFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_UserPhone
                        select UP_UserPhoneFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_UserPhone>();
                var i = (from p in ctx.DataContext.UP_UserPhone.Where(exp)
                         select UP_UserPhoneFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_UserPhone>();
                var i = from p in ctx.DataContext.UP_UserPhone.Where(exp)
                         select UP_UserPhoneFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
