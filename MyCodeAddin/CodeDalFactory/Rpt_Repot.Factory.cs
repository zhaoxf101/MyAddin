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
	public class Rpt_RepotFactory:Common.Business.Rpt_Repot
    {
        public static Common.Business.Rpt_Repot Fetch(Rpt_Repot data)
        {
            Common.Business.Rpt_Repot item = (Common.Business.Rpt_Repot)Activator.CreateInstance(typeof(Common.Business.Rpt_Repot));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.RepotCode = data.RepotCode;
				                item.ReportName = data.ReportName;
				                item.ReportType = data.ReportType;
				                item.ReportFile = data.ReportFile;
				                item.IsYear = data.IsYear;
				                item.IsMonth = data.IsMonth;
				                item.IsDay = data.IsDay;
				                item.BookType = data.BookType;
				                item.Sort = data.Sort;
				                item.IsLandscape = data.IsLandscape;
				                item.PageWidth = data.PageWidth;
				                item.PageHeight = data.PageHeight;
				                item.PageTop = data.PageTop;
				                item.PageLeft = data.PageLeft;
				                item.PageRight = data.PageRight;
				                item.PageBottom = data.PageBottom;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Rpt_Repot>();
                var i = (from p in ctx.DataContext.Rpt_Repot.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.RepotCode = i.RepotCode;
										this.ReportName = i.ReportName;
										this.ReportType = i.ReportType;
										this.ReportFile = i.ReportFile;
										this.IsYear = i.IsYear;
										this.IsMonth = i.IsMonth;
										this.IsDay = i.IsDay;
										this.BookType = i.BookType;
										this.Sort = i.Sort;
										this.IsLandscape = i.IsLandscape;
										this.PageWidth = i.PageWidth;
										this.PageHeight = i.PageHeight;
										this.PageTop = i.PageTop;
										this.PageLeft = i.PageLeft;
										this.PageRight = i.PageRight;
										this.PageBottom = i.PageBottom;
					}
            }
        }
	}

	public class Rpt_RepotsFactory : Common.Business.Rpt_Repots
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Rpt_Repot
                        select Rpt_RepotFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Rpt_Repot
                        select Rpt_RepotFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Rpt_Repot>();
                var i = (from p in ctx.DataContext.Rpt_Repot.Where(exp)
                         select Rpt_RepotFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Rpt_Repot>();
                var i = from p in ctx.DataContext.Rpt_Repot.Where(exp)
                         select Rpt_RepotFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
