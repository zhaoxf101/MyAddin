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
	public class CO_ProfitCtrGroupFactory:Common.Business.CO_ProfitCtrGroup
    {
        public static Common.Business.CO_ProfitCtrGroup Fetch(CO_ProfitCtrGroup data)
        {
            Common.Business.CO_ProfitCtrGroup item = (Common.Business.CO_ProfitCtrGroup)Activator.CreateInstance(typeof(Common.Business.CO_ProfitCtrGroup));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.CostArea = data.CostArea;
				                item.ProfitCtrGroup = data.ProfitCtrGroup;
				                item.DText = data.DText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CO_ProfitCtrGroup>();
                var i = (from p in ctx.DataContext.CO_ProfitCtrGroup.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.CostArea = i.CostArea;
										this.ProfitCtrGroup = i.ProfitCtrGroup;
										this.DText = i.DText;
					}
            }
        }
	}

	public class CO_ProfitCtrGroupsFactory : Common.Business.CO_ProfitCtrGroups
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CO_ProfitCtrGroup
                        select CO_ProfitCtrGroupFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CO_ProfitCtrGroup
                        select CO_ProfitCtrGroupFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CO_ProfitCtrGroup>();
                var i = (from p in ctx.DataContext.CO_ProfitCtrGroup.Where(exp)
                         select CO_ProfitCtrGroupFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CO_ProfitCtrGroup>();
                var i = from p in ctx.DataContext.CO_ProfitCtrGroup.Where(exp)
                         select CO_ProfitCtrGroupFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
