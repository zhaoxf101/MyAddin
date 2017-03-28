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
	public class PM_VoucherSubFactory:Common.Business.PM_VoucherSub
    {
        public static Common.Business.PM_VoucherSub Fetch(PM_VoucherSub data)
        {
            Common.Business.PM_VoucherSub item = (Common.Business.PM_VoucherSub)Activator.CreateInstance(typeof(Common.Business.PM_VoucherSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.VouchNo = data.VouchNo;
				                item.AccYear = data.AccYear;
				                item.LineNR = data.LineNR;
				                item.ItemText = data.ItemText;
				                item.Amt = data.Amt;
				                item.PostBus = data.PostBus;
				                item.PostMark = data.PostMark;
				                item.FundCode = data.FundCode;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.PBudExpFunCode = data.PBudExpFunCode;
				                item.PBudExpItemCode = data.PBudExpItemCode;
				                item.FundExpTypeCode = data.FundExpTypeCode;
				                item.ExpItemRow = data.ExpItemRow;
				                item.ExpItemCode = data.ExpItemCode;
				                item.IsBudItem = data.IsBudItem;
				                item.IsFinItem = data.IsFinItem;
				                item.PersonId = data.PersonId;
				                item.CostCtr = data.CostCtr;
				                item.ContractId = data.ContractId;
				                item.RefLine = data.RefLine;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_VoucherSub>();
                var i = (from p in ctx.DataContext.PM_VoucherSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.VouchNo = i.VouchNo;
										this.AccYear = i.AccYear;
										this.LineNR = i.LineNR;
										this.ItemText = i.ItemText;
										this.Amt = i.Amt;
										this.PostBus = i.PostBus;
										this.PostMark = i.PostMark;
										this.FundCode = i.FundCode;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.PBudExpFunCode = i.PBudExpFunCode;
										this.PBudExpItemCode = i.PBudExpItemCode;
										this.FundExpTypeCode = i.FundExpTypeCode;
										this.ExpItemRow = i.ExpItemRow;
										this.ExpItemCode = i.ExpItemCode;
										this.IsBudItem = i.IsBudItem;
										this.IsFinItem = i.IsFinItem;
										this.PersonId = i.PersonId;
										this.CostCtr = i.CostCtr;
										this.ContractId = i.ContractId;
										this.RefLine = i.RefLine;
					}
            }
        }
	}

	public class PM_VoucherSubsFactory : Common.Business.PM_VoucherSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_VoucherSub
                        select PM_VoucherSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_VoucherSub
                        select PM_VoucherSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_VoucherSub>();
                var i = (from p in ctx.DataContext.PM_VoucherSub.Where(exp)
                         select PM_VoucherSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_VoucherSub>();
                var i = from p in ctx.DataContext.PM_VoucherSub.Where(exp)
                         select PM_VoucherSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
