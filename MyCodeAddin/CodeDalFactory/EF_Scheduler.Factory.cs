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
	public class EF_SchedulerFactory:Common.Business.EF_Scheduler
    {
        public static Common.Business.EF_Scheduler Fetch(EF_Scheduler data)
        {
            Common.Business.EF_Scheduler item = (Common.Business.EF_Scheduler)Activator.CreateInstance(typeof(Common.Business.EF_Scheduler));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Id = data.Id;
				                item.SchedUnit = data.SchedUnit;
				                item.JobCode = data.JobCode;
				                item.DText = data.DText;
				                item.RunNowX = data.RunNowX;
				                item.RunOnceX = data.RunOnceX;
				                item.RunTimes = data.RunTimes;
				                item.TimeFreqX = data.TimeFreqX;
				                item.DateUnit = data.DateUnit;
				                item.TimeUnit = data.TimeUnit;
				                item.Interval = data.Interval;
				                item.SpecDay = data.SpecDay;
				                item.StartTime = data.StartTime;
				                item.EndTime = data.EndTime;
				                item.RowStatus = data.RowStatus;
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
				var exp = lambda.Resolve<EF_Scheduler>();
                var i = (from p in ctx.DataContext.EF_Scheduler.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Id = i.Id;
										this.SchedUnit = i.SchedUnit;
										this.JobCode = i.JobCode;
										this.DText = i.DText;
										this.RunNowX = i.RunNowX;
										this.RunOnceX = i.RunOnceX;
										this.RunTimes = i.RunTimes;
										this.TimeFreqX = i.TimeFreqX;
										this.DateUnit = i.DateUnit;
										this.TimeUnit = i.TimeUnit;
										this.Interval = i.Interval;
										this.SpecDay = i.SpecDay;
										this.StartTime = i.StartTime;
										this.EndTime = i.EndTime;
										this.RowStatus = i.RowStatus;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class EF_SchedulersFactory : Common.Business.EF_Schedulers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_Scheduler
                        select EF_SchedulerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_Scheduler
                        select EF_SchedulerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_Scheduler>();
                var i = (from p in ctx.DataContext.EF_Scheduler.Where(exp)
                         select EF_SchedulerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_Scheduler>();
                var i = from p in ctx.DataContext.EF_Scheduler.Where(exp)
                         select EF_SchedulerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
