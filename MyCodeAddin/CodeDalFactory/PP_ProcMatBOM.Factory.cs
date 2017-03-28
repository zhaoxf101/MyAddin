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
	public class PP_ProcMatBOMFactory:Common.Business.PP_ProcMatBOM
    {
        public static Common.Business.PP_ProcMatBOM Fetch(PP_ProcMatBOM data)
        {
            Common.Business.PP_ProcMatBOM item = (Common.Business.PP_ProcMatBOM)Activator.CreateInstance(typeof(Common.Business.PP_ProcMatBOM));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PLNNR = data.PLNNR;
				                item.PLNAL = data.PLNAL;
				                item.ZUONR = data.ZUONR;
				                item.UseDate = data.UseDate;
				                item.IsDel = data.IsDel;
				                item.PARKZ = data.PARKZ;
				                item.PLNFL = data.PLNFL;
				                item.PLNKN = data.PLNKN;
				                item.STLNR = data.STLNR;
				                item.STLAL = data.STLAL;
				                item.UnitCode = data.UnitCode;
				                item.BMENG = data.BMENG;
				                item.RGEKZ = data.RGEKZ;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PP_ProcMatBOM>();
                var i = (from p in ctx.DataContext.PP_ProcMatBOM.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PLNNR = i.PLNNR;
										this.PLNAL = i.PLNAL;
										this.ZUONR = i.ZUONR;
										this.UseDate = i.UseDate;
										this.IsDel = i.IsDel;
										this.PARKZ = i.PARKZ;
										this.PLNFL = i.PLNFL;
										this.PLNKN = i.PLNKN;
										this.STLNR = i.STLNR;
										this.STLAL = i.STLAL;
										this.UnitCode = i.UnitCode;
										this.BMENG = i.BMENG;
										this.RGEKZ = i.RGEKZ;
					}
            }
        }
	}

	public class PP_ProcMatBOMsFactory : Common.Business.PP_ProcMatBOMs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PP_ProcMatBOM
                        select PP_ProcMatBOMFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PP_ProcMatBOM
                        select PP_ProcMatBOMFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PP_ProcMatBOM>();
                var i = (from p in ctx.DataContext.PP_ProcMatBOM.Where(exp)
                         select PP_ProcMatBOMFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PP_ProcMatBOM>();
                var i = from p in ctx.DataContext.PP_ProcMatBOM.Where(exp)
                         select PP_ProcMatBOMFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
