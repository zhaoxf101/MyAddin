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
	public class FI_BankFactory:Common.Business.FI_Bank
    {
        public static Common.Business.FI_Bank Fetch(FI_Bank data)
        {
            Common.Business.FI_Bank item = (Common.Business.FI_Bank)Activator.CreateInstance(typeof(Common.Business.FI_Bank));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Bank = data.Bank;
				                item.BkSim = data.BkSim;
				                item.BkName = data.BkName;
				                item.DepoName = data.DepoName;
				                item.LText = data.LText;
				                item.Tel = data.Tel;
				                item.TaxId = data.TaxId;
				                item.Name = data.Name;
				                item.ADR = data.ADR;
				                item.Active = data.Active;
				                item.UnitedBankId = data.UnitedBankId;
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
				var exp = lambda.Resolve<FI_Bank>();
                var i = (from p in ctx.DataContext.FI_Bank.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Bank = i.Bank;
										this.BkSim = i.BkSim;
										this.BkName = i.BkName;
										this.DepoName = i.DepoName;
										this.LText = i.LText;
										this.Tel = i.Tel;
										this.TaxId = i.TaxId;
										this.Name = i.Name;
										this.ADR = i.ADR;
										this.Active = i.Active;
										this.UnitedBankId = i.UnitedBankId;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_BanksFactory : Common.Business.FI_Banks
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_Bank
                        select FI_BankFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_Bank
                        select FI_BankFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_Bank>();
                var i = (from p in ctx.DataContext.FI_Bank.Where(exp)
                         select FI_BankFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_Bank>();
                var i = from p in ctx.DataContext.FI_Bank.Where(exp)
                         select FI_BankFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
