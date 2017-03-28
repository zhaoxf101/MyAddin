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
	public class FI_WoffLoanSubFactory:Common.Business.FI_WoffLoanSub
    {
        public static Common.Business.FI_WoffLoanSub Fetch(FI_WoffLoanSub data)
        {
            Common.Business.FI_WoffLoanSub item = (Common.Business.FI_WoffLoanSub)Activator.CreateInstance(typeof(Common.Business.FI_WoffLoanSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.WoffCode = data.WoffCode;
				                item.VouchNo = data.VouchNo;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.LineNR = data.LineNR;
				                item.FundCode = data.FundCode;
				                item.LoanCode = data.LoanCode;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ContractId = data.ContractId;
				                item.Amt = data.Amt;
				                item.ActAmt = data.ActAmt;
				                item.ItemText = data.ItemText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_WoffLoanSub>();
                var i = (from p in ctx.DataContext.FI_WoffLoanSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.WoffCode = i.WoffCode;
										this.VouchNo = i.VouchNo;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.LineNR = i.LineNR;
										this.FundCode = i.FundCode;
										this.LoanCode = i.LoanCode;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ContractId = i.ContractId;
										this.Amt = i.Amt;
										this.ActAmt = i.ActAmt;
										this.ItemText = i.ItemText;
					}
            }
        }
	}

	public class FI_WoffLoanSubsFactory : Common.Business.FI_WoffLoanSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_WoffLoanSub
                        select FI_WoffLoanSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_WoffLoanSub
                        select FI_WoffLoanSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_WoffLoanSub>();
                var i = (from p in ctx.DataContext.FI_WoffLoanSub.Where(exp)
                         select FI_WoffLoanSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_WoffLoanSub>();
                var i = from p in ctx.DataContext.FI_WoffLoanSub.Where(exp)
                         select FI_WoffLoanSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
