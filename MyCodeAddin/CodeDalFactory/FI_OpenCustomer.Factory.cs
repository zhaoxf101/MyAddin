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
	public class FI_OpenCustomerFactory:Common.Business.FI_OpenCustomer
    {
        public static Common.Business.FI_OpenCustomer Fetch(FI_OpenCustomer data)
        {
            Common.Business.FI_OpenCustomer item = (Common.Business.FI_OpenCustomer)Activator.CreateInstance(typeof(Common.Business.FI_OpenCustomer));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.CustCode = data.CustCode;
				                item.VouchNo = data.VouchNo;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.LineNR = data.LineNR;
				                item.SettleDate = data.SettleDate;
				                item.SettleBill = data.SettleBill;
				                item.SettleYear = data.SettleYear;
				                item.SettlePid = data.SettlePid;
				                item.VouType = data.VouType;
				                item.BusType = data.BusType;
				                item.VouDate = data.VouDate;
				                item.PostDate = data.PostDate;
				                item.ReferenceNo = data.ReferenceNo;
				                item.AccCode = data.AccCode;
				                item.PostKey = data.PostKey;
				                item.GLMark = data.GLMark;
				                item.BAccCode = data.BAccCode;
				                item.BPostKey = data.BPostKey;
				                item.FundMark = data.FundMark;
				                item.PostBus = data.PostBus;
				                item.DeCrX = data.DeCrX;
				                item.ItemText = data.ItemText;
				                item.OneTimeX = data.OneTimeX;
				                item.OneTimeParty = data.OneTimeParty;
				                item.InvoiceNo = data.InvoiceNo;
				                item.TaxCode = data.TaxCode;
				                item.LAmt = data.LAmt;
				                item.VAmt = data.VAmt;
				                item.CAmt = data.CAmt;
				                item.OAmt = data.OAmt;
				                item.FundCode = data.FundCode;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ContractId = data.ContractId;
				                item.CostCtr = data.CostCtr;
				                item.ProfitCtr = data.ProfitCtr;
				                item.PersonId = data.PersonId;
				                item.InvClrX = data.InvClrX;
				                item.InvNo = data.InvNo;
				                item.InvYear = data.InvYear;
				                item.InvPid = data.InvPid;
				                item.InvLine = data.InvLine;
				                item.InvDeCr = data.InvDeCr;
				                item.InvRefNo = data.InvRefNo;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_OpenCustomer>();
                var i = (from p in ctx.DataContext.FI_OpenCustomer.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.CustCode = i.CustCode;
										this.VouchNo = i.VouchNo;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.LineNR = i.LineNR;
										this.SettleDate = i.SettleDate;
										this.SettleBill = i.SettleBill;
										this.SettleYear = i.SettleYear;
										this.SettlePid = i.SettlePid;
										this.VouType = i.VouType;
										this.BusType = i.BusType;
										this.VouDate = i.VouDate;
										this.PostDate = i.PostDate;
										this.ReferenceNo = i.ReferenceNo;
										this.AccCode = i.AccCode;
										this.PostKey = i.PostKey;
										this.GLMark = i.GLMark;
										this.BAccCode = i.BAccCode;
										this.BPostKey = i.BPostKey;
										this.FundMark = i.FundMark;
										this.PostBus = i.PostBus;
										this.DeCrX = i.DeCrX;
										this.ItemText = i.ItemText;
										this.OneTimeX = i.OneTimeX;
										this.OneTimeParty = i.OneTimeParty;
										this.InvoiceNo = i.InvoiceNo;
										this.TaxCode = i.TaxCode;
										this.LAmt = i.LAmt;
										this.VAmt = i.VAmt;
										this.CAmt = i.CAmt;
										this.OAmt = i.OAmt;
										this.FundCode = i.FundCode;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ContractId = i.ContractId;
										this.CostCtr = i.CostCtr;
										this.ProfitCtr = i.ProfitCtr;
										this.PersonId = i.PersonId;
										this.InvClrX = i.InvClrX;
										this.InvNo = i.InvNo;
										this.InvYear = i.InvYear;
										this.InvPid = i.InvPid;
										this.InvLine = i.InvLine;
										this.InvDeCr = i.InvDeCr;
										this.InvRefNo = i.InvRefNo;
					}
            }
        }
	}

	public class FI_OpenCustomersFactory : Common.Business.FI_OpenCustomers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_OpenCustomer
                        select FI_OpenCustomerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_OpenCustomer
                        select FI_OpenCustomerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_OpenCustomer>();
                var i = (from p in ctx.DataContext.FI_OpenCustomer.Where(exp)
                         select FI_OpenCustomerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_OpenCustomer>();
                var i = from p in ctx.DataContext.FI_OpenCustomer.Where(exp)
                         select FI_OpenCustomerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
