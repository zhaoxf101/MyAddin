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
	public class UP_MerchantCLTFactory:Common.Business.UP_MerchantCLT
    {
        public static Common.Business.UP_MerchantCLT Fetch(UP_MerchantCLT data)
        {
            Common.Business.UP_MerchantCLT item = (Common.Business.UP_MerchantCLT)Activator.CreateInstance(typeof(Common.Business.UP_MerchantCLT));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.MerchantId = data.MerchantId;
				                item.BankAccount = data.BankAccount;
				                item.BankName = data.BankName;
				                item.BookName = data.BookName;
				                item.UnitedBankId = data.UnitedBankId;
				                item.AccountId = data.AccountId;
				                item.IsPublic = data.IsPublic;
				                item.UserCode = data.UserCode;
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
				var exp = lambda.Resolve<UP_MerchantCLT>();
                var i = (from p in ctx.DataContext.UP_MerchantCLT.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.MerchantId = i.MerchantId;
										this.BankAccount = i.BankAccount;
										this.BankName = i.BankName;
										this.BookName = i.BookName;
										this.UnitedBankId = i.UnitedBankId;
										this.AccountId = i.AccountId;
										this.IsPublic = i.IsPublic;
										this.UserCode = i.UserCode;
										this.RowStatus = i.RowStatus;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
					}
            }
        }
	}

	public class UP_MerchantCLTsFactory : Common.Business.UP_MerchantCLTs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_MerchantCLT
                        select UP_MerchantCLTFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_MerchantCLT
                        select UP_MerchantCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_MerchantCLT>();
                var i = (from p in ctx.DataContext.UP_MerchantCLT.Where(exp)
                         select UP_MerchantCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_MerchantCLT>();
                var i = from p in ctx.DataContext.UP_MerchantCLT.Where(exp)
                         select UP_MerchantCLTFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
