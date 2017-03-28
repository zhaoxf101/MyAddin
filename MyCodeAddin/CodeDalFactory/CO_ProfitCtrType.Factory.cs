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
	public class CO_ProfitCtrTypeFactory:Common.Business.CO_ProfitCtrType
    {
        public static Common.Business.CO_ProfitCtrType Fetch(CO_ProfitCtrType data)
        {
            Common.Business.CO_ProfitCtrType item = (Common.Business.CO_ProfitCtrType)Activator.CreateInstance(typeof(Common.Business.CO_ProfitCtrType));
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
				var exp = lambda.Resolve<CO_ProfitCtrType>();
                var i = (from p in ctx.DataContext.CO_ProfitCtrType.Where(exp)
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

	public class CO_ProfitCtrTypesFactory : Common.Business.CO_ProfitCtrTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CO_ProfitCtrType
                        select CO_ProfitCtrTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CO_ProfitCtrType
                        select CO_ProfitCtrTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CO_ProfitCtrType>();
                var i = (from p in ctx.DataContext.CO_ProfitCtrType.Where(exp)
                         select CO_ProfitCtrTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CO_ProfitCtrType>();
                var i = from p in ctx.DataContext.CO_ProfitCtrType.Where(exp)
                         select CO_ProfitCtrTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
