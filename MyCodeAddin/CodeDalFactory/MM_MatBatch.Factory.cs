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
	public class MM_MatBatchFactory:Common.Business.MM_MatBatch
    {
        public static Common.Business.MM_MatBatch Fetch(MM_MatBatch data)
        {
            Common.Business.MM_MatBatch item = (Common.Business.MM_MatBatch)Activator.CreateInstance(typeof(Common.Business.MM_MatBatch));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.MaterialCode = data.MaterialCode;
				                item.Plant = data.Plant;
				                item.BatchNo = data.BatchNo;
				                item.IsDel = data.IsDel;
				                item.ZUSCH = data.ZUSCH;
				                item.ZUSTD = data.ZUSTD;
				                item.VendorCode = data.VendorCode;
				                item.LICHA = data.LICHA;
				                item.LastInDate = data.LastInDate;
				                item.FVDT1 = data.FVDT1;
				                item.HSDAT = data.HSDAT;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<MM_MatBatch>();
                var i = (from p in ctx.DataContext.MM_MatBatch.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.MaterialCode = i.MaterialCode;
										this.Plant = i.Plant;
										this.BatchNo = i.BatchNo;
										this.IsDel = i.IsDel;
										this.ZUSCH = i.ZUSCH;
										this.ZUSTD = i.ZUSTD;
										this.VendorCode = i.VendorCode;
										this.LICHA = i.LICHA;
										this.LastInDate = i.LastInDate;
										this.FVDT1 = i.FVDT1;
										this.HSDAT = i.HSDAT;
					}
            }
        }
	}

	public class MM_MatBatchsFactory : Common.Business.MM_MatBatchs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.MM_MatBatch
                        select MM_MatBatchFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.MM_MatBatch
                        select MM_MatBatchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<MM_MatBatch>();
                var i = (from p in ctx.DataContext.MM_MatBatch.Where(exp)
                         select MM_MatBatchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<MM_MatBatch>();
                var i = from p in ctx.DataContext.MM_MatBatch.Where(exp)
                         select MM_MatBatchFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
