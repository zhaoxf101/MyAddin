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
	public class Sys_ParaFactory:Common.Business.Sys_Para
    {
        public static Common.Business.Sys_Para Fetch(Sys_Para data)
        {
            Common.Business.Sys_Para item = (Common.Business.Sys_Para)Activator.CreateInstance(typeof(Common.Business.Sys_Para));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ParaName = data.ParaName;
				                item.ParaValue = data.ParaValue;
				                item.ParaExplain = data.ParaExplain;
				                item.SubSystem = data.SubSystem;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Sys_Para>();
                var i = (from p in ctx.DataContext.Sys_Para.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ParaName = i.ParaName;
										this.ParaValue = i.ParaValue;
										this.ParaExplain = i.ParaExplain;
										this.SubSystem = i.SubSystem;
					}
            }
        }
	}

	public class Sys_ParasFactory : Common.Business.Sys_Paras
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_Para
                        select Sys_ParaFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_Para
                        select Sys_ParaFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_Para>();
                var i = (from p in ctx.DataContext.Sys_Para.Where(exp)
                         select Sys_ParaFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_Para>();
                var i = from p in ctx.DataContext.Sys_Para.Where(exp)
                         select Sys_ParaFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
