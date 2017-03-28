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
	public class zz2Factory:Common.Business.zz2
    {
        public static Common.Business.zz2 Fetch(zz2 data)
        {
            Common.Business.zz2 item = (Common.Business.zz2)Activator.CreateInstance(typeof(Common.Business.zz2));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.FundCode = data.FundCode;
				                item.PBudExpFunCode = data.PBudExpFunCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<zz2>();
                var i = (from p in ctx.DataContext.zz2.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.FundCode = i.FundCode;
										this.PBudExpFunCode = i.PBudExpFunCode;
					}
            }
        }
	}

	public class zz2sFactory : Common.Business.zz2s
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.zz2
                        select zz2Factory.Fetch(p);
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
                var i = (from p in ctx.DataContext.zz2
                        select zz2Factory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<zz2>();
                var i = (from p in ctx.DataContext.zz2.Where(exp)
                         select zz2Factory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<zz2>();
                var i = from p in ctx.DataContext.zz2.Where(exp)
                         select zz2Factory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
