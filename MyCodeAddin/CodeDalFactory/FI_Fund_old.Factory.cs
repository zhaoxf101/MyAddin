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
	public class FI_Fund_oldFactory:Common.Business.FI_Fund_old
    {
        public static Common.Business.FI_Fund_old Fetch(FI_Fund_old data)
        {
            Common.Business.FI_Fund_old item = (Common.Business.FI_Fund_old)Activator.CreateInstance(typeof(Common.Business.FI_Fund_old));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.FundCode = data.FundCode;
				                item.FundName = data.FundName;
				                item.IsGroup = data.IsGroup;
				                item.FundTypeCode = data.FundTypeCode;
				                item.FundBudAreaCode = data.FundBudAreaCode;
				                item.ExpFundTypeCode = data.ExpFundTypeCode;
				                item.FundIncTypeCode = data.FundIncTypeCode;
				                item.FundUTypeCode = data.FundUTypeCode;
				                item.CAccCode = data.CAccCode;
				                item.IsBudItem = data.IsBudItem;
				                item.IsFinItem = data.IsFinItem;
				                item.IsLock = data.IsLock;
				                item.IsFreeze = data.IsFreeze;
				                item.IsSpecial = data.IsSpecial;
				                item.Memo = data.Memo;
				                item.PConCode = data.PConCode;
				                item.PProjConCode = data.PProjConCode;
				                item.FundExpTypeCode = data.FundExpTypeCode;
				                item.Active = data.Active;
				                item.IsCarryOver = data.IsCarryOver;
				                item.CanDeficit = data.CanDeficit;
				                item.IsDeficit = data.IsDeficit;
				                item.CanLoan = data.CanLoan;
				                item.IsPirFund = data.IsPirFund;
				                item.Leader = data.Leader;
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
				var exp = lambda.Resolve<FI_Fund_old>();
                var i = (from p in ctx.DataContext.FI_Fund_old.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.FundCode = i.FundCode;
										this.FundName = i.FundName;
										this.IsGroup = i.IsGroup;
										this.FundTypeCode = i.FundTypeCode;
										this.FundBudAreaCode = i.FundBudAreaCode;
										this.ExpFundTypeCode = i.ExpFundTypeCode;
										this.FundIncTypeCode = i.FundIncTypeCode;
										this.FundUTypeCode = i.FundUTypeCode;
										this.CAccCode = i.CAccCode;
										this.IsBudItem = i.IsBudItem;
										this.IsFinItem = i.IsFinItem;
										this.IsLock = i.IsLock;
										this.IsFreeze = i.IsFreeze;
										this.IsSpecial = i.IsSpecial;
										this.Memo = i.Memo;
										this.PConCode = i.PConCode;
										this.PProjConCode = i.PProjConCode;
										this.FundExpTypeCode = i.FundExpTypeCode;
										this.Active = i.Active;
										this.IsCarryOver = i.IsCarryOver;
										this.CanDeficit = i.CanDeficit;
										this.IsDeficit = i.IsDeficit;
										this.CanLoan = i.CanLoan;
										this.IsPirFund = i.IsPirFund;
										this.Leader = i.Leader;
										this.ProjCode = i.ProjCode;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_Fund_oldsFactory : Common.Business.FI_Fund_olds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_Fund_old
                        select FI_Fund_oldFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_Fund_old
                        select FI_Fund_oldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_Fund_old>();
                var i = (from p in ctx.DataContext.FI_Fund_old.Where(exp)
                         select FI_Fund_oldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_Fund_old>();
                var i = from p in ctx.DataContext.FI_Fund_old.Where(exp)
                         select FI_Fund_oldFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
