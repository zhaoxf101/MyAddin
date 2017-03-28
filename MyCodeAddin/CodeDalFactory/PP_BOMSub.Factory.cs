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
	public class PP_BOMSubFactory:Common.Business.PP_BOMSub
    {
        public static Common.Business.PP_BOMSub Fetch(PP_BOMSub data)
        {
            Common.Business.PP_BOMSub item = (Common.Business.PP_BOMSub)Activator.CreateInstance(typeof(Common.Business.PP_BOMSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.STLNR = data.STLNR;
				                item.STLAL = data.STLAL;
				                item.STLKN = data.STLKN;
				                item.UseDate = data.UseDate;
				                item.IsDel = data.IsDel;
				                item.IDNRK = data.IDNRK;
				                item.POSNR = data.POSNR;
				                item.UnitCode = data.UnitCode;
				                item.MENGE = data.MENGE;
				                item.FMENG = data.FMENG;
				                item.AUSCH = data.AUSCH;
				                item.AVOAU = data.AVOAU;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PP_BOMSub>();
                var i = (from p in ctx.DataContext.PP_BOMSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.STLNR = i.STLNR;
										this.STLAL = i.STLAL;
										this.STLKN = i.STLKN;
										this.UseDate = i.UseDate;
										this.IsDel = i.IsDel;
										this.IDNRK = i.IDNRK;
										this.POSNR = i.POSNR;
										this.UnitCode = i.UnitCode;
										this.MENGE = i.MENGE;
										this.FMENG = i.FMENG;
										this.AUSCH = i.AUSCH;
										this.AVOAU = i.AVOAU;
					}
            }
        }
	}

	public class PP_BOMSubsFactory : Common.Business.PP_BOMSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PP_BOMSub
                        select PP_BOMSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PP_BOMSub
                        select PP_BOMSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PP_BOMSub>();
                var i = (from p in ctx.DataContext.PP_BOMSub.Where(exp)
                         select PP_BOMSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PP_BOMSub>();
                var i = from p in ctx.DataContext.PP_BOMSub.Where(exp)
                         select PP_BOMSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
