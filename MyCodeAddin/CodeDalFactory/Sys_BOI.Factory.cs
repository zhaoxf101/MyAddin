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
	public class Sys_BOIFactory:Common.Business.Sys_BOI
    {
        public static Common.Business.Sys_BOI Fetch(Sys_BOI data)
        {
            Common.Business.Sys_BOI item = (Common.Business.Sys_BOI)Activator.CreateInstance(typeof(Common.Business.Sys_BOI));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TableName = data.TableName;
				                item.ParentId = data.ParentId;
				                item.ChildId = data.ChildId;
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
				var exp = lambda.Resolve<Sys_BOI>();
                var i = (from p in ctx.DataContext.Sys_BOI.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TableName = i.TableName;
										this.ParentId = i.ParentId;
										this.ChildId = i.ChildId;
										this.Sort = i.Sort;
					}
            }
        }
	}

	public class Sys_BOIsFactory : Common.Business.Sys_BOIs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_BOI
                        select Sys_BOIFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_BOI
                        select Sys_BOIFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_BOI>();
                var i = (from p in ctx.DataContext.Sys_BOI.Where(exp)
                         select Sys_BOIFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_BOI>();
                var i = from p in ctx.DataContext.Sys_BOI.Where(exp)
                         select Sys_BOIFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
