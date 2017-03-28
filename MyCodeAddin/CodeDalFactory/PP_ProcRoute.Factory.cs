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
	public class PP_ProcRouteFactory:Common.Business.PP_ProcRoute
    {
        public static Common.Business.PP_ProcRoute Fetch(PP_ProcRoute data)
        {
            Common.Business.PP_ProcRoute item = (Common.Business.PP_ProcRoute)Activator.CreateInstance(typeof(Common.Business.PP_ProcRoute));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PLNNR = data.PLNNR;
				                item.PLNAL = data.PLNAL;
				                item.MaterialCode = data.MaterialCode;
				                item.Plant = data.Plant;
				                item.UseDate = data.UseDate;
				                item.IsDel = data.IsDel;
				                item.UnitCode = data.UnitCode;
				                item.LText = data.LText;
				                item.STLNR = data.STLNR;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PP_ProcRoute>();
                var i = (from p in ctx.DataContext.PP_ProcRoute.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PLNNR = i.PLNNR;
										this.PLNAL = i.PLNAL;
										this.MaterialCode = i.MaterialCode;
										this.Plant = i.Plant;
										this.UseDate = i.UseDate;
										this.IsDel = i.IsDel;
										this.UnitCode = i.UnitCode;
										this.LText = i.LText;
										this.STLNR = i.STLNR;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PP_ProcRoutesFactory : Common.Business.PP_ProcRoutes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PP_ProcRoute
                        select PP_ProcRouteFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PP_ProcRoute
                        select PP_ProcRouteFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PP_ProcRoute>();
                var i = (from p in ctx.DataContext.PP_ProcRoute.Where(exp)
                         select PP_ProcRouteFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PP_ProcRoute>();
                var i = from p in ctx.DataContext.PP_ProcRoute.Where(exp)
                         select PP_ProcRouteFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
