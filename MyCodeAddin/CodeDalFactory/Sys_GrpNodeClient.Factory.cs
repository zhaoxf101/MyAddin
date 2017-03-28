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
	public class Sys_GrpNodeClientFactory:Common.Business.Sys_GrpNodeClient
    {
        public static Common.Business.Sys_GrpNodeClient Fetch(Sys_GrpNodeClient data)
        {
            Common.Business.Sys_GrpNodeClient item = (Common.Business.Sys_GrpNodeClient)Activator.CreateInstance(typeof(Common.Business.Sys_GrpNodeClient));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.GrpClass = data.GrpClass;
				                item.GrpName = data.GrpName;
				                item.LineId = data.LineId;
				                item.SubGrp = data.SubGrp;
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
				var exp = lambda.Resolve<Sys_GrpNodeClient>();
                var i = (from p in ctx.DataContext.Sys_GrpNodeClient.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.GrpClass = i.GrpClass;
										this.GrpName = i.GrpName;
										this.LineId = i.LineId;
										this.SubGrp = i.SubGrp;
										this.Sort = i.Sort;
					}
            }
        }
	}

	public class Sys_GrpNodeClientsFactory : Common.Business.Sys_GrpNodeClients
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_GrpNodeClient
                        select Sys_GrpNodeClientFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_GrpNodeClient
                        select Sys_GrpNodeClientFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_GrpNodeClient>();
                var i = (from p in ctx.DataContext.Sys_GrpNodeClient.Where(exp)
                         select Sys_GrpNodeClientFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_GrpNodeClient>();
                var i = from p in ctx.DataContext.Sys_GrpNodeClient.Where(exp)
                         select Sys_GrpNodeClientFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
