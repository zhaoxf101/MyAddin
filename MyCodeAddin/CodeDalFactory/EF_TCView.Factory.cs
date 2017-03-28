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
	public class EF_TCViewFactory:Common.Business.EF_TCView
    {
        public static Common.Business.EF_TCView Fetch(EF_TCView data)
        {
            Common.Business.EF_TCView item = (Common.Business.EF_TCView)Activator.CreateInstance(typeof(Common.Business.EF_TCView));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Program = data.Program;
				                item.UserType = data.UserType;
				                item.TCUser = data.TCUser;
				                item.TCControl = data.TCControl;
				                item.TCVersion = data.TCVersion;
				                item.FieldPos = data.FieldPos;
				                item.FieldName = data.FieldName;
				                item.FieldLen = data.FieldLen;
				                item.FixCols = data.FixCols;
				                item.LineSel = data.LineSel;
				                item.ColSel = data.ColSel;
				                item.TCH_Grid = data.TCH_Grid;
				                item.TCV_Grid = data.TCV_Grid;
				                item.Invisible = data.Invisible;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_TCView>();
                var i = (from p in ctx.DataContext.EF_TCView.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Program = i.Program;
										this.UserType = i.UserType;
										this.TCUser = i.TCUser;
										this.TCControl = i.TCControl;
										this.TCVersion = i.TCVersion;
										this.FieldPos = i.FieldPos;
										this.FieldName = i.FieldName;
										this.FieldLen = i.FieldLen;
										this.FixCols = i.FixCols;
										this.LineSel = i.LineSel;
										this.ColSel = i.ColSel;
										this.TCH_Grid = i.TCH_Grid;
										this.TCV_Grid = i.TCV_Grid;
										this.Invisible = i.Invisible;
					}
            }
        }
	}

	public class EF_TCViewsFactory : Common.Business.EF_TCViews
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_TCView
                        select EF_TCViewFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_TCView
                        select EF_TCViewFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_TCView>();
                var i = (from p in ctx.DataContext.EF_TCView.Where(exp)
                         select EF_TCViewFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_TCView>();
                var i = from p in ctx.DataContext.EF_TCView.Where(exp)
                         select EF_TCViewFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
