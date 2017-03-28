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
	public class EF_UsersFactory:Common.Business.EF_Users
    {
        public static Common.Business.EF_Users Fetch(EF_Users data)
        {
            Common.Business.EF_Users item = (Common.Business.EF_Users)Activator.CreateInstance(typeof(Common.Business.EF_Users));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.BName = data.BName;
				                item.Client = data.Client;
				                item.TName = data.TName;
				                item.Address = data.Address;
				                item.Tel = data.Tel;
				                item.EMail = data.EMail;
				                item.UType = data.UType;
				                item.PersonId = data.PersonId;
				                item.MerchantNo = data.MerchantNo;
				                item.ShopCode = data.ShopCode;
				                item.PassCode = data.PassCode;
				                item.ValidFrom = data.ValidFrom;
				                item.ValidTo = data.ValidTo;
				                item.UserGroup = data.UserGroup;
				                item.ULocked = data.ULocked;
				                item.CRName = data.CRName;
				                item.CRDate = data.CRDate;
				                item.LastUser = data.LastUser;
				                item.LastDate = data.LastDate;
				                item.LoginDate = data.LoginDate;
				                item.PwdChgDate = data.PwdChgDate;
				                item.PwdInitial = data.PwdInitial;
				                item.DateFM = data.DateFM;
				                item.DcpFM = data.DcpFM;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_Users>();
                var i = (from p in ctx.DataContext.EF_Users.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.BName = i.BName;
										this.Client = i.Client;
										this.TName = i.TName;
										this.Address = i.Address;
										this.Tel = i.Tel;
										this.EMail = i.EMail;
										this.UType = i.UType;
										this.PersonId = i.PersonId;
										this.MerchantNo = i.MerchantNo;
										this.ShopCode = i.ShopCode;
										this.PassCode = i.PassCode;
										this.ValidFrom = i.ValidFrom;
										this.ValidTo = i.ValidTo;
										this.UserGroup = i.UserGroup;
										this.ULocked = i.ULocked;
										this.CRName = i.CRName;
										this.CRDate = i.CRDate;
										this.LastUser = i.LastUser;
										this.LastDate = i.LastDate;
										this.LoginDate = i.LoginDate;
										this.PwdChgDate = i.PwdChgDate;
										this.PwdInitial = i.PwdInitial;
										this.DateFM = i.DateFM;
										this.DcpFM = i.DcpFM;
					}
            }
        }
	}

	public class EF_UserssFactory : Common.Business.EF_Userss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_Users
                        select EF_UsersFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_Users
                        select EF_UsersFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_Users>();
                var i = (from p in ctx.DataContext.EF_Users.Where(exp)
                         select EF_UsersFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_Users>();
                var i = from p in ctx.DataContext.EF_Users.Where(exp)
                         select EF_UsersFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
