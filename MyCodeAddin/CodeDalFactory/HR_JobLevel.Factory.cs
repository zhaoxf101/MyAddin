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
	public class HR_JobLevelFactory:Common.Business.HR_JobLevel
    {
        public static Common.Business.HR_JobLevel Fetch(HR_JobLevel data)
        {
            Common.Business.HR_JobLevel item = (Common.Business.HR_JobLevel)Activator.CreateInstance(typeof(Common.Business.HR_JobLevel));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.JobLevelCode = data.JobLevelCode;
				                item.JobLevelName = data.JobLevelName;
				                item.Memo = data.Memo;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_JobLevel>();
                var i = (from p in ctx.DataContext.HR_JobLevel.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.JobLevelCode = i.JobLevelCode;
										this.JobLevelName = i.JobLevelName;
										this.Memo = i.Memo;
					}
            }
        }
	}

	public class HR_JobLevelsFactory : Common.Business.HR_JobLevels
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_JobLevel
                        select HR_JobLevelFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_JobLevel
                        select HR_JobLevelFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_JobLevel>();
                var i = (from p in ctx.DataContext.HR_JobLevel.Where(exp)
                         select HR_JobLevelFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_JobLevel>();
                var i = from p in ctx.DataContext.HR_JobLevel.Where(exp)
                         select HR_JobLevelFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
