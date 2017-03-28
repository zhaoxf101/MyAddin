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
	public class FI_GLMarkFactory:Common.Business.FI_GLMark
    {
        public static Common.Business.FI_GLMark Fetch(FI_GLMark data)
        {
            Common.Business.FI_GLMark item = (Common.Business.FI_GLMark)Activator.CreateInstance(typeof(Common.Business.FI_GLMark));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.AccType = data.AccType;
				                item.GLMark = data.GLMark;
				                item.SText = data.SText;
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
				var exp = lambda.Resolve<FI_GLMark>();
                var i = (from p in ctx.DataContext.FI_GLMark.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.AccType = i.AccType;
										this.GLMark = i.GLMark;
										this.SText = i.SText;
										this.LText = i.LText;
					}
            }
        }
	}

	public class FI_GLMarksFactory : Common.Business.FI_GLMarks
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_GLMark
                        select FI_GLMarkFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_GLMark
                        select FI_GLMarkFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_GLMark>();
                var i = (from p in ctx.DataContext.FI_GLMark.Where(exp)
                         select FI_GLMarkFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_GLMark>();
                var i = from p in ctx.DataContext.FI_GLMark.Where(exp)
                         select FI_GLMarkFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
