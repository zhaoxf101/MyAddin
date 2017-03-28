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
	public class FE_JobFactory:Common.Business.FE_Job
    {
        public static Common.Business.FE_Job Fetch(FE_Job data)
        {
            Common.Business.FE_Job item = (Common.Business.FE_Job)Activator.CreateInstance(typeof(Common.Business.FE_Job));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.JobCode = data.JobCode;
				                item.JobName = data.JobName;
				                item.JobGroup = data.JobGroup;
				                item.JobStartTime = data.JobStartTime;
				                item.JobStatus = data.JobStatus;
				                item.JobMsg = data.JobMsg;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_Job>();
                var i = (from p in ctx.DataContext.FE_Job.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.JobCode = i.JobCode;
										this.JobName = i.JobName;
										this.JobGroup = i.JobGroup;
										this.JobStartTime = i.JobStartTime;
										this.JobStatus = i.JobStatus;
										this.JobMsg = i.JobMsg;
					}
            }
        }
	}

	public class FE_JobsFactory : Common.Business.FE_Jobs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_Job
                        select FE_JobFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_Job
                        select FE_JobFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_Job>();
                var i = (from p in ctx.DataContext.FE_Job.Where(exp)
                         select FE_JobFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_Job>();
                var i = from p in ctx.DataContext.FE_Job.Where(exp)
                         select FE_JobFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
