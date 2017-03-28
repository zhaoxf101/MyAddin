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
	public class HR_SalaryPeriodFactory:Common.Business.HR_SalaryPeriod
    {
        public static Common.Business.HR_SalaryPeriod Fetch(HR_SalaryPeriod data)
        {
            Common.Business.HR_SalaryPeriod item = (Common.Business.HR_SalaryPeriod)Activator.CreateInstance(typeof(Common.Business.HR_SalaryPeriod));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SalaryPeriod = data.SalaryPeriod;
				                item.DText = data.DText;
				                item.SalaryRange = data.SalaryRange;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.Sort = data.Sort;
				                item.IsAppoved = data.IsAppoved;
				                item.AccPeriod = data.AccPeriod;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SalaryPeriod>();
                var i = (from p in ctx.DataContext.HR_SalaryPeriod.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SalaryPeriod = i.SalaryPeriod;
										this.DText = i.DText;
										this.SalaryRange = i.SalaryRange;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.Sort = i.Sort;
										this.IsAppoved = i.IsAppoved;
										this.AccPeriod = i.AccPeriod;
					}
            }
        }
	}

	public class HR_SalaryPeriodsFactory : Common.Business.HR_SalaryPeriods
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SalaryPeriod
                        select HR_SalaryPeriodFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SalaryPeriod
                        select HR_SalaryPeriodFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SalaryPeriod>();
                var i = (from p in ctx.DataContext.HR_SalaryPeriod.Where(exp)
                         select HR_SalaryPeriodFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SalaryPeriod>();
                var i = from p in ctx.DataContext.HR_SalaryPeriod.Where(exp)
                         select HR_SalaryPeriodFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
