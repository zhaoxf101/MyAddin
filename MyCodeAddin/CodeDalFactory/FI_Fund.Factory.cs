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
	public class FI_FundFactory:Common.Business.FI_Fund
    {
        public static Common.Business.FI_Fund Fetch(FI_Fund data)
        {
            Common.Business.FI_Fund item = (Common.Business.FI_Fund)Activator.CreateInstance(typeof(Common.Business.FI_Fund));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.FundCode = data.FundCode;
				                item.FundName = data.FundName;
				                item.IsGroup = data.IsGroup;
				                item.FundAccTypeCode = data.FundAccTypeCode;
				                item.FundTypeCode = data.FundTypeCode;
				                item.FundExpTypeCode = data.FundExpTypeCode;
				                item.FundBudAreaCode = data.FundBudAreaCode;
				                item.ExpFundTypeCode = data.ExpFundTypeCode;
				                item.FundIncTypeCode = data.FundIncTypeCode;
				                item.FundUTypeCode = data.FundUTypeCode;
				                item.CtrlAccCode = data.CtrlAccCode;
				                item.AccCode = data.AccCode;
				                item.BAccCode = data.BAccCode;
				                item.FAccCode = data.FAccCode;
				                item.IsBudItem = data.IsBudItem;
				                item.IsFinItem = data.IsFinItem;
				                item.IsPublic = data.IsPublic;
				                item.IsLock = data.IsLock;
				                item.IsLedCarry = data.IsLedCarry;
				                item.IsFreeze = data.IsFreeze;
				                item.IsSpecial = data.IsSpecial;
				                item.IsCtrlAcc = data.IsCtrlAcc;
				                item.DepCode = data.DepCode;
				                item.Memo = data.Memo;
				                item.Active = data.Active;
				                item.PConCode = data.PConCode;
				                item.PProjConCode = data.PProjConCode;
				                item.IsCarryOver = data.IsCarryOver;
				                item.IsDeficit = data.IsDeficit;
				                item.CanLoan = data.CanLoan;
				                item.IsPirFund = data.IsPirFund;
				                item.IsRD = data.IsRD;
				                item.IsEscrow = data.IsEscrow;
				                item.IsInCtrl = data.IsInCtrl;
				                item.IsChkIn = data.IsChkIn;
				                item.IsInterIn = data.IsInterIn;
				                item.LStaff = data.LStaff;
				                item.LPositionCode = data.LPositionCode;
				                item.ProjCode = data.ProjCode;
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
				var exp = lambda.Resolve<FI_Fund>();
                var i = (from p in ctx.DataContext.FI_Fund.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.FundCode = i.FundCode;
										this.FundName = i.FundName;
										this.IsGroup = i.IsGroup;
										this.FundAccTypeCode = i.FundAccTypeCode;
										this.FundTypeCode = i.FundTypeCode;
										this.FundExpTypeCode = i.FundExpTypeCode;
										this.FundBudAreaCode = i.FundBudAreaCode;
										this.ExpFundTypeCode = i.ExpFundTypeCode;
										this.FundIncTypeCode = i.FundIncTypeCode;
										this.FundUTypeCode = i.FundUTypeCode;
										this.CtrlAccCode = i.CtrlAccCode;
										this.AccCode = i.AccCode;
										this.BAccCode = i.BAccCode;
										this.FAccCode = i.FAccCode;
										this.IsBudItem = i.IsBudItem;
										this.IsFinItem = i.IsFinItem;
										this.IsPublic = i.IsPublic;
										this.IsLock = i.IsLock;
										this.IsLedCarry = i.IsLedCarry;
										this.IsFreeze = i.IsFreeze;
										this.IsSpecial = i.IsSpecial;
										this.IsCtrlAcc = i.IsCtrlAcc;
										this.DepCode = i.DepCode;
										this.Memo = i.Memo;
										this.Active = i.Active;
										this.PConCode = i.PConCode;
										this.PProjConCode = i.PProjConCode;
										this.IsCarryOver = i.IsCarryOver;
										this.IsDeficit = i.IsDeficit;
										this.CanLoan = i.CanLoan;
										this.IsPirFund = i.IsPirFund;
										this.IsRD = i.IsRD;
										this.IsEscrow = i.IsEscrow;
										this.IsInCtrl = i.IsInCtrl;
										this.IsChkIn = i.IsChkIn;
										this.IsInterIn = i.IsInterIn;
										this.LStaff = i.LStaff;
										this.LPositionCode = i.LPositionCode;
										this.ProjCode = i.ProjCode;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_FundsFactory : Common.Business.FI_Funds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_Fund
                        select FI_FundFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_Fund
                        select FI_FundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_Fund>();
                var i = (from p in ctx.DataContext.FI_Fund.Where(exp)
                         select FI_FundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_Fund>();
                var i = from p in ctx.DataContext.FI_Fund.Where(exp)
                         select FI_FundFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
