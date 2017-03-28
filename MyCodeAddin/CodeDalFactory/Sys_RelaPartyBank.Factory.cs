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
	public class Sys_RelaPartyBankFactory:Common.Business.Sys_RelaPartyBank
    {
        public static Common.Business.Sys_RelaPartyBank Fetch(Sys_RelaPartyBank data)
        {
            Common.Business.Sys_RelaPartyBank item = (Common.Business.Sys_RelaPartyBank)Activator.CreateInstance(typeof(Common.Business.Sys_RelaPartyBank));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.RelPartyCode = data.RelPartyCode;
				                item.Position = data.Position;
				                item.BankCardNo = data.BankCardNo;
				                item.BankName = data.BankName;
				                item.AccountName = data.AccountName;
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
				var exp = lambda.Resolve<Sys_RelaPartyBank>();
                var i = (from p in ctx.DataContext.Sys_RelaPartyBank.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.RelPartyCode = i.RelPartyCode;
										this.Position = i.Position;
										this.BankCardNo = i.BankCardNo;
										this.BankName = i.BankName;
										this.AccountName = i.AccountName;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class Sys_RelaPartyBanksFactory : Common.Business.Sys_RelaPartyBanks
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_RelaPartyBank
                        select Sys_RelaPartyBankFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_RelaPartyBank
                        select Sys_RelaPartyBankFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_RelaPartyBank>();
                var i = (from p in ctx.DataContext.Sys_RelaPartyBank.Where(exp)
                         select Sys_RelaPartyBankFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_RelaPartyBank>();
                var i = from p in ctx.DataContext.Sys_RelaPartyBank.Where(exp)
                         select Sys_RelaPartyBankFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
