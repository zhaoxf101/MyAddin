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
	public class AM_AccClsFactory:Common.Business.AM_AccCls
    {
        public static Common.Business.AM_AccCls Fetch(AM_AccCls data)
        {
            Common.Business.AM_AccCls item = (Common.Business.AM_AccCls)Activator.CreateInstance(typeof(Common.Business.AM_AccCls));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AccCls = data.AccCls;
				                item.DText = data.DText;
				                item.AccGroup = data.AccGroup;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<AM_AccCls>();
                var i = (from p in ctx.DataContext.AM_AccCls.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AccCls = i.AccCls;
										this.DText = i.DText;
										this.AccGroup = i.AccGroup;
					}
            }
        }
	}

	public class AM_AccClssFactory : Common.Business.AM_AccClss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.AM_AccCls
                        select AM_AccClsFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.AM_AccCls
                        select AM_AccClsFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<AM_AccCls>();
                var i = (from p in ctx.DataContext.AM_AccCls.Where(exp)
                         select AM_AccClsFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<AM_AccCls>();
                var i = from p in ctx.DataContext.AM_AccCls.Where(exp)
                         select AM_AccClsFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
