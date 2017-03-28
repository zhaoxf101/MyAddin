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
	public class MM_MatBatchStockFactory:Common.Business.MM_MatBatchStock
    {
        public static Common.Business.MM_MatBatchStock Fetch(MM_MatBatchStock data)
        {
            Common.Business.MM_MatBatchStock item = (Common.Business.MM_MatBatchStock)Activator.CreateInstance(typeof(Common.Business.MM_MatBatchStock));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.MaterialCode = data.MaterialCode;
				                item.Plant = data.Plant;
				                item.BatchNo = data.BatchNo;
				                item.Warehouse = data.Warehouse;
				                item.IsDel = data.IsDel;
				                item.CurAccYear = data.CurAccYear;
				                item.CurAccMon = data.CurAccMon;
				                item.CLABS = data.CLABS;
				                item.CUMLM = data.CUMLM;
				                item.CINSM = data.CINSM;
				                item.CEINM = data.CEINM;
				                item.CSPEM = data.CSPEM;
				                item.CRETM = data.CRETM;
				                item.CVMLA = data.CVMLA;
				                item.CVMUM = data.CVMUM;
				                item.CVMIN = data.CVMIN;
				                item.CVMEI = data.CVMEI;
				                item.CVMSP = data.CVMSP;
				                item.CVMRE = data.CVMRE;
				                item.KZICL = data.KZICL;
				                item.KZICQ = data.KZICQ;
				                item.KZICE = data.KZICE;
				                item.KZICS = data.KZICS;
				                item.KZVCL = data.KZVCL;
				                item.KZVCQ = data.KZVCQ;
				                item.KZVCE = data.KZVCE;
				                item.KZVCS = data.KZVCS;
				                item.HERKL = data.HERKL;
				                item.CHDLL = data.CHDLL;
				                item.CHJIN = data.CHJIN;
				                item.CHRUE = data.CHRUE;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<MM_MatBatchStock>();
                var i = (from p in ctx.DataContext.MM_MatBatchStock.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.MaterialCode = i.MaterialCode;
										this.Plant = i.Plant;
										this.BatchNo = i.BatchNo;
										this.Warehouse = i.Warehouse;
										this.IsDel = i.IsDel;
										this.CurAccYear = i.CurAccYear;
										this.CurAccMon = i.CurAccMon;
										this.CLABS = i.CLABS;
										this.CUMLM = i.CUMLM;
										this.CINSM = i.CINSM;
										this.CEINM = i.CEINM;
										this.CSPEM = i.CSPEM;
										this.CRETM = i.CRETM;
										this.CVMLA = i.CVMLA;
										this.CVMUM = i.CVMUM;
										this.CVMIN = i.CVMIN;
										this.CVMEI = i.CVMEI;
										this.CVMSP = i.CVMSP;
										this.CVMRE = i.CVMRE;
										this.KZICL = i.KZICL;
										this.KZICQ = i.KZICQ;
										this.KZICE = i.KZICE;
										this.KZICS = i.KZICS;
										this.KZVCL = i.KZVCL;
										this.KZVCQ = i.KZVCQ;
										this.KZVCE = i.KZVCE;
										this.KZVCS = i.KZVCS;
										this.HERKL = i.HERKL;
										this.CHDLL = i.CHDLL;
										this.CHJIN = i.CHJIN;
										this.CHRUE = i.CHRUE;
					}
            }
        }
	}

	public class MM_MatBatchStocksFactory : Common.Business.MM_MatBatchStocks
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.MM_MatBatchStock
                        select MM_MatBatchStockFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.MM_MatBatchStock
                        select MM_MatBatchStockFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<MM_MatBatchStock>();
                var i = (from p in ctx.DataContext.MM_MatBatchStock.Where(exp)
                         select MM_MatBatchStockFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<MM_MatBatchStock>();
                var i = from p in ctx.DataContext.MM_MatBatchStock.Where(exp)
                         select MM_MatBatchStockFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
