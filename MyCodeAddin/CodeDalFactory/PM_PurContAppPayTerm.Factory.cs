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
	public class PM_PurContAppPayTermFactory:Common.Business.PM_PurContAppPayTerm
    {
        public static Common.Business.PM_PurContAppPayTerm Fetch(PM_PurContAppPayTerm data)
        {
            Common.Business.PM_PurContAppPayTerm item = (Common.Business.PM_PurContAppPayTerm)Activator.CreateInstance(typeof(Common.Business.PM_PurContAppPayTerm));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ContractId = data.ContractId;
				                item.SignNo = data.SignNo;
				                item.PayNo = data.PayNo;
				                item.PayItemCode = data.PayItemCode;
				                item.PayDate = data.PayDate;
				                item.PayAmt = data.PayAmt;
				                item.CurPayAmt = data.CurPayAmt;
				                item.ExpAmt = data.ExpAmt;
				                item.CanPay = data.CanPay;
				                item.IsN = data.IsN;
				                item.PayMemo = data.PayMemo;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_PurContAppPayTerm>();
                var i = (from p in ctx.DataContext.PM_PurContAppPayTerm.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ContractId = i.ContractId;
										this.SignNo = i.SignNo;
										this.PayNo = i.PayNo;
										this.PayItemCode = i.PayItemCode;
										this.PayDate = i.PayDate;
										this.PayAmt = i.PayAmt;
										this.CurPayAmt = i.CurPayAmt;
										this.ExpAmt = i.ExpAmt;
										this.CanPay = i.CanPay;
										this.IsN = i.IsN;
										this.PayMemo = i.PayMemo;
					}
            }
        }
	}

	public class PM_PurContAppPayTermsFactory : Common.Business.PM_PurContAppPayTerms
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_PurContAppPayTerm
                        select PM_PurContAppPayTermFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_PurContAppPayTerm
                        select PM_PurContAppPayTermFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_PurContAppPayTerm>();
                var i = (from p in ctx.DataContext.PM_PurContAppPayTerm.Where(exp)
                         select PM_PurContAppPayTermFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_PurContAppPayTerm>();
                var i = from p in ctx.DataContext.PM_PurContAppPayTerm.Where(exp)
                         select PM_PurContAppPayTermFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
