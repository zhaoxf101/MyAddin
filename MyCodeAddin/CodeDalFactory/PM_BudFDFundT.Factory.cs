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
	public class PM_BudFDFundTFactory:Common.Business.PM_BudFDFundT
    {
        public static Common.Business.PM_BudFDFundT Fetch(PM_BudFDFundT data)
        {
            Common.Business.PM_BudFDFundT item = (Common.Business.PM_BudFDFundT)Activator.CreateInstance(typeof(Common.Business.PM_BudFDFundT));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.TaskCode = data.TaskCode;
				                item.FundCode = data.FundCode;
				                item.AppNo = data.AppNo;
				                item.Year = data.Year;
				                item.ProjCode = data.ProjCode;
				                item.FundBudAreaCode = data.FundBudAreaCode;
				                item.FundFinAreaCode = data.FundFinAreaCode;
				                item.PBudExpFunCode = data.PBudExpFunCode;
				                item.IsPBud = data.IsPBud;
				                item.IsAdd = data.IsAdd;
				                item.CanChg = data.CanChg;
				                item.AccCode = data.AccCode;
				                item.ExpSort = data.ExpSort;
				                item.IsExpSort = data.IsExpSort;
				                item.IsBudItem = data.IsBudItem;
				                item.IsFinItem = data.IsFinItem;
				                item.IsCarryOver = data.IsCarryOver;
				                item.IsCarryOverIn = data.IsCarryOverIn;
				                item.IsCarryRedu = data.IsCarryRedu;
				                item.IsInCtrl = data.IsInCtrl;
				                item.MaxDeficit = data.MaxDeficit;
				                item.IsFreeze = data.IsFreeze;
				                item.IsSpecial = data.IsSpecial;
				                item.BudAmt = data.BudAmt;
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
				var exp = lambda.Resolve<PM_BudFDFundT>();
                var i = (from p in ctx.DataContext.PM_BudFDFundT.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TaskCode = i.TaskCode;
										this.FundCode = i.FundCode;
										this.AppNo = i.AppNo;
										this.Year = i.Year;
										this.ProjCode = i.ProjCode;
										this.FundBudAreaCode = i.FundBudAreaCode;
										this.FundFinAreaCode = i.FundFinAreaCode;
										this.PBudExpFunCode = i.PBudExpFunCode;
										this.IsPBud = i.IsPBud;
										this.IsAdd = i.IsAdd;
										this.CanChg = i.CanChg;
										this.AccCode = i.AccCode;
										this.ExpSort = i.ExpSort;
										this.IsExpSort = i.IsExpSort;
										this.IsBudItem = i.IsBudItem;
										this.IsFinItem = i.IsFinItem;
										this.IsCarryOver = i.IsCarryOver;
										this.IsCarryOverIn = i.IsCarryOverIn;
										this.IsCarryRedu = i.IsCarryRedu;
										this.IsInCtrl = i.IsInCtrl;
										this.MaxDeficit = i.MaxDeficit;
										this.IsFreeze = i.IsFreeze;
										this.IsSpecial = i.IsSpecial;
										this.BudAmt = i.BudAmt;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_BudFDFundTsFactory : Common.Business.PM_BudFDFundTs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_BudFDFundT
                        select PM_BudFDFundTFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_BudFDFundT
                        select PM_BudFDFundTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_BudFDFundT>();
                var i = (from p in ctx.DataContext.PM_BudFDFundT.Where(exp)
                         select PM_BudFDFundTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_BudFDFundT>();
                var i = from p in ctx.DataContext.PM_BudFDFundT.Where(exp)
                         select PM_BudFDFundTFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
