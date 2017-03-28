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
	public class FI_LoanSubFactory:Common.Business.FI_LoanSub
    {
        public static Common.Business.FI_LoanSub Fetch(FI_LoanSub data)
        {
            Common.Business.FI_LoanSub item = (Common.Business.FI_LoanSub)Activator.CreateInstance(typeof(Common.Business.FI_LoanSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.LoanCode = data.LoanCode;
				                item.TaskCode = data.TaskCode;
				                item.FundCode = data.FundCode;
				                item.LoanAmt = data.LoanAmt;
				                item.LoanActAmt = data.LoanActAmt;
				                item.ExpBusAmt = data.ExpBusAmt;
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
				var exp = lambda.Resolve<FI_LoanSub>();
                var i = (from p in ctx.DataContext.FI_LoanSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.LoanCode = i.LoanCode;
										this.TaskCode = i.TaskCode;
										this.FundCode = i.FundCode;
										this.LoanAmt = i.LoanAmt;
										this.LoanActAmt = i.LoanActAmt;
										this.ExpBusAmt = i.ExpBusAmt;
										this.WoffAmt = i.WoffAmt;
										this.OrdAmt = i.OrdAmt;
					}
            }
        }
	}

	public class FI_LoanSubsFactory : Common.Business.FI_LoanSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_LoanSub
                        select FI_LoanSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_LoanSub
                        select FI_LoanSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_LoanSub>();
                var i = (from p in ctx.DataContext.FI_LoanSub.Where(exp)
                         select FI_LoanSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_LoanSub>();
                var i = from p in ctx.DataContext.FI_LoanSub.Where(exp)
                         select FI_LoanSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
