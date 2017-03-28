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
	public class FI_BankTransRecCacheFactory:Common.Business.FI_BankTransRecCache
    {
        public static Common.Business.FI_BankTransRecCache Fetch(FI_BankTransRecCache data)
        {
            Common.Business.FI_BankTransRecCache item = (Common.Business.FI_BankTransRecCache)Activator.CreateInstance(typeof(Common.Business.FI_BankTransRecCache));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.TransactionNo = data.TransactionNo;
				                item.BankId = data.BankId;
				                item.TransactionDate = data.TransactionDate;
				                item.Year = data.Year;
				                item.BankHolder = data.BankHolder;
				                item.BankAccount = data.BankAccount;
				                item.BankInstitutions = data.BankInstitutions;
				                item.Description = data.Description;
				                item.DeCrX = data.DeCrX;
				                item.Amt = data.Amt;
				                item.Balance = data.Balance;
				                item.RBankHolder = data.RBankHolder;
				                item.RBankAccount = data.RBankAccount;
				                item.RBankInstitutions = data.RBankInstitutions;
				                item.Remark = data.Remark;
				                item.IsConfrim = data.IsConfrim;
				                item.TransactionTime = data.TransactionTime;
				                item.RowId = data.RowId;
				                item.ImportBankCode = data.ImportBankCode;
				                item.RelaNo = data.RelaNo;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_BankTransRecCache>();
                var i = (from p in ctx.DataContext.FI_BankTransRecCache.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TransactionNo = i.TransactionNo;
										this.BankId = i.BankId;
										this.TransactionDate = i.TransactionDate;
										this.Year = i.Year;
										this.BankHolder = i.BankHolder;
										this.BankAccount = i.BankAccount;
										this.BankInstitutions = i.BankInstitutions;
										this.Description = i.Description;
										this.DeCrX = i.DeCrX;
										this.Amt = i.Amt;
										this.Balance = i.Balance;
										this.RBankHolder = i.RBankHolder;
										this.RBankAccount = i.RBankAccount;
										this.RBankInstitutions = i.RBankInstitutions;
										this.Remark = i.Remark;
										this.IsConfrim = i.IsConfrim;
										this.TransactionTime = i.TransactionTime;
										this.RowId = i.RowId;
										this.ImportBankCode = i.ImportBankCode;
										this.RelaNo = i.RelaNo;
					}
            }
        }
	}

	public class FI_BankTransRecCachesFactory : Common.Business.FI_BankTransRecCaches
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BankTransRecCache
                        select FI_BankTransRecCacheFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BankTransRecCache
                        select FI_BankTransRecCacheFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BankTransRecCache>();
                var i = (from p in ctx.DataContext.FI_BankTransRecCache.Where(exp)
                         select FI_BankTransRecCacheFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BankTransRecCache>();
                var i = from p in ctx.DataContext.FI_BankTransRecCache.Where(exp)
                         select FI_BankTransRecCacheFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
