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
	public class PM_BudFDFundIFactory:Common.Business.PM_BudFDFundI
    {
        public static Common.Business.PM_BudFDFundI Fetch(PM_BudFDFundI data)
        {
            Common.Business.PM_BudFDFundI item = (Common.Business.PM_BudFDFundI)Activator.CreateInstance(typeof(Common.Business.PM_BudFDFundI));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AppNo = data.AppNo;
				                item.TaskCode = data.TaskCode;
				                item.FundCode = data.FundCode;
				                item.ExpItemRow = data.ExpItemRow;
				                item.Year = data.Year;
				                item.ProjCode = data.ProjCode;
				                item.ExpItemCode = data.ExpItemCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.PBudExpItemCode = data.PBudExpItemCode;
				                item.IsAdd = data.IsAdd;
				                item.CanChg = data.CanChg;
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
				var exp = lambda.Resolve<PM_BudFDFundI>();
                var i = (from p in ctx.DataContext.PM_BudFDFundI.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AppNo = i.AppNo;
										this.TaskCode = i.TaskCode;
										this.FundCode = i.FundCode;
										this.ExpItemRow = i.ExpItemRow;
										this.Year = i.Year;
										this.ProjCode = i.ProjCode;
										this.ExpItemCode = i.ExpItemCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.PBudExpItemCode = i.PBudExpItemCode;
										this.IsAdd = i.IsAdd;
										this.CanChg = i.CanChg;
										this.BudAmt = i.BudAmt;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_BudFDFundIsFactory : Common.Business.PM_BudFDFundIs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_BudFDFundI
                        select PM_BudFDFundIFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_BudFDFundI
                        select PM_BudFDFundIFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_BudFDFundI>();
                var i = (from p in ctx.DataContext.PM_BudFDFundI.Where(exp)
                         select PM_BudFDFundIFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_BudFDFundI>();
                var i = from p in ctx.DataContext.PM_BudFDFundI.Where(exp)
                         select PM_BudFDFundIFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
