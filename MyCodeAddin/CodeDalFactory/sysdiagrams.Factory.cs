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
	public class sysdiagramsFactory:Common.Business.sysdiagrams
    {
        public static Common.Business.sysdiagrams Fetch(sysdiagrams data)
        {
            Common.Business.sysdiagrams item = (Common.Business.sysdiagrams)Activator.CreateInstance(typeof(Common.Business.sysdiagrams));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.name = data.name;
				                item.principal_id = data.principal_id;
				                item.diagram_id = data.diagram_id;
				                item.version = data.version;
				                item.definition = data.definition;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<sysdiagrams>();
                var i = (from p in ctx.DataContext.sysdiagrams.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.name = i.name;
										this.principal_id = i.principal_id;
										this.diagram_id = i.diagram_id;
										this.version = i.version;
										this.definition = i.definition;
					}
            }
        }
	}

	public class sysdiagramssFactory : Common.Business.sysdiagramss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.sysdiagrams
                        select sysdiagramsFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.sysdiagrams
                        select sysdiagramsFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<sysdiagrams>();
                var i = (from p in ctx.DataContext.sysdiagrams.Where(exp)
                         select sysdiagramsFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<sysdiagrams>();
                var i = from p in ctx.DataContext.sysdiagrams.Where(exp)
                         select sysdiagramsFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
