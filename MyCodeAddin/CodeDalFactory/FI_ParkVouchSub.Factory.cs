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
	public class FI_ParkVouchSubFactory:Common.Business.FI_ParkVouchSub
    {
        public static Common.Business.FI_ParkVouchSub Fetch(FI_ParkVouchSub data)
        {
            Common.Business.FI_ParkVouchSub item = (Common.Business.FI_ParkVouchSub)Activator.CreateInstance(typeof(Common.Business.FI_ParkVouchSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AccCode = data.AccCode;
				                item.VouchNo = data.VouchNo;
				                item.LineNR = data.LineNR;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.PartyCode = data.PartyCode;
				                item.AccCls = data.AccCls;
				                item.BAccCode = data.BAccCode;
				                item.BPostKey = data.BPostKey;
				                item.VouType = data.VouType;
				                item.BusType = data.BusType;
				                item.VouDate = data.VouDate;
				                item.PostDate = data.PostDate;
				                item.ReferenceNo = data.ReferenceNo;
				                item.PostKey = data.PostKey;
				                item.GLMark = data.GLMark;
				                item.AccType = data.AccType;
				                item.FundMark = data.FundMark;
				                item.PostBus = data.PostBus;
				                item.GovPayX = data.GovPayX;
				                item.DeCrX = data.DeCrX;
				                item.ItemText = data.ItemText;
				                item.OneTimeX = data.OneTimeX;
				                item.OneTimeParty = data.OneTimeParty;
				                item.InvoiceNo = data.InvoiceNo;
				                item.TaxCode = data.TaxCode;
				                item.LAmt = data.LAmt;
				                item.VAmt = data.VAmt;
				                item.CurrCode = data.CurrCode;
				                item.CashFlowX = data.CashFlowX;
				                item.CashType = data.CashType;
				                item.OpenItemX = data.OpenItemX;
				                item.ValueDate = data.ValueDate;
				                item.DueDate = data.DueDate;
				                item.TransactionNo = data.TransactionNo;
				                item.TransactionDate = data.TransactionDate;
				                item.FundCode = data.FundCode;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.PBudExpFunCode = data.PBudExpFunCode;
				                item.PBudExpItemCode = data.PBudExpItemCode;
				                item.FundExpTypeCode = data.FundExpTypeCode;
				                item.ExpItemRow = data.ExpItemRow;
				                item.ExpItemCode = data.ExpItemCode;
				                item.ContractId = data.ContractId;
				                item.GovPlayCode = data.GovPlayCode;
				                item.PersonId = data.PersonId;
				                item.CostCtr = data.CostCtr;
				                item.ProfitCtr = data.ProfitCtr;
				                item.IncDetCode = data.IncDetCode;
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
				var exp = lambda.Resolve<FI_ParkVouchSub>();
                var i = (from p in ctx.DataContext.FI_ParkVouchSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AccCode = i.AccCode;
										this.VouchNo = i.VouchNo;
										this.LineNR = i.LineNR;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.PartyCode = i.PartyCode;
										this.AccCls = i.AccCls;
										this.BAccCode = i.BAccCode;
										this.BPostKey = i.BPostKey;
										this.VouType = i.VouType;
										this.BusType = i.BusType;
										this.VouDate = i.VouDate;
										this.PostDate = i.PostDate;
										this.ReferenceNo = i.ReferenceNo;
										this.PostKey = i.PostKey;
										this.GLMark = i.GLMark;
										this.AccType = i.AccType;
										this.FundMark = i.FundMark;
										this.PostBus = i.PostBus;
										this.GovPayX = i.GovPayX;
										this.DeCrX = i.DeCrX;
										this.ItemText = i.ItemText;
										this.OneTimeX = i.OneTimeX;
										this.OneTimeParty = i.OneTimeParty;
										this.InvoiceNo = i.InvoiceNo;
										this.TaxCode = i.TaxCode;
										this.LAmt = i.LAmt;
										this.VAmt = i.VAmt;
										this.CurrCode = i.CurrCode;
										this.CashFlowX = i.CashFlowX;
										this.CashType = i.CashType;
										this.OpenItemX = i.OpenItemX;
										this.ValueDate = i.ValueDate;
										this.DueDate = i.DueDate;
										this.TransactionNo = i.TransactionNo;
										this.TransactionDate = i.TransactionDate;
										this.FundCode = i.FundCode;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.PBudExpFunCode = i.PBudExpFunCode;
										this.PBudExpItemCode = i.PBudExpItemCode;
										this.FundExpTypeCode = i.FundExpTypeCode;
										this.ExpItemRow = i.ExpItemRow;
										this.ExpItemCode = i.ExpItemCode;
										this.ContractId = i.ContractId;
										this.GovPlayCode = i.GovPlayCode;
										this.PersonId = i.PersonId;
										this.CostCtr = i.CostCtr;
										this.ProfitCtr = i.ProfitCtr;
										this.IncDetCode = i.IncDetCode;
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

	public class FI_ParkVouchSubsFactory : Common.Business.FI_ParkVouchSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ParkVouchSub
                        select FI_ParkVouchSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ParkVouchSub
                        select FI_ParkVouchSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ParkVouchSub>();
                var i = (from p in ctx.DataContext.FI_ParkVouchSub.Where(exp)
                         select FI_ParkVouchSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ParkVouchSub>();
                var i = from p in ctx.DataContext.FI_ParkVouchSub.Where(exp)
                         select FI_ParkVouchSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
