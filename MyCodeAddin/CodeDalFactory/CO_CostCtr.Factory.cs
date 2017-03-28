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
	public class CO_CostCtrFactory:Common.Business.CO_CostCtr
    {
        public static Common.Business.CO_CostCtr Fetch(CO_CostCtr data)
        {
            Common.Business.CO_CostCtr item = (Common.Business.CO_CostCtr)Activator.CreateInstance(typeof(Common.Business.CO_CostCtr));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.CostArea = data.CostArea;
				                item.CostCtr = data.CostCtr;
				                item.CostCtrType = data.CostCtrType;
				                item.Leader = data.Leader;
				                item.ProfitCtr = data.ProfitCtr;
				                item.DepCode = data.DepCode;
				                item.SText = data.SText;
				                item.LText = data.LText;
				                item.Active = data.Active;
				                item.IsDel = data.IsDel;
				                item.IsDepCommCostCtr = data.IsDepCommCostCtr;
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
				var exp = lambda.Resolve<CO_CostCtr>();
                var i = (from p in ctx.DataContext.CO_CostCtr.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.CostArea = i.CostArea;
										this.CostCtr = i.CostCtr;
										this.CostCtrType = i.CostCtrType;
										this.Leader = i.Leader;
										this.ProfitCtr = i.ProfitCtr;
										this.DepCode = i.DepCode;
										this.SText = i.SText;
										this.LText = i.LText;
										this.Active = i.Active;
										this.IsDel = i.IsDel;
										this.IsDepCommCostCtr = i.IsDepCommCostCtr;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class CO_CostCtrsFactory : Common.Business.CO_CostCtrs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CO_CostCtr
                        select CO_CostCtrFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CO_CostCtr
                        select CO_CostCtrFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CO_CostCtr>();
                var i = (from p in ctx.DataContext.CO_CostCtr.Where(exp)
                         select CO_CostCtrFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CO_CostCtr>();
                var i = from p in ctx.DataContext.CO_CostCtr.Where(exp)
                         select CO_CostCtrFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
