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
	public class MM_MatVouchFactory:Common.Business.MM_MatVouch
    {
        public static Common.Business.MM_MatVouch Fetch(MM_MatVouch data)
        {
            Common.Business.MM_MatVouch item = (Common.Business.MM_MatVouch)Activator.CreateInstance(typeof(Common.Business.MM_MatVouch));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.MatVouchNo = data.MatVouchNo;
				                item.AccYear = data.AccYear;
				                item.VGART = data.VGART;
				                item.VoucherType = data.VoucherType;
				                item.BLAUM = data.BLAUM;
				                item.BLDAT = data.BLDAT;
				                item.BUDAT = data.BUDAT;
				                item.CPUDT = data.CPUDT;
				                item.XBLNR = data.XBLNR;
				                item.BKTXT = data.BKTXT;
				                item.XABLN = data.XABLN;
				                item.KNUMV = data.KNUMV;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<MM_MatVouch>();
                var i = (from p in ctx.DataContext.MM_MatVouch.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.MatVouchNo = i.MatVouchNo;
										this.AccYear = i.AccYear;
										this.VGART = i.VGART;
										this.VoucherType = i.VoucherType;
										this.BLAUM = i.BLAUM;
										this.BLDAT = i.BLDAT;
										this.BUDAT = i.BUDAT;
										this.CPUDT = i.CPUDT;
										this.XBLNR = i.XBLNR;
										this.BKTXT = i.BKTXT;
										this.XABLN = i.XABLN;
										this.KNUMV = i.KNUMV;
					}
            }
        }
	}

	public class MM_MatVouchsFactory : Common.Business.MM_MatVouchs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.MM_MatVouch
                        select MM_MatVouchFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.MM_MatVouch
                        select MM_MatVouchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<MM_MatVouch>();
                var i = (from p in ctx.DataContext.MM_MatVouch.Where(exp)
                         select MM_MatVouchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<MM_MatVouch>();
                var i = from p in ctx.DataContext.MM_MatVouch.Where(exp)
                         select MM_MatVouchFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
