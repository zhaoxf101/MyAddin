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
	public class HR_JobFactory:Common.Business.HR_Job
    {
        public static Common.Business.HR_Job Fetch(HR_Job data)
        {
            Common.Business.HR_Job item = (Common.Business.HR_Job)Activator.CreateInstance(typeof(Common.Business.HR_Job));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.JobCode = data.JobCode;
				                item.JobName = data.JobName;
				                item.JobTypeCode = data.JobTypeCode;
				                item.JobLevelCode = data.JobLevelCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_Job>();
                var i = (from p in ctx.DataContext.HR_Job.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.JobCode = i.JobCode;
										this.JobName = i.JobName;
										this.JobTypeCode = i.JobTypeCode;
										this.JobLevelCode = i.JobLevelCode;
					}
            }
        }
	}

	public class HR_JobsFactory : Common.Business.HR_Jobs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_Job
                        select HR_JobFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_Job
                        select HR_JobFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_Job>();
                var i = (from p in ctx.DataContext.HR_Job.Where(exp)
                         select HR_JobFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_Job>();
                var i = from p in ctx.DataContext.HR_Job.Where(exp)
                         select HR_JobFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
