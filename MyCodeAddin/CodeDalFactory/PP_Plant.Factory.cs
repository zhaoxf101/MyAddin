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
	public class PP_PlantFactory:Common.Business.PP_Plant
    {
        public static Common.Business.PP_Plant Fetch(PP_Plant data)
        {
            Common.Business.PP_Plant item = (Common.Business.PP_Plant)Activator.CreateInstance(typeof(Common.Business.PP_Plant));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Plant = data.Plant;
				                item.LText = data.LText;
				                item.Client = data.Client;
				                item.BWKEY = data.BWKEY;
				                item.FABKL = data.FABKL;
				                item.PurchaseGrp = data.PurchaseGrp;
				                item.VKORG = data.VKORG;
				                item.BEDPL = data.BEDPL;
				                item.Addr = data.Addr;
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
				var exp = lambda.Resolve<PP_Plant>();
                var i = (from p in ctx.DataContext.PP_Plant.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Plant = i.Plant;
										this.LText = i.LText;
										this.Client = i.Client;
										this.BWKEY = i.BWKEY;
										this.FABKL = i.FABKL;
										this.PurchaseGrp = i.PurchaseGrp;
										this.VKORG = i.VKORG;
										this.BEDPL = i.BEDPL;
										this.Addr = i.Addr;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PP_PlantsFactory : Common.Business.PP_Plants
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PP_Plant
                        select PP_PlantFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PP_Plant
                        select PP_PlantFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PP_Plant>();
                var i = (from p in ctx.DataContext.PP_Plant.Where(exp)
                         select PP_PlantFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PP_Plant>();
                var i = from p in ctx.DataContext.PP_Plant.Where(exp)
                         select PP_PlantFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
