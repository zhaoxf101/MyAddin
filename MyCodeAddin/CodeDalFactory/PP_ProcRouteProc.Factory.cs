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
	public class PP_ProcRouteProcFactory:Common.Business.PP_ProcRouteProc
    {
        public static Common.Business.PP_ProcRouteProc Fetch(PP_ProcRouteProc data)
        {
            Common.Business.PP_ProcRouteProc item = (Common.Business.PP_ProcRouteProc)Activator.CreateInstance(typeof(Common.Business.PP_ProcRouteProc));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PLNNR = data.PLNNR;
				                item.PLNAL = data.PLNAL;
				                item.PLNKN = data.PLNKN;
				                item.UseDate = data.UseDate;
				                item.IsDel = data.IsDel;
				                item.PARKZ = data.PARKZ;
				                item.VORNR = data.VORNR;
				                item.WorkCtr = data.WorkCtr;
				                item.Plant = data.Plant;
				                item.LText = data.LText;
				                item.UnitCode = data.UnitCode;
				                item.BMSCH = data.BMSCH;
				                item.LAR01 = data.LAR01;
				                item.VGE01 = data.VGE01;
				                item.VGW01 = data.VGW01;
				                item.LAR02 = data.LAR02;
				                item.VGE02 = data.VGE02;
				                item.VGW02 = data.VGW02;
				                item.LAR03 = data.LAR03;
				                item.VGE03 = data.VGE03;
				                item.VGW03 = data.VGW03;
				                item.LAR04 = data.LAR04;
				                item.VGE04 = data.VGE04;
				                item.VGW04 = data.VGW04;
				                item.LAR05 = data.LAR05;
				                item.VGE05 = data.VGE05;
				                item.VGW05 = data.VGW05;
				                item.LAR06 = data.LAR06;
				                item.VGE06 = data.VGE06;
				                item.VGW06 = data.VGW06;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PP_ProcRouteProc>();
                var i = (from p in ctx.DataContext.PP_ProcRouteProc.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PLNNR = i.PLNNR;
										this.PLNAL = i.PLNAL;
										this.PLNKN = i.PLNKN;
										this.UseDate = i.UseDate;
										this.IsDel = i.IsDel;
										this.PARKZ = i.PARKZ;
										this.VORNR = i.VORNR;
										this.WorkCtr = i.WorkCtr;
										this.Plant = i.Plant;
										this.LText = i.LText;
										this.UnitCode = i.UnitCode;
										this.BMSCH = i.BMSCH;
										this.LAR01 = i.LAR01;
										this.VGE01 = i.VGE01;
										this.VGW01 = i.VGW01;
										this.LAR02 = i.LAR02;
										this.VGE02 = i.VGE02;
										this.VGW02 = i.VGW02;
										this.LAR03 = i.LAR03;
										this.VGE03 = i.VGE03;
										this.VGW03 = i.VGW03;
										this.LAR04 = i.LAR04;
										this.VGE04 = i.VGE04;
										this.VGW04 = i.VGW04;
										this.LAR05 = i.LAR05;
										this.VGE05 = i.VGE05;
										this.VGW05 = i.VGW05;
										this.LAR06 = i.LAR06;
										this.VGE06 = i.VGE06;
										this.VGW06 = i.VGW06;
					}
            }
        }
	}

	public class PP_ProcRouteProcsFactory : Common.Business.PP_ProcRouteProcs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PP_ProcRouteProc
                        select PP_ProcRouteProcFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PP_ProcRouteProc
                        select PP_ProcRouteProcFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PP_ProcRouteProc>();
                var i = (from p in ctx.DataContext.PP_ProcRouteProc.Where(exp)
                         select PP_ProcRouteProcFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PP_ProcRouteProc>();
                var i = from p in ctx.DataContext.PP_ProcRouteProc.Where(exp)
                         select PP_ProcRouteProcFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
