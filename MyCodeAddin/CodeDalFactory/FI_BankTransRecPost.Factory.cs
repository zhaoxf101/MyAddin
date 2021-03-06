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
	public class FI_BankTransRecPostFactory:Common.Business.FI_BankTransRecPost
    {
        public static Common.Business.FI_BankTransRecPost Fetch(FI_BankTransRecPost data)
        {
            Common.Business.FI_BankTransRecPost item = (Common.Business.FI_BankTransRecPost)Activator.CreateInstance(typeof(Common.Business.FI_BankTransRecPost));
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
				                item.ImportBankCode = data.ImportBankCode;
				                item.TransBillNo = data.TransBillNo;
				                item.ItemText = data.ItemText;
				                item.ExpBusCode = data.ExpBusCode;
				                item.RelaNo = data.RelaNo;
				                item.RowId = data.RowId;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_BankTransRecPost>();
                var i = (from p in ctx.DataContext.FI_BankTransRecPost.Where(exp)
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
										this.ImportBankCode = i.ImportBankCode;
										this.TransBillNo = i.TransBillNo;
										this.ItemText = i.ItemText;
										this.ExpBusCode = i.ExpBusCode;
										this.RelaNo = i.RelaNo;
										this.RowId = i.RowId;
					}
            }
        }
	}

	public class FI_BankTransRecPostsFactory : Common.Business.FI_BankTransRecPosts
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BankTransRecPost
                        select FI_BankTransRecPostFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BankTransRecPost
                        select FI_BankTransRecPostFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BankTransRecPost>();
                var i = (from p in ctx.DataContext.FI_BankTransRecPost.Where(exp)
                         select FI_BankTransRecPostFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BankTransRecPost>();
                var i = from p in ctx.DataContext.FI_BankTransRecPost.Where(exp)
                         select FI_BankTransRecPostFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
