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
	public class Sys_BusTypeCLTFactory:Common.Business.Sys_BusTypeCLT
    {
        public static Common.Business.Sys_BusTypeCLT Fetch(Sys_BusTypeCLT data)
        {
            Common.Business.Sys_BusTypeCLT item = (Common.Business.Sys_BusTypeCLT)Activator.CreateInstance(typeof(Common.Business.Sys_BusTypeCLT));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.BusType = data.BusType;
				                item.VouType = data.VouType;
				                item.CVType = data.CVType;
				                item.PVType = data.PVType;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Sys_BusTypeCLT>();
                var i = (from p in ctx.DataContext.Sys_BusTypeCLT.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.BusType = i.BusType;
										this.VouType = i.VouType;
										this.CVType = i.CVType;
										this.PVType = i.PVType;
					}
            }
        }
	}

	public class Sys_BusTypeCLTsFactory : Common.Business.Sys_BusTypeCLTs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_BusTypeCLT
                        select Sys_BusTypeCLTFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_BusTypeCLT
                        select Sys_BusTypeCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_BusTypeCLT>();
                var i = (from p in ctx.DataContext.Sys_BusTypeCLT.Where(exp)
                         select Sys_BusTypeCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_BusTypeCLT>();
                var i = from p in ctx.DataContext.Sys_BusTypeCLT.Where(exp)
                         select Sys_BusTypeCLTFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
