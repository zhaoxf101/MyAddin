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
	public class MM_MatPlantFactory:Common.Business.MM_MatPlant
    {
        public static Common.Business.MM_MatPlant Fetch(MM_MatPlant data)
        {
            Common.Business.MM_MatPlant item = (Common.Business.MM_MatPlant)Activator.CreateInstance(typeof(Common.Business.MM_MatPlant));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.MaterialCode = data.MaterialCode;
				                item.Plant = data.Plant;
				                item.Warehouse = data.Warehouse;
				                item.IsDel = data.IsDel;
				                item.MatABC = data.MatABC;
				                item.XKeyPart = data.XKeyPart;
				                item.PurGrp = data.PurGrp;
				                item.AUSME = data.AUSME;
				                item.INSMK = data.INSMK;
				                item.LowBalance = data.LowBalance;
				                item.NCOST = data.NCOST;
				                item.ROTATION_DATE = data.ROTATION_DATE;
				                item.UCHKZ = data.UCHKZ;
				                item.UCMAT = data.UCMAT;
				                item.TARGET_STOCK = data.TARGET_STOCK;
				                item.StandPrice = data.StandPrice;
				                item.PEINH = data.PEINH;
				                item.BKLAS = data.BKLAS;
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
				var exp = lambda.Resolve<MM_MatPlant>();
                var i = (from p in ctx.DataContext.MM_MatPlant.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.MaterialCode = i.MaterialCode;
										this.Plant = i.Plant;
										this.Warehouse = i.Warehouse;
										this.IsDel = i.IsDel;
										this.MatABC = i.MatABC;
										this.XKeyPart = i.XKeyPart;
										this.PurGrp = i.PurGrp;
										this.AUSME = i.AUSME;
										this.INSMK = i.INSMK;
										this.LowBalance = i.LowBalance;
										this.NCOST = i.NCOST;
										this.ROTATION_DATE = i.ROTATION_DATE;
										this.UCHKZ = i.UCHKZ;
										this.UCMAT = i.UCMAT;
										this.TARGET_STOCK = i.TARGET_STOCK;
										this.StandPrice = i.StandPrice;
										this.PEINH = i.PEINH;
										this.BKLAS = i.BKLAS;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class MM_MatPlantsFactory : Common.Business.MM_MatPlants
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.MM_MatPlant
                        select MM_MatPlantFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.MM_MatPlant
                        select MM_MatPlantFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<MM_MatPlant>();
                var i = (from p in ctx.DataContext.MM_MatPlant.Where(exp)
                         select MM_MatPlantFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<MM_MatPlant>();
                var i = from p in ctx.DataContext.MM_MatPlant.Where(exp)
                         select MM_MatPlantFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
