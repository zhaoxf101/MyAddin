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
	public class PM_PurContPayTermFactory:Common.Business.PM_PurContPayTerm
    {
        public static Common.Business.PM_PurContPayTerm Fetch(PM_PurContPayTerm data)
        {
            Common.Business.PM_PurContPayTerm item = (Common.Business.PM_PurContPayTerm)Activator.CreateInstance(typeof(Common.Business.PM_PurContPayTerm));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ContractId = data.ContractId;
				                item.PayNo = data.PayNo;
				                item.PayItemCode = data.PayItemCode;
				                item.SignNo = data.SignNo;
				                item.PayDate = data.PayDate;
				                item.PayAmt = data.PayAmt;
				                item.AdjPayAmt = data.AdjPayAmt;
				                item.ExpAmt = data.ExpAmt;
				                item.CanPay = data.CanPay;
				                item.PayMemo = data.PayMemo;
				                item.LoanAmt = data.LoanAmt;
				                item.WoffAmt = data.WoffAmt;
				                item.OrdAmt = data.OrdAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_PurContPayTerm>();
                var i = (from p in ctx.DataContext.PM_PurContPayTerm.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ContractId = i.ContractId;
										this.PayNo = i.PayNo;
										this.PayItemCode = i.PayItemCode;
										this.SignNo = i.SignNo;
										this.PayDate = i.PayDate;
										this.PayAmt = i.PayAmt;
										this.AdjPayAmt = i.AdjPayAmt;
										this.ExpAmt = i.ExpAmt;
										this.CanPay = i.CanPay;
										this.PayMemo = i.PayMemo;
										this.LoanAmt = i.LoanAmt;
										this.WoffAmt = i.WoffAmt;
										this.OrdAmt = i.OrdAmt;
					}
            }
        }
	}

	public class PM_PurContPayTermsFactory : Common.Business.PM_PurContPayTerms
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_PurContPayTerm
                        select PM_PurContPayTermFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_PurContPayTerm
                        select PM_PurContPayTermFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_PurContPayTerm>();
                var i = (from p in ctx.DataContext.PM_PurContPayTerm.Where(exp)
                         select PM_PurContPayTermFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_PurContPayTerm>();
                var i = from p in ctx.DataContext.PM_PurContPayTerm.Where(exp)
                         select PM_PurContPayTermFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
