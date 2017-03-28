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
	public class FI_BankProxyFactory:Common.Business.FI_BankProxy
    {
        public static Common.Business.FI_BankProxy Fetch(FI_BankProxy data)
        {
            Common.Business.FI_BankProxy item = (Common.Business.FI_BankProxy)Activator.CreateInstance(typeof(Common.Business.FI_BankProxy));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ProxyBankCode = data.ProxyBankCode;
				                item.UnitedBankId = data.UnitedBankId;
				                item.ProxyBankName = data.ProxyBankName;
				                item.ProxyBankUser = data.ProxyBankUser;
				                item.BankId = data.BankId;
				                item.Account = data.Account;
				                item.AccText = data.AccText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_BankProxy>();
                var i = (from p in ctx.DataContext.FI_BankProxy.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ProxyBankCode = i.ProxyBankCode;
										this.UnitedBankId = i.UnitedBankId;
										this.ProxyBankName = i.ProxyBankName;
										this.ProxyBankUser = i.ProxyBankUser;
										this.BankId = i.BankId;
										this.Account = i.Account;
										this.AccText = i.AccText;
					}
            }
        }
	}

	public class FI_BankProxysFactory : Common.Business.FI_BankProxys
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BankProxy
                        select FI_BankProxyFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BankProxy
                        select FI_BankProxyFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BankProxy>();
                var i = (from p in ctx.DataContext.FI_BankProxy.Where(exp)
                         select FI_BankProxyFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BankProxy>();
                var i = from p in ctx.DataContext.FI_BankProxy.Where(exp)
                         select FI_BankProxyFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
