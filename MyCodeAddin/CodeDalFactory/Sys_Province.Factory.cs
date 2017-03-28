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
	public class Sys_ProvinceFactory:Common.Business.Sys_Province
    {
        public static Common.Business.Sys_Province Fetch(Sys_Province data)
        {
            Common.Business.Sys_Province item = (Common.Business.Sys_Province)Activator.CreateInstance(typeof(Common.Business.Sys_Province));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ProvinceCode = data.ProvinceCode;
				                item.ProvinceName = data.ProvinceName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Sys_Province>();
                var i = (from p in ctx.DataContext.Sys_Province.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ProvinceCode = i.ProvinceCode;
										this.ProvinceName = i.ProvinceName;
					}
            }
        }
	}

	public class Sys_ProvincesFactory : Common.Business.Sys_Provinces
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_Province
                        select Sys_ProvinceFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_Province
                        select Sys_ProvinceFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_Province>();
                var i = (from p in ctx.DataContext.Sys_Province.Where(exp)
                         select Sys_ProvinceFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_Province>();
                var i = from p in ctx.DataContext.Sys_Province.Where(exp)
                         select Sys_ProvinceFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
