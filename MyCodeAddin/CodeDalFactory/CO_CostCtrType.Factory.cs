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
	public class CO_CostCtrTypeFactory:Common.Business.CO_CostCtrType
    {
        public static Common.Business.CO_CostCtrType Fetch(CO_CostCtrType data)
        {
            Common.Business.CO_CostCtrType item = (Common.Business.CO_CostCtrType)Activator.CreateInstance(typeof(Common.Business.CO_CostCtrType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.CostCtrType = data.CostCtrType;
				                item.STEXT = data.STEXT;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CO_CostCtrType>();
                var i = (from p in ctx.DataContext.CO_CostCtrType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.CostCtrType = i.CostCtrType;
										this.STEXT = i.STEXT;
					}
            }
        }
	}

	public class CO_CostCtrTypesFactory : Common.Business.CO_CostCtrTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CO_CostCtrType
                        select CO_CostCtrTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CO_CostCtrType
                        select CO_CostCtrTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CO_CostCtrType>();
                var i = (from p in ctx.DataContext.CO_CostCtrType.Where(exp)
                         select CO_CostCtrTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CO_CostCtrType>();
                var i = from p in ctx.DataContext.CO_CostCtrType.Where(exp)
                         select CO_CostCtrTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
