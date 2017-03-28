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
	public class EF_ViewsFactory:Common.Business.EF_Views
    {
        public static Common.Business.EF_Views Fetch(EF_Views data)
        {
            Common.Business.EF_Views item = (Common.Business.EF_Views)Activator.CreateInstance(typeof(Common.Business.EF_Views));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ViewName = data.ViewName;
				                item.TableName = data.TableName;
				                item.RowStatus = data.RowStatus;
				                item.Position = data.Position;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_Views>();
                var i = (from p in ctx.DataContext.EF_Views.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ViewName = i.ViewName;
										this.TableName = i.TableName;
										this.RowStatus = i.RowStatus;
										this.Position = i.Position;
					}
            }
        }
	}

	public class EF_ViewssFactory : Common.Business.EF_Viewss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_Views
                        select EF_ViewsFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_Views
                        select EF_ViewsFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_Views>();
                var i = (from p in ctx.DataContext.EF_Views.Where(exp)
                         select EF_ViewsFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_Views>();
                var i = from p in ctx.DataContext.EF_Views.Where(exp)
                         select EF_ViewsFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
