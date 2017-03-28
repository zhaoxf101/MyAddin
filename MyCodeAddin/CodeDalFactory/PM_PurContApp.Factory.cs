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
	public class PM_PurContAppFactory:Common.Business.PM_PurContApp
    {
        public static Common.Business.PM_PurContApp Fetch(PM_PurContApp data)
        {
            Common.Business.PM_PurContApp item = (Common.Business.PM_PurContApp)Activator.CreateInstance(typeof(Common.Business.PM_PurContApp));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ContractId = data.ContractId;
				                item.SignNo = data.SignNo;
				                item.PurContAppBusCode = data.PurContAppBusCode;
				                item.BidNo = data.BidNo;
				                item.ContName = data.ContName;
				                item.PurContent = data.PurContent;
				                item.OContractId = data.OContractId;
				                item.PurContTypeCode = data.PurContTypeCode;
				                item.PurTypeCode = data.PurTypeCode;
				                item.PurActCode = data.PurActCode;
				                item.IsAss = data.IsAss;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.VendorCode = data.VendorCode;
				                item.SignDate = data.SignDate;
				                item.EffectDate = data.EffectDate;
				                item.EndDate = data.EndDate;
				                item.PlanAmt = data.PlanAmt;
				                item.ContAmt = data.ContAmt;
				                item.FinalAmt = data.FinalAmt;
				                item.PerfAmt = data.PerfAmt;
				                item.GuaranteeMoney = data.GuaranteeMoney;
				                item.MaxExpRate = data.MaxExpRate;
				                item.IsPayTerms = data.IsPayTerms;
				                item.BankInstitutions = data.BankInstitutions;
				                item.UnitedBankId = data.UnitedBankId;
				                item.IsToPub = data.IsToPub;
				                item.BankCode = data.BankCode;
				                item.BankDep = data.BankDep;
				                item.Memo = data.Memo;
				                item.Operator = data.Operator;
				                item.IsCreate = data.IsCreate;
				                item.IsAppr = data.IsAppr;
				                item.IsCheck = data.IsCheck;
				                item.Cancelled = data.Cancelled;
				                item.Approved = data.Approved;
				                item.ObjectId = data.ObjectId;
				                item.WorkflowId = data.WorkflowId;
				                item.Active = data.Active;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_PurContApp>();
                var i = (from p in ctx.DataContext.PM_PurContApp.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ContractId = i.ContractId;
										this.SignNo = i.SignNo;
										this.PurContAppBusCode = i.PurContAppBusCode;
										this.BidNo = i.BidNo;
										this.ContName = i.ContName;
										this.PurContent = i.PurContent;
										this.OContractId = i.OContractId;
										this.PurContTypeCode = i.PurContTypeCode;
										this.PurTypeCode = i.PurTypeCode;
										this.PurActCode = i.PurActCode;
										this.IsAss = i.IsAss;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.VendorCode = i.VendorCode;
										this.SignDate = i.SignDate;
										this.EffectDate = i.EffectDate;
										this.EndDate = i.EndDate;
										this.PlanAmt = i.PlanAmt;
										this.ContAmt = i.ContAmt;
										this.FinalAmt = i.FinalAmt;
										this.PerfAmt = i.PerfAmt;
										this.GuaranteeMoney = i.GuaranteeMoney;
										this.MaxExpRate = i.MaxExpRate;
										this.IsPayTerms = i.IsPayTerms;
										this.BankInstitutions = i.BankInstitutions;
										this.UnitedBankId = i.UnitedBankId;
										this.IsToPub = i.IsToPub;
										this.BankCode = i.BankCode;
										this.BankDep = i.BankDep;
										this.Memo = i.Memo;
										this.Operator = i.Operator;
										this.IsCreate = i.IsCreate;
										this.IsAppr = i.IsAppr;
										this.IsCheck = i.IsCheck;
										this.Cancelled = i.Cancelled;
										this.Approved = i.Approved;
										this.ObjectId = i.ObjectId;
										this.WorkflowId = i.WorkflowId;
										this.Active = i.Active;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_PurContAppsFactory : Common.Business.PM_PurContApps
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_PurContApp
                        select PM_PurContAppFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_PurContApp
                        select PM_PurContAppFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_PurContApp>();
                var i = (from p in ctx.DataContext.PM_PurContApp.Where(exp)
                         select PM_PurContAppFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_PurContApp>();
                var i = from p in ctx.DataContext.PM_PurContApp.Where(exp)
                         select PM_PurContAppFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
