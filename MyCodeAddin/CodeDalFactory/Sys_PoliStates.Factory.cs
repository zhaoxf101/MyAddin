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
	public class Sys_PoliStatesFactory:Common.Business.Sys_PoliStates
    {
        public static Common.Business.Sys_PoliStates Fetch(Sys_PoliStates data)
        {
            Common.Business.Sys_PoliStates item = (Common.Business.Sys_PoliStates)Activator.CreateInstance(typeof(Common.Business.Sys_PoliStates));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PoliStatesCode = data.PoliStatesCode;
				                item.PoliStatesName = data.PoliStatesName;
				                item.LText = data.LText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Sys_PoliStates>();
                var i = (from p in ctx.DataContext.Sys_PoliStates.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PoliStatesCode = i.PoliStatesCode;
										this.PoliStatesName = i.PoliStatesName;
										this.LText = i.LText;
					}
            }
        }
	}

	public class Sys_PoliStatessFactory : Common.Business.Sys_PoliStatess
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_PoliStates
                        select Sys_PoliStatesFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_PoliStates
                        select Sys_PoliStatesFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_PoliStates>();
                var i = (from p in ctx.DataContext.Sys_PoliStates.Where(exp)
                         select Sys_PoliStatesFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_PoliStates>();
                var i = from p in ctx.DataContext.Sys_PoliStates.Where(exp)
                         select Sys_PoliStatesFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
