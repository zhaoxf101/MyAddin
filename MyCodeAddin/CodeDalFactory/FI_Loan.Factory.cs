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
	public class FI_LoanFactory:Common.Business.FI_Loan
    {
        public static Common.Business.FI_Loan Fetch(FI_Loan data)
        {
            Common.Business.FI_Loan item = (Common.Business.FI_Loan)Activator.CreateInstance(typeof(Common.Business.FI_Loan));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.LoanCode = data.LoanCode;
				                item.BusType = data.BusType;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.LoanPurpose = data.LoanPurpose;
				                item.LoanAmt = data.LoanAmt;
				                item.LoanActAmt = data.LoanActAmt;
				                item.ExpBusAmt = data.ExpBusAmt;
				                item.WoffAmt = data.WoffAmt;
				                item.Location = data.Location;
				                item.PeopleCount = data.PeopleCount;
				                item.DepCode = data.DepCode;
				                item.BarCode = data.BarCode;
				                item.Cancelled = data.Cancelled;
				                item.Approved = data.Approved;
				                item.Dismiss = data.Dismiss;
				                item.WorkFlowId = data.WorkFlowId;
				                item.IsSubmit = data.IsSubmit;
				                item.IsDetails = data.IsDetails;
				                item.Description = data.Description;
				                item.ContractId = data.ContractId;
				                item.LoanUser = data.LoanUser;
				                item.CostCtr = data.CostCtr;
				                item.GenVouX = data.GenVouX;
				                item.VouchNo = data.VouchNo;
				                item.VouchText = data.VouchText;
				                item.AccDate = data.AccDate;
				                item.TimeStamp = data.TimeStamp;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.IsConfBill = data.IsConfBill;
				                item.UseText = data.UseText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_Loan>();
                var i = (from p in ctx.DataContext.FI_Loan.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.LoanCode = i.LoanCode;
										this.BusType = i.BusType;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.LoanPurpose = i.LoanPurpose;
										this.LoanAmt = i.LoanAmt;
										this.LoanActAmt = i.LoanActAmt;
										this.ExpBusAmt = i.ExpBusAmt;
										this.WoffAmt = i.WoffAmt;
										this.Location = i.Location;
										this.PeopleCount = i.PeopleCount;
										this.DepCode = i.DepCode;
										this.BarCode = i.BarCode;
										this.Cancelled = i.Cancelled;
										this.Approved = i.Approved;
										this.Dismiss = i.Dismiss;
										this.WorkFlowId = i.WorkFlowId;
										this.IsSubmit = i.IsSubmit;
										this.IsDetails = i.IsDetails;
										this.Description = i.Description;
										this.ContractId = i.ContractId;
										this.LoanUser = i.LoanUser;
										this.CostCtr = i.CostCtr;
										this.GenVouX = i.GenVouX;
										this.VouchNo = i.VouchNo;
										this.VouchText = i.VouchText;
										this.AccDate = i.AccDate;
										this.TimeStamp = i.TimeStamp;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.IsConfBill = i.IsConfBill;
										this.UseText = i.UseText;
					}
            }
        }
	}

	public class FI_LoansFactory : Common.Business.FI_Loans
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_Loan
                        select FI_LoanFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_Loan
                        select FI_LoanFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_Loan>();
                var i = (from p in ctx.DataContext.FI_Loan.Where(exp)
                         select FI_LoanFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_Loan>();
                var i = from p in ctx.DataContext.FI_Loan.Where(exp)
                         select FI_LoanFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
