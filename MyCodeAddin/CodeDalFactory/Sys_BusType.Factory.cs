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
	public class Sys_BusTypeFactory:Common.Business.Sys_BusType
    {
        public static Common.Business.Sys_BusType Fetch(Sys_BusType data)
        {
            Common.Business.Sys_BusType item = (Common.Business.Sys_BusType)Activator.CreateInstance(typeof(Common.Business.Sys_BusType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.BusType = data.BusType;
				                item.DText = data.DText;
				                item.BusObjectName = data.BusObjectName;
				                item.ConfirmProcedure = data.ConfirmProcedure;
				                item.UndoProcedure = data.UndoProcedure;
				                item.PostProcedure = data.PostProcedure;
				                item.OffsetProcedure = data.OffsetProcedure;
				                item.WinAppName = data.WinAppName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Sys_BusType>();
                var i = (from p in ctx.DataContext.Sys_BusType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.BusType = i.BusType;
										this.DText = i.DText;
										this.BusObjectName = i.BusObjectName;
										this.ConfirmProcedure = i.ConfirmProcedure;
										this.UndoProcedure = i.UndoProcedure;
										this.PostProcedure = i.PostProcedure;
										this.OffsetProcedure = i.OffsetProcedure;
										this.WinAppName = i.WinAppName;
					}
            }
        }
	}

	public class Sys_BusTypesFactory : Common.Business.Sys_BusTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_BusType
                        select Sys_BusTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_BusType
                        select Sys_BusTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_BusType>();
                var i = (from p in ctx.DataContext.Sys_BusType.Where(exp)
                         select Sys_BusTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_BusType>();
                var i = from p in ctx.DataContext.Sys_BusType.Where(exp)
                         select Sys_BusTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
