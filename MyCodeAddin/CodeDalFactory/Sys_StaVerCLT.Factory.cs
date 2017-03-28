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
	public class Sys_StaVerCLTFactory:Common.Business.Sys_StaVerCLT
    {
        public static Common.Business.Sys_StaVerCLT Fetch(Sys_StaVerCLT data)
        {
            Common.Business.Sys_StaVerCLT item = (Common.Business.Sys_StaVerCLT)Activator.CreateInstance(typeof(Common.Business.Sys_StaVerCLT));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
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
				var exp = lambda.Resolve<Sys_StaVerCLT>();
                var i = (from p in ctx.DataContext.Sys_StaVerCLT.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TableName = i.TableName;
										this.VerId = i.VerId;
										this.ParentId = i.ParentId;
										this.ChildId = i.ChildId;
										this.Sort = i.Sort;
					}
            }
        }
	}

	public class Sys_StaVerCLTsFactory : Common.Business.Sys_StaVerCLTs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_StaVerCLT
                        select Sys_StaVerCLTFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_StaVerCLT
                        select Sys_StaVerCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_StaVerCLT>();
                var i = (from p in ctx.DataContext.Sys_StaVerCLT.Where(exp)
                         select Sys_StaVerCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_StaVerCLT>();
                var i = from p in ctx.DataContext.Sys_StaVerCLT.Where(exp)
                         select Sys_StaVerCLTFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
