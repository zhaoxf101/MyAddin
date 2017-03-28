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
	public class PP_ProcRouteSeqFactory:Common.Business.PP_ProcRouteSeq
    {
        public static Common.Business.PP_ProcRouteSeq Fetch(PP_ProcRouteSeq data)
        {
            Common.Business.PP_ProcRouteSeq item = (Common.Business.PP_ProcRouteSeq)Activator.CreateInstance(typeof(Common.Business.PP_ProcRouteSeq));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PLNNR = data.PLNNR;
				                item.PLNAL = data.PLNAL;
				                item.PLNFL = data.PLNFL;
				                item.UseDate = data.UseDate;
				                item.IsDel = data.IsDel;
				                item.FLGAT = data.FLGAT;
				                item.BKNT1 = data.BKNT1;
				                item.BKNT2 = data.BKNT2;
				                item.LText = data.LText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PP_ProcRouteSeq>();
                var i = (from p in ctx.DataContext.PP_ProcRouteSeq.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PLNNR = i.PLNNR;
										this.PLNAL = i.PLNAL;
										this.PLNFL = i.PLNFL;
										this.UseDate = i.UseDate;
										this.IsDel = i.IsDel;
										this.FLGAT = i.FLGAT;
										this.BKNT1 = i.BKNT1;
										this.BKNT2 = i.BKNT2;
										this.LText = i.LText;
					}
            }
        }
	}

	public class PP_ProcRouteSeqsFactory : Common.Business.PP_ProcRouteSeqs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PP_ProcRouteSeq
                        select PP_ProcRouteSeqFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PP_ProcRouteSeq
                        select PP_ProcRouteSeqFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PP_ProcRouteSeq>();
                var i = (from p in ctx.DataContext.PP_ProcRouteSeq.Where(exp)
                         select PP_ProcRouteSeqFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PP_ProcRouteSeq>();
                var i = from p in ctx.DataContext.PP_ProcRouteSeq.Where(exp)
                         select PP_ProcRouteSeqFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
