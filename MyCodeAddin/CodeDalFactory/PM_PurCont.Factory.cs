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
	public class PM_PurContFactory:Common.Business.PM_PurCont
    {
        public static Common.Business.PM_PurCont Fetch(PM_PurCont data)
        {
            Common.Business.PM_PurCont item = (Common.Business.PM_PurCont)Activator.CreateInstance(typeof(Common.Business.PM_PurCont));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ContractId = data.ContractId;
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
				                item.IsPayTerms = data.IsPayTerms;
				                item.SignDate = data.SignDate;
				                item.EffectDate = data.EffectDate;
				                item.EndDate = data.EndDate;
				                item.IsCheck = data.IsCheck;
				                item.PlanAmt = data.PlanAmt;
				                item.ContAmt = data.ContAmt;
				                item.AdjAmt = data.AdjAmt;
				                item.FinalAmt = data.FinalAmt;
				                item.ControlAmt = data.ControlAmt;
				                item.ExpAmt = data.ExpAmt;
				                item.LoanAmt = data.LoanAmt;
				                item.WoffAmt = data.WoffAmt;
				                item.OrdAmt = data.OrdAmt;
				                item.PerfAmt = data.PerfAmt;
				                item.GuaranteeMoney = data.GuaranteeMoney;
				                item.UnitedBankId = data.UnitedBankId;
				                item.IsToPub = data.IsToPub;
				                item.BankDep = data.BankDep;
				                item.BankInstitutions = data.BankInstitutions;
				                item.BankCode = data.BankCode;
				                item.Memo = data.Memo;
				                item.Operator = data.Operator;
				                item.Active = data.Active;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.IsPBuy = data.IsPBuy;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_PurCont>();
                var i = (from p in ctx.DataContext.PM_PurCont.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ContractId = i.ContractId;
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
										this.IsPayTerms = i.IsPayTerms;
										this.SignDate = i.SignDate;
										this.EffectDate = i.EffectDate;
										this.EndDate = i.EndDate;
										this.IsCheck = i.IsCheck;
										this.PlanAmt = i.PlanAmt;
										this.ContAmt = i.ContAmt;
										this.AdjAmt = i.AdjAmt;
										this.FinalAmt = i.FinalAmt;
										this.ControlAmt = i.ControlAmt;
										this.ExpAmt = i.ExpAmt;
										this.LoanAmt = i.LoanAmt;
										this.WoffAmt = i.WoffAmt;
										this.OrdAmt = i.OrdAmt;
										this.PerfAmt = i.PerfAmt;
										this.GuaranteeMoney = i.GuaranteeMoney;
										this.UnitedBankId = i.UnitedBankId;
										this.IsToPub = i.IsToPub;
										this.BankDep = i.BankDep;
										this.BankInstitutions = i.BankInstitutions;
										this.BankCode = i.BankCode;
										this.Memo = i.Memo;
										this.Operator = i.Operator;
										this.Active = i.Active;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.IsPBuy = i.IsPBuy;
					}
            }
        }
	}

	public class PM_PurContsFactory : Common.Business.PM_PurConts
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_PurCont
                        select PM_PurContFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_PurCont
                        select PM_PurContFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_PurCont>();
                var i = (from p in ctx.DataContext.PM_PurCont.Where(exp)
                         select PM_PurContFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_PurCont>();
                var i = from p in ctx.DataContext.PM_PurCont.Where(exp)
                         select PM_PurContFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
