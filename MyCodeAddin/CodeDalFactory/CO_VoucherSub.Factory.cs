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
	public class CO_VoucherSubFactory:Common.Business.CO_VoucherSub
    {
        public static Common.Business.CO_VoucherSub Fetch(CO_VoucherSub data)
        {
            Common.Business.CO_VoucherSub item = (Common.Business.CO_VoucherSub)Activator.CreateInstance(typeof(Common.Business.CO_VoucherSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.CostArea = data.CostArea;
				                item.AccYear = data.AccYear;
				                item.VouchNo = data.VouchNo;
				                item.LineNR = data.LineNR;
				                item.AccPid = data.AccPid;
				                item.ItemText = data.ItemText;
				                item.DeCrX = data.DeCrX;
				                item.Amt = data.Amt;
				                item.CostElem = data.CostElem;
				                item.PCAElemX = data.PCAElemX;
				                item.CostCtr = data.CostCtr;
				                item.ExpItemCode = data.ExpItemCode;
				                item.ProfitCtr = data.ProfitCtr;
				                item.IncDetCode = data.IncDetCode;
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
				var exp = lambda.Resolve<CO_VoucherSub>();
                var i = (from p in ctx.DataContext.CO_VoucherSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.CostArea = i.CostArea;
										this.AccYear = i.AccYear;
										this.VouchNo = i.VouchNo;
										this.LineNR = i.LineNR;
										this.AccPid = i.AccPid;
										this.ItemText = i.ItemText;
										this.DeCrX = i.DeCrX;
										this.Amt = i.Amt;
										this.CostElem = i.CostElem;
										this.PCAElemX = i.PCAElemX;
										this.CostCtr = i.CostCtr;
										this.ExpItemCode = i.ExpItemCode;
										this.ProfitCtr = i.ProfitCtr;
										this.IncDetCode = i.IncDetCode;
										this.RefLine = i.RefLine;
					}
            }
        }
	}

	public class CO_VoucherSubsFactory : Common.Business.CO_VoucherSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CO_VoucherSub
                        select CO_VoucherSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CO_VoucherSub
                        select CO_VoucherSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CO_VoucherSub>();
                var i = (from p in ctx.DataContext.CO_VoucherSub.Where(exp)
                         select CO_VoucherSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CO_VoucherSub>();
                var i = from p in ctx.DataContext.CO_VoucherSub.Where(exp)
                         select CO_VoucherSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
