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
	public class MM_MatStockFactory:Common.Business.MM_MatStock
    {
        public static Common.Business.MM_MatStock Fetch(MM_MatStock data)
        {
            Common.Business.MM_MatStock item = (Common.Business.MM_MatStock)Activator.CreateInstance(typeof(Common.Business.MM_MatStock));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.MaterialCode = data.MaterialCode;
				                item.Plant = data.Plant;
				                item.Warehouse = data.Warehouse;
				                item.IsDel = data.IsDel;
				                item.CurAccYear = data.CurAccYear;
				                item.CurAccMon = data.CurAccMon;
				                item.LABST = data.LABST;
				                item.UMLME = data.UMLME;
				                item.INSME = data.INSME;
				                item.EINME = data.EINME;
				                item.SPEME = data.SPEME;
				                item.RETME = data.RETME;
				                item.VMLAB = data.VMLAB;
				                item.VMUML = data.VMUML;
				                item.VMINS = data.VMINS;
				                item.VMEIN = data.VMEIN;
				                item.VMSPE = data.VMSPE;
				                item.VMRET = data.VMRET;
				                item.KZICL = data.KZICL;
				                item.KZICQ = data.KZICQ;
				                item.KZICE = data.KZICE;
				                item.KZICS = data.KZICS;
				                item.KZVCL = data.KZVCL;
				                item.KZVCQ = data.KZVCQ;
				                item.KZVCE = data.KZVCE;
				                item.KZVCS = data.KZVCS;
				                item.CanMRP = data.CanMRP;
				                item.LSOBS = data.LSOBS;
				                item.LMINB = data.LMINB;
				                item.LBSTF = data.LBSTF;
				                item.EXPPG = data.EXPPG;
				                item.EXVER = data.EXVER;
				                item.Stock = data.Stock;
				                item.KLABS = data.KLABS;
				                item.KINSM = data.KINSM;
				                item.KEINM = data.KEINM;
				                item.KSPEM = data.KSPEM;
				                item.DLINL = data.DLINL;
				                item.PriftCtr = data.PriftCtr;
				                item.ERSDA = data.ERSDA;
				                item.VKLAB = data.VKLAB;
				                item.VKUML = data.VKUML;
				                item.BSKRF = data.BSKRF;
				                item.MDRUE = data.MDRUE;
				                item.CurFinYear = data.CurFinYear;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<MM_MatStock>();
                var i = (from p in ctx.DataContext.MM_MatStock.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.MaterialCode = i.MaterialCode;
										this.Plant = i.Plant;
										this.Warehouse = i.Warehouse;
										this.IsDel = i.IsDel;
										this.CurAccYear = i.CurAccYear;
										this.CurAccMon = i.CurAccMon;
										this.LABST = i.LABST;
										this.UMLME = i.UMLME;
										this.INSME = i.INSME;
										this.EINME = i.EINME;
										this.SPEME = i.SPEME;
										this.RETME = i.RETME;
										this.VMLAB = i.VMLAB;
										this.VMUML = i.VMUML;
										this.VMINS = i.VMINS;
										this.VMEIN = i.VMEIN;
										this.VMSPE = i.VMSPE;
										this.VMRET = i.VMRET;
										this.KZICL = i.KZICL;
										this.KZICQ = i.KZICQ;
										this.KZICE = i.KZICE;
										this.KZICS = i.KZICS;
										this.KZVCL = i.KZVCL;
										this.KZVCQ = i.KZVCQ;
										this.KZVCE = i.KZVCE;
										this.KZVCS = i.KZVCS;
										this.CanMRP = i.CanMRP;
										this.LSOBS = i.LSOBS;
										this.LMINB = i.LMINB;
										this.LBSTF = i.LBSTF;
										this.EXPPG = i.EXPPG;
										this.EXVER = i.EXVER;
										this.Stock = i.Stock;
										this.KLABS = i.KLABS;
										this.KINSM = i.KINSM;
										this.KEINM = i.KEINM;
										this.KSPEM = i.KSPEM;
										this.DLINL = i.DLINL;
										this.PriftCtr = i.PriftCtr;
										this.ERSDA = i.ERSDA;
										this.VKLAB = i.VKLAB;
										this.VKUML = i.VKUML;
										this.BSKRF = i.BSKRF;
										this.MDRUE = i.MDRUE;
										this.CurFinYear = i.CurFinYear;
					}
            }
        }
	}

	public class MM_MatStocksFactory : Common.Business.MM_MatStocks
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.MM_MatStock
                        select MM_MatStockFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.MM_MatStock
                        select MM_MatStockFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<MM_MatStock>();
                var i = (from p in ctx.DataContext.MM_MatStock.Where(exp)
                         select MM_MatStockFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<MM_MatStock>();
                var i = from p in ctx.DataContext.MM_MatStock.Where(exp)
                         select MM_MatStockFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
