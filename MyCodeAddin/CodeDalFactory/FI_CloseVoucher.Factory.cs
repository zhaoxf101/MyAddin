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
	public class FI_CloseVoucherFactory:Common.Business.FI_CloseVoucher
    {
        public static Common.Business.FI_CloseVoucher Fetch(FI_CloseVoucher data)
        {
            Common.Business.FI_CloseVoucher item = (Common.Business.FI_CloseVoucher)Activator.CreateInstance(typeof(Common.Business.FI_CloseVoucher));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AccCode = data.AccCode;
				                item.VouchNo = data.VouchNo;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.LineNR = data.LineNR;
				                item.SettleDate = data.SettleDate;
				                item.SettleBill = data.SettleBill;
				                item.SettleYear = data.SettleYear;
				                item.SettlePid = data.SettlePid;
				                item.AccCls = data.AccCls;
				                item.BAccCode = data.BAccCode;
				                item.BPostKey = data.BPostKey;
				                item.VouType = data.VouType;
				                item.BusType = data.BusType;
				                item.VouDate = data.VouDate;
				                item.PostDate = data.PostDate;
				                item.ReferenceNo = data.ReferenceNo;
				                item.PostKey = data.PostKey;
				                item.AccType = data.AccType;
				                item.FundMark = data.FundMark;
				                item.PostBus = data.PostBus;
				                item.GovPayX = data.GovPayX;
				                item.DeCrX = data.DeCrX;
				                item.ItemText = data.ItemText;
				                item.LAmt = data.LAmt;
				                item.VAmt = data.VAmt;
				                item.CAmt = data.CAmt;
				                item.OAmt = data.OAmt;
				                item.GAmt = data.GAmt;
				                item.CurrCode = data.CurrCode;
				                item.CashType = data.CashType;
				                item.OpenItemX = data.OpenItemX;
				                item.ValueDate = data.ValueDate;
				                item.DueDate = data.DueDate;
				                item.TransactionNo = data.TransactionNo;
				                item.TransactionDate = data.TransactionDate;
				                item.PartyCode = data.PartyCode;
				                item.GLMark = data.GLMark;
				                item.OneTimeX = data.OneTimeX;
				                item.OneTimeParty = data.OneTimeParty;
				                item.InvoiceNo = data.InvoiceNo;
				                item.TaxCode = data.TaxCode;
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
				var exp = lambda.Resolve<FI_CloseVoucher>();
                var i = (from p in ctx.DataContext.FI_CloseVoucher.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AccCode = i.AccCode;
										this.VouchNo = i.VouchNo;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.LineNR = i.LineNR;
										this.SettleDate = i.SettleDate;
										this.SettleBill = i.SettleBill;
										this.SettleYear = i.SettleYear;
										this.SettlePid = i.SettlePid;
										this.AccCls = i.AccCls;
										this.BAccCode = i.BAccCode;
										this.BPostKey = i.BPostKey;
										this.VouType = i.VouType;
										this.BusType = i.BusType;
										this.VouDate = i.VouDate;
										this.PostDate = i.PostDate;
										this.ReferenceNo = i.ReferenceNo;
										this.PostKey = i.PostKey;
										this.AccType = i.AccType;
										this.FundMark = i.FundMark;
										this.PostBus = i.PostBus;
										this.GovPayX = i.GovPayX;
										this.DeCrX = i.DeCrX;
										this.ItemText = i.ItemText;
										this.LAmt = i.LAmt;
										this.VAmt = i.VAmt;
										this.CAmt = i.CAmt;
										this.OAmt = i.OAmt;
										this.GAmt = i.GAmt;
										this.CurrCode = i.CurrCode;
										this.CashType = i.CashType;
										this.OpenItemX = i.OpenItemX;
										this.ValueDate = i.ValueDate;
										this.DueDate = i.DueDate;
										this.TransactionNo = i.TransactionNo;
										this.TransactionDate = i.TransactionDate;
										this.PartyCode = i.PartyCode;
										this.GLMark = i.GLMark;
										this.OneTimeX = i.OneTimeX;
										this.OneTimeParty = i.OneTimeParty;
										this.InvoiceNo = i.InvoiceNo;
										this.TaxCode = i.TaxCode;
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

	public class FI_CloseVouchersFactory : Common.Business.FI_CloseVouchers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_CloseVoucher
                        select FI_CloseVoucherFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_CloseVoucher
                        select FI_CloseVoucherFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_CloseVoucher>();
                var i = (from p in ctx.DataContext.FI_CloseVoucher.Where(exp)
                         select FI_CloseVoucherFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_CloseVoucher>();
                var i = from p in ctx.DataContext.FI_CloseVoucher.Where(exp)
                         select FI_CloseVoucherFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
