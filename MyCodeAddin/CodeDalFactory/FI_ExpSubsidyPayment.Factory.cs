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
	public class FI_ExpSubsidyPaymentFactory:Common.Business.FI_ExpSubsidyPayment
    {
        public static Common.Business.FI_ExpSubsidyPayment Fetch(FI_ExpSubsidyPayment data)
        {
            Common.Business.FI_ExpSubsidyPayment item = (Common.Business.FI_ExpSubsidyPayment)Activator.CreateInstance(typeof(Common.Business.FI_ExpSubsidyPayment));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpBusCode = data.ExpBusCode;
				                item.SalaryItemCode = data.SalaryItemCode;
				                item.Staff = data.Staff;
				                item.UType = data.UType;
				                item.Amt = data.Amt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ExpSubsidyPayment>();
                var i = (from p in ctx.DataContext.FI_ExpSubsidyPayment.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpBusCode = i.ExpBusCode;
										this.SalaryItemCode = i.SalaryItemCode;
										this.Staff = i.Staff;
										this.UType = i.UType;
										this.Amt = i.Amt;
					}
            }
        }
	}

	public class FI_ExpSubsidyPaymentsFactory : Common.Business.FI_ExpSubsidyPayments
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpSubsidyPayment
                        select FI_ExpSubsidyPaymentFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpSubsidyPayment
                        select FI_ExpSubsidyPaymentFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpSubsidyPayment>();
                var i = (from p in ctx.DataContext.FI_ExpSubsidyPayment.Where(exp)
                         select FI_ExpSubsidyPaymentFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpSubsidyPayment>();
                var i = from p in ctx.DataContext.FI_ExpSubsidyPayment.Where(exp)
                         select FI_ExpSubsidyPaymentFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
