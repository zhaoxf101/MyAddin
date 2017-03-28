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
	public class Sys_StaVerFactory:Common.Business.Sys_StaVer
    {
        public static Common.Business.Sys_StaVer Fetch(Sys_StaVer data)
        {
            Common.Business.Sys_StaVer item = (Common.Business.Sys_StaVer)Activator.CreateInstance(typeof(Common.Business.Sys_StaVer));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TableName = data.TableName;
				                item.VerId = data.VerId;
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
				var exp = lambda.Resolve<Sys_StaVer>();
                var i = (from p in ctx.DataContext.Sys_StaVer.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TableName = i.TableName;
										this.VerId = i.VerId;
										this.ParentId = i.ParentId;
										this.ChildId = i.ChildId;
										this.Sort = i.Sort;
					}
            }
        }
	}

	public class Sys_StaVersFactory : Common.Business.Sys_StaVers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_StaVer
                        select Sys_StaVerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_StaVer
                        select Sys_StaVerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_StaVer>();
                var i = (from p in ctx.DataContext.Sys_StaVer.Where(exp)
                         select Sys_StaVerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_StaVer>();
                var i = from p in ctx.DataContext.Sys_StaVer.Where(exp)
                         select Sys_StaVerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
