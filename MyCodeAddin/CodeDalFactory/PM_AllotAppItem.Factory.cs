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
	public class PM_AllotAppItemFactory:Common.Business.PM_AllotAppItem
    {
        public static Common.Business.PM_AllotAppItem Fetch(PM_AllotAppItem data)
        {
            Common.Business.PM_AllotAppItem item = (Common.Business.PM_AllotAppItem)Activator.CreateInstance(typeof(Common.Business.PM_AllotAppItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AllotAppNo = data.AllotAppNo;
				                item.AllotItemCode = data.AllotItemCode;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.PersonId = data.PersonId;
				                item.ResouItemCode = data.ResouItemCode;
				                item.IsNod = data.IsNod;
				                item.IsFixFee = data.IsFixFee;
				                item.DepCode = data.DepCode;
				                item.CostCtr = data.CostCtr;
				                item.IsAcc = data.IsAcc;
				                item.IsExp = data.IsExp;
				                item.FDAmt = data.FDAmt;
				                item.AppAmt = data.AppAmt;
				                item.ExpItemRow = data.ExpItemRow;
				                item.ExpItemCode = data.ExpItemCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.FundCode = data.FundCode;
				                item.CAccCode = data.CAccCode;
				                item.DAccCode = data.DAccCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_AllotAppItem>();
                var i = (from p in ctx.DataContext.PM_AllotAppItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AllotAppNo = i.AllotAppNo;
										this.AllotItemCode = i.AllotItemCode;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.PersonId = i.PersonId;
										this.ResouItemCode = i.ResouItemCode;
										this.IsNod = i.IsNod;
										this.IsFixFee = i.IsFixFee;
										this.DepCode = i.DepCode;
										this.CostCtr = i.CostCtr;
										this.IsAcc = i.IsAcc;
										this.IsExp = i.IsExp;
										this.FDAmt = i.FDAmt;
										this.AppAmt = i.AppAmt;
										this.ExpItemRow = i.ExpItemRow;
										this.ExpItemCode = i.ExpItemCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.FundCode = i.FundCode;
										this.CAccCode = i.CAccCode;
										this.DAccCode = i.DAccCode;
					}
            }
        }
	}

	public class PM_AllotAppItemsFactory : Common.Business.PM_AllotAppItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_AllotAppItem
                        select PM_AllotAppItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_AllotAppItem
                        select PM_AllotAppItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_AllotAppItem>();
                var i = (from p in ctx.DataContext.PM_AllotAppItem.Where(exp)
                         select PM_AllotAppItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_AllotAppItem>();
                var i = from p in ctx.DataContext.PM_AllotAppItem.Where(exp)
                         select PM_AllotAppItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
