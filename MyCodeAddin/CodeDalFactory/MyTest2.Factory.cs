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
	public class MyTest2Factory:Common.Business.MyTest2
    {
        public static Common.Business.MyTest2 Fetch(MyTest2 data)
        {
            Common.Business.MyTest2 item = (Common.Business.MyTest2)Activator.CreateInstance(typeof(Common.Business.MyTest2));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.myKey = data.myKey;
				                item.myValue = data.myValue;
				                item.TS = data.TS;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<MyTest2>();
                var i = (from p in ctx.DataContext.MyTest2.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.myKey = i.myKey;
										this.myValue = i.myValue;
										this.TS = i.TS;
					}
            }
        }
	}

	public class MyTest2sFactory : Common.Business.MyTest2s
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.MyTest2
                        select MyTest2Factory.Fetch(p);
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
                var i = (from p in ctx.DataContext.MyTest2
                        select MyTest2Factory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<MyTest2>();
                var i = (from p in ctx.DataContext.MyTest2.Where(exp)
                         select MyTest2Factory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<MyTest2>();
                var i = from p in ctx.DataContext.MyTest2.Where(exp)
                         select MyTest2Factory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
