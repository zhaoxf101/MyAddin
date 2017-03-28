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
	public class CO_CostAreaFactory:Common.Business.CO_CostArea
    {
        public static Common.Business.CO_CostArea Fetch(CO_CostArea data)
        {
            Common.Business.CO_CostArea item = (Common.Business.CO_CostArea)Activator.CreateInstance(typeof(Common.Business.CO_CostArea));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.CostArea = data.CostArea;
				                item.DText = data.DText;
				                item.CostStdLev = data.CostStdLev;
				                item.ProfitStdLev = data.ProfitStdLev;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CO_CostArea>();
                var i = (from p in ctx.DataContext.CO_CostArea.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.CostArea = i.CostArea;
										this.DText = i.DText;
										this.CostStdLev = i.CostStdLev;
										this.ProfitStdLev = i.ProfitStdLev;
					}
            }
        }
	}

	public class CO_CostAreasFactory : Common.Business.CO_CostAreas
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CO_CostArea
                        select CO_CostAreaFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CO_CostArea
                        select CO_CostAreaFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CO_CostArea>();
                var i = (from p in ctx.DataContext.CO_CostArea.Where(exp)
                         select CO_CostAreaFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CO_CostArea>();
                var i = from p in ctx.DataContext.CO_CostArea.Where(exp)
                         select CO_CostAreaFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
