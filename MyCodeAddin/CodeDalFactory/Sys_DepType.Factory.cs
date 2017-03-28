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
	public class Sys_DepTypeFactory:Common.Business.Sys_DepType
    {
        public static Common.Business.Sys_DepType Fetch(Sys_DepType data)
        {
            Common.Business.Sys_DepType item = (Common.Business.Sys_DepType)Activator.CreateInstance(typeof(Common.Business.Sys_DepType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.DepTypeCode = data.DepTypeCode;
				                item.DepTypeName = data.DepTypeName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Sys_DepType>();
                var i = (from p in ctx.DataContext.Sys_DepType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.DepTypeCode = i.DepTypeCode;
										this.DepTypeName = i.DepTypeName;
					}
            }
        }
	}

	public class Sys_DepTypesFactory : Common.Business.Sys_DepTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_DepType
                        select Sys_DepTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_DepType
                        select Sys_DepTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_DepType>();
                var i = (from p in ctx.DataContext.Sys_DepType.Where(exp)
                         select Sys_DepTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_DepType>();
                var i = from p in ctx.DataContext.Sys_DepType.Where(exp)
                         select Sys_DepTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
