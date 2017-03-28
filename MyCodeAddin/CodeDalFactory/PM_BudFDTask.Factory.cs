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
	public class PM_BudFDTaskFactory:Common.Business.PM_BudFDTask
    {
        public static Common.Business.PM_BudFDTask Fetch(PM_BudFDTask data)
        {
            Common.Business.PM_BudFDTask item = (Common.Business.PM_BudFDTask)Activator.CreateInstance(typeof(Common.Business.PM_BudFDTask));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AppNo = data.AppNo;
				                item.TaskCode = data.TaskCode;
				                item.Year = data.Year;
				                item.ProjCode = data.ProjCode;
				                item.SBudExpFunCode = data.SBudExpFunCode;
				                item.IsAdd = data.IsAdd;
				                item.FDAmt = data.FDAmt;
				                item.BudAmt = data.BudAmt;
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
				var exp = lambda.Resolve<PM_BudFDTask>();
                var i = (from p in ctx.DataContext.PM_BudFDTask.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AppNo = i.AppNo;
										this.TaskCode = i.TaskCode;
										this.Year = i.Year;
										this.ProjCode = i.ProjCode;
										this.SBudExpFunCode = i.SBudExpFunCode;
										this.IsAdd = i.IsAdd;
										this.FDAmt = i.FDAmt;
										this.BudAmt = i.BudAmt;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_BudFDTasksFactory : Common.Business.PM_BudFDTasks
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_BudFDTask
                        select PM_BudFDTaskFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_BudFDTask
                        select PM_BudFDTaskFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_BudFDTask>();
                var i = (from p in ctx.DataContext.PM_BudFDTask.Where(exp)
                         select PM_BudFDTaskFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_BudFDTask>();
                var i = from p in ctx.DataContext.PM_BudFDTask.Where(exp)
                         select PM_BudFDTaskFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
