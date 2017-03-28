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
	public class zifFactory:Common.Business.zif
    {
        public static Common.Business.zif Fetch(zif data)
        {
            Common.Business.zif item = (Common.Business.zif)Activator.CreateInstance(typeof(Common.Business.zif));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.y = data.y;
				                item.pcode = data.pcode;
				                item.tcode = data.tcode;
				                item.fcode = data.fcode;
				                item.exprow = data.exprow;
				                item.bamt = data.bamt;
				                item.camt = data.camt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<zif>();
                var i = (from p in ctx.DataContext.zif.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.y = i.y;
										this.pcode = i.pcode;
										this.tcode = i.tcode;
										this.fcode = i.fcode;
										this.exprow = i.exprow;
										this.bamt = i.bamt;
										this.camt = i.camt;
					}
            }
        }
	}

	public class zifsFactory : Common.Business.zifs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.zif
                        select zifFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.zif
                        select zifFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<zif>();
                var i = (from p in ctx.DataContext.zif.Where(exp)
                         select zifFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<zif>();
                var i = from p in ctx.DataContext.zif.Where(exp)
                         select zifFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
