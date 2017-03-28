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
	public class Sys_ParaCLTFactory:Common.Business.Sys_ParaCLT
    {
        public static Common.Business.Sys_ParaCLT Fetch(Sys_ParaCLT data)
        {
            Common.Business.Sys_ParaCLT item = (Common.Business.Sys_ParaCLT)Activator.CreateInstance(typeof(Common.Business.Sys_ParaCLT));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
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
				var exp = lambda.Resolve<Sys_ParaCLT>();
                var i = (from p in ctx.DataContext.Sys_ParaCLT.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ParaName = i.ParaName;
										this.ParaValue = i.ParaValue;
										this.ParaExplain = i.ParaExplain;
										this.SubSystem = i.SubSystem;
					}
            }
        }
	}

	public class Sys_ParaCLTsFactory : Common.Business.Sys_ParaCLTs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_ParaCLT
                        select Sys_ParaCLTFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_ParaCLT
                        select Sys_ParaCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_ParaCLT>();
                var i = (from p in ctx.DataContext.Sys_ParaCLT.Where(exp)
                         select Sys_ParaCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_ParaCLT>();
                var i = from p in ctx.DataContext.Sys_ParaCLT.Where(exp)
                         select Sys_ParaCLTFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
