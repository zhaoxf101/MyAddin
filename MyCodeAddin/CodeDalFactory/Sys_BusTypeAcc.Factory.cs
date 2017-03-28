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
	public class Sys_BusTypeAccFactory:Common.Business.Sys_BusTypeAcc
    {
        public static Common.Business.Sys_BusTypeAcc Fetch(Sys_BusTypeAcc data)
        {
            Common.Business.Sys_BusTypeAcc item = (Common.Business.Sys_BusTypeAcc)Activator.CreateInstance(typeof(Common.Business.Sys_BusTypeAcc));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.BusType = data.BusType;
				                item.AccCls = data.AccCls;
				                item.EntryKey = data.EntryKey;
				                item.AccType = data.AccType;
				                item.PostKey = data.PostKey;
				                item.GLMark = data.GLMark;
				                item.AccCode = data.AccCode;
				                item.BAccCode = data.BAccCode;
				                item.DText = data.DText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Sys_BusTypeAcc>();
                var i = (from p in ctx.DataContext.Sys_BusTypeAcc.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.BusType = i.BusType;
										this.AccCls = i.AccCls;
										this.EntryKey = i.EntryKey;
										this.AccType = i.AccType;
										this.PostKey = i.PostKey;
										this.GLMark = i.GLMark;
										this.AccCode = i.AccCode;
										this.BAccCode = i.BAccCode;
										this.DText = i.DText;
					}
            }
        }
	}

	public class Sys_BusTypeAccsFactory : Common.Business.Sys_BusTypeAccs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_BusTypeAcc
                        select Sys_BusTypeAccFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_BusTypeAcc
                        select Sys_BusTypeAccFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_BusTypeAcc>();
                var i = (from p in ctx.DataContext.Sys_BusTypeAcc.Where(exp)
                         select Sys_BusTypeAccFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_BusTypeAcc>();
                var i = from p in ctx.DataContext.Sys_BusTypeAcc.Where(exp)
                         select Sys_BusTypeAccFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
