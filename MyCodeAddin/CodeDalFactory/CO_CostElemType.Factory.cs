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
	public class CO_CostElemTypeFactory:Common.Business.CO_CostElemType
    {
        public static Common.Business.CO_CostElemType Fetch(CO_CostElemType data)
        {
            Common.Business.CO_CostElemType item = (Common.Business.CO_CostElemType)Activator.CreateInstance(typeof(Common.Business.CO_CostElemType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.CostElemType = data.CostElemType;
				                item.FirstElemX = data.FirstElemX;
				                item.ProfitElemX = data.ProfitElemX;
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
				var exp = lambda.Resolve<CO_CostElemType>();
                var i = (from p in ctx.DataContext.CO_CostElemType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.CostElemType = i.CostElemType;
										this.FirstElemX = i.FirstElemX;
										this.ProfitElemX = i.ProfitElemX;
										this.SText = i.SText;
										this.LText = i.LText;
					}
            }
        }
	}

	public class CO_CostElemTypesFactory : Common.Business.CO_CostElemTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CO_CostElemType
                        select CO_CostElemTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CO_CostElemType
                        select CO_CostElemTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CO_CostElemType>();
                var i = (from p in ctx.DataContext.CO_CostElemType.Where(exp)
                         select CO_CostElemTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CO_CostElemType>();
                var i = from p in ctx.DataContext.CO_CostElemType.Where(exp)
                         select CO_CostElemTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
