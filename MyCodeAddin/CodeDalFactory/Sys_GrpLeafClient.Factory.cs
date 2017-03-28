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
	public class Sys_GrpLeafClientFactory:Common.Business.Sys_GrpLeafClient
    {
        public static Common.Business.Sys_GrpLeafClient Fetch(Sys_GrpLeafClient data)
        {
            Common.Business.Sys_GrpLeafClient item = (Common.Business.Sys_GrpLeafClient)Activator.CreateInstance(typeof(Common.Business.Sys_GrpLeafClient));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.GrpClass = data.GrpClass;
				                item.GrpName = data.GrpName;
				                item.LineId = data.LineId;
				                item.LeafValue = data.LeafValue;
				                item.Sort = data.Sort;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Sys_GrpLeafClient>();
                var i = (from p in ctx.DataContext.Sys_GrpLeafClient.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.GrpClass = i.GrpClass;
										this.GrpName = i.GrpName;
										this.LineId = i.LineId;
										this.LeafValue = i.LeafValue;
										this.Sort = i.Sort;
					}
            }
        }
	}

	public class Sys_GrpLeafClientsFactory : Common.Business.Sys_GrpLeafClients
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_GrpLeafClient
                        select Sys_GrpLeafClientFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_GrpLeafClient
                        select Sys_GrpLeafClientFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_GrpLeafClient>();
                var i = (from p in ctx.DataContext.Sys_GrpLeafClient.Where(exp)
                         select Sys_GrpLeafClientFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_GrpLeafClient>();
                var i = from p in ctx.DataContext.Sys_GrpLeafClient.Where(exp)
                         select Sys_GrpLeafClientFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
