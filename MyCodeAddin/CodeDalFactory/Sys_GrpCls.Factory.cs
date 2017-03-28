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
	public class Sys_GrpClsFactory:Common.Business.Sys_GrpCls
    {
        public static Common.Business.Sys_GrpCls Fetch(Sys_GrpCls data)
        {
            Common.Business.Sys_GrpCls item = (Common.Business.Sys_GrpCls)Activator.CreateInstance(typeof(Common.Business.Sys_GrpCls));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.GrpCls = data.GrpCls;
				                item.DTEXT = data.DTEXT;
				                item.CrossClient = data.CrossClient;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Sys_GrpCls>();
                var i = (from p in ctx.DataContext.Sys_GrpCls.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.GrpCls = i.GrpCls;
										this.DTEXT = i.DTEXT;
										this.CrossClient = i.CrossClient;
					}
            }
        }
	}

	public class Sys_GrpClssFactory : Common.Business.Sys_GrpClss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_GrpCls
                        select Sys_GrpClsFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_GrpCls
                        select Sys_GrpClsFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_GrpCls>();
                var i = (from p in ctx.DataContext.Sys_GrpCls.Where(exp)
                         select Sys_GrpClsFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_GrpCls>();
                var i = from p in ctx.DataContext.Sys_GrpCls.Where(exp)
                         select Sys_GrpClsFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
