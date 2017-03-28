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
	public class Sys_AreaFactory:Common.Business.Sys_Area
    {
        public static Common.Business.Sys_Area Fetch(Sys_Area data)
        {
            Common.Business.Sys_Area item = (Common.Business.Sys_Area)Activator.CreateInstance(typeof(Common.Business.Sys_Area));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.AreaId = data.AreaId;
				                item.AreaCode = data.AreaCode;
				                item.AreaName = data.AreaName;
				                item.ProvinceCode = data.ProvinceCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Sys_Area>();
                var i = (from p in ctx.DataContext.Sys_Area.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.AreaId = i.AreaId;
										this.AreaCode = i.AreaCode;
										this.AreaName = i.AreaName;
										this.ProvinceCode = i.ProvinceCode;
					}
            }
        }
	}

	public class Sys_AreasFactory : Common.Business.Sys_Areas
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_Area
                        select Sys_AreaFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_Area
                        select Sys_AreaFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_Area>();
                var i = (from p in ctx.DataContext.Sys_Area.Where(exp)
                         select Sys_AreaFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_Area>();
                var i = from p in ctx.DataContext.Sys_Area.Where(exp)
                         select Sys_AreaFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
