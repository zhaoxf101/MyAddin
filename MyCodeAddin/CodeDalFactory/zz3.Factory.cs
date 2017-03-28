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
	public class zz3Factory:Common.Business.zz3
    {
        public static Common.Business.zz3 Fetch(zz3 data)
        {
            Common.Business.zz3 item = (Common.Business.zz3)Activator.CreateInstance(typeof(Common.Business.zz3));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.pcode = data.pcode;
				                item.tcode = data.tcode;
				                item.ecode = data.ecode;
				                item.h = data.h;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<zz3>();
                var i = (from p in ctx.DataContext.zz3.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.pcode = i.pcode;
										this.tcode = i.tcode;
										this.ecode = i.ecode;
										this.h = i.h;
					}
            }
        }
	}

	public class zz3sFactory : Common.Business.zz3s
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.zz3
                        select zz3Factory.Fetch(p);
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
                var i = (from p in ctx.DataContext.zz3
                        select zz3Factory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<zz3>();
                var i = (from p in ctx.DataContext.zz3.Where(exp)
                         select zz3Factory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<zz3>();
                var i = from p in ctx.DataContext.zz3.Where(exp)
                         select zz3Factory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
