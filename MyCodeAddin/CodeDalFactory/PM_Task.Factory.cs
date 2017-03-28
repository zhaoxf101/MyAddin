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
	public class PM_TaskFactory:Common.Business.PM_Task
    {
        public static Common.Business.PM_Task Fetch(PM_Task data)
        {
            Common.Business.PM_Task item = (Common.Business.PM_Task)Activator.CreateInstance(typeof(Common.Business.PM_Task));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.TaskName = data.TaskName;
				                item.Active = data.Active;
				                item.IsAdd = data.IsAdd;
				                item.IsCWCHK = data.IsCWCHK;
				                item.LPersonId = data.LPersonId;
				                item.DeptCode = data.DeptCode;
				                item.Timelimit = data.Timelimit;
				                item.TimeUnit = data.TimeUnit;
				                item.StartTime = data.StartTime;
				                item.EndTime = data.EndTime;
				                item.FDAmt = data.FDAmt;
				                item.SBudExpFunCode = data.SBudExpFunCode;
				                item.ExpAcctCode1 = data.ExpAcctCode1;
				                item.ExpAcctCode2 = data.ExpAcctCode2;
				                item.BTaskCode = data.BTaskCode;
				                item.IsEscrow = data.IsEscrow;
				                item.IsBudCtrl = data.IsBudCtrl;
				                item.IsSpecial = data.IsSpecial;
				                item.MaxDeficit = data.MaxDeficit;
				                item.ParentId = data.ParentId;
				                item.IsGroup = data.IsGroup;
				                item.SortOrder = data.SortOrder;
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
				var exp = lambda.Resolve<PM_Task>();
                var i = (from p in ctx.DataContext.PM_Task.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.TaskName = i.TaskName;
										this.Active = i.Active;
										this.IsAdd = i.IsAdd;
										this.IsCWCHK = i.IsCWCHK;
										this.LPersonId = i.LPersonId;
										this.DeptCode = i.DeptCode;
										this.Timelimit = i.Timelimit;
										this.TimeUnit = i.TimeUnit;
										this.StartTime = i.StartTime;
										this.EndTime = i.EndTime;
										this.FDAmt = i.FDAmt;
										this.SBudExpFunCode = i.SBudExpFunCode;
										this.ExpAcctCode1 = i.ExpAcctCode1;
										this.ExpAcctCode2 = i.ExpAcctCode2;
										this.BTaskCode = i.BTaskCode;
										this.IsEscrow = i.IsEscrow;
										this.IsBudCtrl = i.IsBudCtrl;
										this.IsSpecial = i.IsSpecial;
										this.MaxDeficit = i.MaxDeficit;
										this.ParentId = i.ParentId;
										this.IsGroup = i.IsGroup;
										this.SortOrder = i.SortOrder;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_TasksFactory : Common.Business.PM_Tasks
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_Task
                        select PM_TaskFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_Task
                        select PM_TaskFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_Task>();
                var i = (from p in ctx.DataContext.PM_Task.Where(exp)
                         select PM_TaskFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_Task>();
                var i = from p in ctx.DataContext.PM_Task.Where(exp)
                         select PM_TaskFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
