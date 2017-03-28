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
	public class FI_AccYearFactory:Common.Business.FI_AccYear
    {
        public static Common.Business.FI_AccYear Fetch(FI_AccYear data)
        {
            Common.Business.FI_AccYear item = (Common.Business.FI_AccYear)Activator.CreateInstance(typeof(Common.Business.FI_AccYear));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.AccYearSet = data.AccYearSet;
				                item.PostYear = data.PostYear;
				                item.PostMon = data.PostMon;
				                item.PostDay = data.PostDay;
				                item.AccPid = data.AccPid;
				                item.YearAdj = data.YearAdj;
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
				var exp = lambda.Resolve<FI_AccYear>();
                var i = (from p in ctx.DataContext.FI_AccYear.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.AccYearSet = i.AccYearSet;
										this.PostYear = i.PostYear;
										this.PostMon = i.PostMon;
										this.PostDay = i.PostDay;
										this.AccPid = i.AccPid;
										this.YearAdj = i.YearAdj;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_AccYearsFactory : Common.Business.FI_AccYears
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_AccYear
                        select FI_AccYearFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_AccYear
                        select FI_AccYearFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_AccYear>();
                var i = (from p in ctx.DataContext.FI_AccYear.Where(exp)
                         select FI_AccYearFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_AccYear>();
                var i = from p in ctx.DataContext.FI_AccYear.Where(exp)
                         select FI_AccYearFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
