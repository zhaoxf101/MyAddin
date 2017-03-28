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
	public class PP_BOMFactory:Common.Business.PP_BOM
    {
        public static Common.Business.PP_BOM Fetch(PP_BOM data)
        {
            Common.Business.PP_BOM item = (Common.Business.PP_BOM)Activator.CreateInstance(typeof(Common.Business.PP_BOM));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.STLNR = data.STLNR;
				                item.STLAL = data.STLAL;
				                item.MaterialCode = data.MaterialCode;
				                item.Plant = data.Plant;
				                item.UseDate = data.UseDate;
				                item.IsDel = data.IsDel;
				                item.UnitCode = data.UnitCode;
				                item.BMENG = data.BMENG;
				                item.LText = data.LText;
				                item.STLST = data.STLST;
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
				var exp = lambda.Resolve<PP_BOM>();
                var i = (from p in ctx.DataContext.PP_BOM.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.STLNR = i.STLNR;
										this.STLAL = i.STLAL;
										this.MaterialCode = i.MaterialCode;
										this.Plant = i.Plant;
										this.UseDate = i.UseDate;
										this.IsDel = i.IsDel;
										this.UnitCode = i.UnitCode;
										this.BMENG = i.BMENG;
										this.LText = i.LText;
										this.STLST = i.STLST;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PP_BOMsFactory : Common.Business.PP_BOMs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PP_BOM
                        select PP_BOMFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PP_BOM
                        select PP_BOMFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PP_BOM>();
                var i = (from p in ctx.DataContext.PP_BOM.Where(exp)
                         select PP_BOMFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PP_BOM>();
                var i = from p in ctx.DataContext.PP_BOM.Where(exp)
                         select PP_BOMFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
