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
	public class Sys_ImportModeSubFactory:Common.Business.Sys_ImportModeSub
    {
        public static Common.Business.Sys_ImportModeSub Fetch(Sys_ImportModeSub data)
        {
            Common.Business.Sys_ImportModeSub item = (Common.Business.Sys_ImportModeSub)Activator.CreateInstance(typeof(Common.Business.Sys_ImportModeSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ModeCode = data.ModeCode;
				                item.Sort = data.Sort;
				                item.ItemCode = data.ItemCode;
				                item.ItemName = data.ItemName;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemId = data.ExpItemId;
				                item.ExpItemCode = data.ExpItemCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Sys_ImportModeSub>();
                var i = (from p in ctx.DataContext.Sys_ImportModeSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ModeCode = i.ModeCode;
										this.Sort = i.Sort;
										this.ItemCode = i.ItemCode;
										this.ItemName = i.ItemName;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ExpItemId = i.ExpItemId;
										this.ExpItemCode = i.ExpItemCode;
					}
            }
        }
	}

	public class Sys_ImportModeSubsFactory : Common.Business.Sys_ImportModeSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_ImportModeSub
                        select Sys_ImportModeSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_ImportModeSub
                        select Sys_ImportModeSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_ImportModeSub>();
                var i = (from p in ctx.DataContext.Sys_ImportModeSub.Where(exp)
                         select Sys_ImportModeSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_ImportModeSub>();
                var i = from p in ctx.DataContext.Sys_ImportModeSub.Where(exp)
                         select Sys_ImportModeSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
