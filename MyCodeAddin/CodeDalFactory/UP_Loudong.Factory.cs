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
	public class UP_LoudongFactory:Common.Business.UP_Loudong
    {
        public static Common.Business.UP_Loudong Fetch(UP_Loudong data)
        {
            Common.Business.UP_Loudong item = (Common.Business.UP_Loudong)Activator.CreateInstance(typeof(Common.Business.UP_Loudong));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.xiaoqu_id = data.xiaoqu_id;
				                item.loudong_id = data.loudong_id;
				                item.loudong = data.loudong;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<UP_Loudong>();
                var i = (from p in ctx.DataContext.UP_Loudong.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.xiaoqu_id = i.xiaoqu_id;
										this.loudong_id = i.loudong_id;
										this.loudong = i.loudong;
					}
            }
        }
	}

	public class UP_LoudongsFactory : Common.Business.UP_Loudongs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_Loudong
                        select UP_LoudongFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_Loudong
                        select UP_LoudongFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_Loudong>();
                var i = (from p in ctx.DataContext.UP_Loudong.Where(exp)
                         select UP_LoudongFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_Loudong>();
                var i = from p in ctx.DataContext.UP_Loudong.Where(exp)
                         select UP_LoudongFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
