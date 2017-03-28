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
	public class Sys_CustomerCLTFactory:Common.Business.Sys_CustomerCLT
    {
        public static Common.Business.Sys_CustomerCLT Fetch(Sys_CustomerCLT data)
        {
            Common.Business.Sys_CustomerCLT item = (Common.Business.Sys_CustomerCLT)Activator.CreateInstance(typeof(Common.Business.Sys_CustomerCLT));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.CustCode = data.CustCode;
				                item.GLMark = data.GLMark;
				                item.InternalX = data.InternalX;
				                item.PersonId = data.PersonId;
				                item.BankCardNo = data.BankCardNo;
				                item.UnitedBankId = data.UnitedBankId;
				                item.IsToPub = data.IsToPub;
				                item.BankName = data.BankName;
				                item.AccountName = data.AccountName;
				                item.Memo = data.Memo;
				                item.Active = data.Active;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Sys_CustomerCLT>();
                var i = (from p in ctx.DataContext.Sys_CustomerCLT.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.CustCode = i.CustCode;
										this.GLMark = i.GLMark;
										this.InternalX = i.InternalX;
										this.PersonId = i.PersonId;
										this.BankCardNo = i.BankCardNo;
										this.UnitedBankId = i.UnitedBankId;
										this.IsToPub = i.IsToPub;
										this.BankName = i.BankName;
										this.AccountName = i.AccountName;
										this.Memo = i.Memo;
										this.Active = i.Active;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class Sys_CustomerCLTsFactory : Common.Business.Sys_CustomerCLTs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_CustomerCLT
                        select Sys_CustomerCLTFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_CustomerCLT
                        select Sys_CustomerCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_CustomerCLT>();
                var i = (from p in ctx.DataContext.Sys_CustomerCLT.Where(exp)
                         select Sys_CustomerCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_CustomerCLT>();
                var i = from p in ctx.DataContext.Sys_CustomerCLT.Where(exp)
                         select Sys_CustomerCLTFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
