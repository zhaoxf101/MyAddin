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
	public class UP_XiaoquFactory:Common.Business.UP_Xiaoqu
    {
        public static Common.Business.UP_Xiaoqu Fetch(UP_Xiaoqu data)
        {
            Common.Business.UP_Xiaoqu item = (Common.Business.UP_Xiaoqu)Activator.CreateInstance(typeof(Common.Business.UP_Xiaoqu));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.xiaoqu_id = data.xiaoqu_id;
				                item.xiaoqu = data.xiaoqu;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<UP_Xiaoqu>();
                var i = (from p in ctx.DataContext.UP_Xiaoqu.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.xiaoqu_id = i.xiaoqu_id;
										this.xiaoqu = i.xiaoqu;
					}
            }
        }
	}

	public class UP_XiaoqusFactory : Common.Business.UP_Xiaoqus
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_Xiaoqu
                        select UP_XiaoquFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_Xiaoqu
                        select UP_XiaoquFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_Xiaoqu>();
                var i = (from p in ctx.DataContext.UP_Xiaoqu.Where(exp)
                         select UP_XiaoquFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_Xiaoqu>();
                var i = from p in ctx.DataContext.UP_Xiaoqu.Where(exp)
                         select UP_XiaoquFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
