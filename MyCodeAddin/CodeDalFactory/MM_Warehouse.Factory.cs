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
	public class MM_WarehouseFactory:Common.Business.MM_Warehouse
    {
        public static Common.Business.MM_Warehouse Fetch(MM_Warehouse data)
        {
            Common.Business.MM_Warehouse item = (Common.Business.MM_Warehouse)Activator.CreateInstance(typeof(Common.Business.MM_Warehouse));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Plant = data.Plant;
				                item.Warehouse = data.Warehouse;
				                item.LText = data.LText;
				                item.CanNegative = data.CanNegative;
				                item.CanMRP = data.CanMRP;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<MM_Warehouse>();
                var i = (from p in ctx.DataContext.MM_Warehouse.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Plant = i.Plant;
										this.Warehouse = i.Warehouse;
										this.LText = i.LText;
										this.CanNegative = i.CanNegative;
										this.CanMRP = i.CanMRP;
					}
            }
        }
	}

	public class MM_WarehousesFactory : Common.Business.MM_Warehouses
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.MM_Warehouse
                        select MM_WarehouseFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.MM_Warehouse
                        select MM_WarehouseFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<MM_Warehouse>();
                var i = (from p in ctx.DataContext.MM_Warehouse.Where(exp)
                         select MM_WarehouseFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<MM_Warehouse>();
                var i = from p in ctx.DataContext.MM_Warehouse.Where(exp)
                         select MM_WarehouseFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
