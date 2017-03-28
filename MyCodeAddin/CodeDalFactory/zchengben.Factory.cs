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
	public class zchengbenFactory:Common.Business.zchengben
    {
        public static Common.Business.zchengben Fetch(zchengben data)
        {
            Common.Business.zchengben item = (Common.Business.zchengben)Activator.CreateInstance(typeof(Common.Business.zchengben));
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
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<zchengben>();
                var i = (from p in ctx.DataContext.zchengben.Where(exp)
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
					}
            }
        }
	}

	public class zchengbensFactory : Common.Business.zchengbens
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.zchengben
                        select zchengbenFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.zchengben
                        select zchengbenFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<zchengben>();
                var i = (from p in ctx.DataContext.zchengben.Where(exp)
                         select zchengbenFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<zchengben>();
                var i = from p in ctx.DataContext.zchengben.Where(exp)
                         select zchengbenFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
