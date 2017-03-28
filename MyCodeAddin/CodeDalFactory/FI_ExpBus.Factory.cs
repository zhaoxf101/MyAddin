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
	public class FI_ExpBusFactory:Common.Business.FI_ExpBus
    {
        public static Common.Business.FI_ExpBus Fetch(FI_ExpBus data)
        {
            Common.Business.FI_ExpBus item = (Common.Business.FI_ExpBus)Activator.CreateInstance(typeof(Common.Business.FI_ExpBus));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpBusCode = data.ExpBusCode;
				                item.ExpTypeCode = data.ExpTypeCode;
				                item.ExpBusText = data.ExpBusText;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.WorkFlowID = data.WorkFlowID;
				                item.ExpAmt = data.ExpAmt;
				                item.ActAmt = data.ActAmt;
				                item.ActTaxAmt = data.ActTaxAmt;
				                item.DocQty = data.DocQty;
				                item.ActDocQty = data.ActDocQty;
				                item.Description = data.Description;
				                item.BarCode = data.BarCode;
				                item.Cancelled = data.Cancelled;
				                item.Approved = data.Approved;
				                item.IsDetails = data.IsDetails;
				                item.IsSubmit = data.IsSubmit;
				                item.IsBatch = data.IsBatch;
				                item.ExpBusUser = data.ExpBusUser;
				                item.CostCtr = data.CostCtr;
				                item.ExpItemId = data.ExpItemId;
				                item.ExpItemCode = data.ExpItemCode;
				                item.ResouItemCode = data.ResouItemCode;
				                item.AccDateTime = data.AccDateTime;
				                item.GenVouX = data.GenVouX;
				                item.VouchNo = data.VouchNo;
				                item.VouchText = data.VouchText;
				                item.RelationNo = data.RelationNo;
				                item.TransferAppNo = data.TransferAppNo;
				                item.ProfitCtr = data.ProfitCtr;
				                item.TimeStamp = data.TimeStamp;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.SIncItemCode = data.SIncItemCode;
				                item.IncDepCode = data.IncDepCode;
				                item.ContractId = data.ContractId;
				                item.VendorCode = data.VendorCode;
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
				var exp = lambda.Resolve<FI_ExpBus>();
                var i = (from p in ctx.DataContext.FI_ExpBus.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpBusCode = i.ExpBusCode;
										this.ExpTypeCode = i.ExpTypeCode;
										this.ExpBusText = i.ExpBusText;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.WorkFlowID = i.WorkFlowID;
										this.ExpAmt = i.ExpAmt;
										this.ActAmt = i.ActAmt;
										this.ActTaxAmt = i.ActTaxAmt;
										this.DocQty = i.DocQty;
										this.ActDocQty = i.ActDocQty;
										this.Description = i.Description;
										this.BarCode = i.BarCode;
										this.Cancelled = i.Cancelled;
										this.Approved = i.Approved;
										this.IsDetails = i.IsDetails;
										this.IsSubmit = i.IsSubmit;
										this.IsBatch = i.IsBatch;
										this.ExpBusUser = i.ExpBusUser;
										this.CostCtr = i.CostCtr;
										this.ExpItemId = i.ExpItemId;
										this.ExpItemCode = i.ExpItemCode;
										this.ResouItemCode = i.ResouItemCode;
										this.AccDateTime = i.AccDateTime;
										this.GenVouX = i.GenVouX;
										this.VouchNo = i.VouchNo;
										this.VouchText = i.VouchText;
										this.RelationNo = i.RelationNo;
										this.TransferAppNo = i.TransferAppNo;
										this.ProfitCtr = i.ProfitCtr;
										this.TimeStamp = i.TimeStamp;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.SIncItemCode = i.SIncItemCode;
										this.IncDepCode = i.IncDepCode;
										this.ContractId = i.ContractId;
										this.VendorCode = i.VendorCode;
										this.IsConfBill = i.IsConfBill;
										this.UseText = i.UseText;
					}
            }
        }
	}

	public class FI_ExpBussFactory : Common.Business.FI_ExpBuss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpBus
                        select FI_ExpBusFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpBus
                        select FI_ExpBusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpBus>();
                var i = (from p in ctx.DataContext.FI_ExpBus.Where(exp)
                         select FI_ExpBusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpBus>();
                var i = from p in ctx.DataContext.FI_ExpBus.Where(exp)
                         select FI_ExpBusFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
