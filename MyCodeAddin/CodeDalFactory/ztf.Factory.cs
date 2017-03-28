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
	public class ztfFactory:Common.Business.ztf
    {
        public static Common.Business.ztf Fetch(ztf data)
        {
            Common.Business.ztf item = (Common.Business.ztf)Activator.CreateInstance(typeof(Common.Business.ztf));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.y = data.y;
				                item.pcode = data.pcode;
				                item.tcode = data.tcode;
				                item.fcode = data.fcode;
				                item.bamt = data.bamt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<ztf>();
                var i = (from p in ctx.DataContext.ztf.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.y = i.y;
										this.pcode = i.pcode;
										this.tcode = i.tcode;
										this.fcode = i.fcode;
										this.bamt = i.bamt;
					}
            }
        }
	}

	public class ztfsFactory : Common.Business.ztfs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.ztf
                        select ztfFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.ztf
                        select ztfFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<ztf>();
                var i = (from p in ctx.DataContext.ztf.Where(exp)
                         select ztfFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<ztf>();
                var i = from p in ctx.DataContext.ztf.Where(exp)
                         select ztfFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
