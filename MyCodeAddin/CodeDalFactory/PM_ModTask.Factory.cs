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
	public class PM_ModTaskFactory:Common.Business.PM_ModTask
    {
        public static Common.Business.PM_ModTask Fetch(PM_ModTask data)
        {
            Common.Business.PM_ModTask item = (Common.Business.PM_ModTask)Activator.CreateInstance(typeof(Common.Business.PM_ModTask));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.TaskName = data.TaskName;
				                item.Timelimit = data.Timelimit;
				                item.TimeUnit = data.TimeUnit;
				                item.SBudExpFunCode = data.SBudExpFunCode;
				                item.Active = data.Active;
				                item.ExpAcctCode1 = data.ExpAcctCode1;
				                item.ExpAcctCode2 = data.ExpAcctCode2;
				                item.IsEscrow = data.IsEscrow;
				                item.IsBudItem = data.IsBudItem;
				                item.IsFinItem = data.IsFinItem;
				                item.BTaskCode = data.BTaskCode;
				                item.IsBudCtrl = data.IsBudCtrl;
				                item.IsSpecial = data.IsSpecial;
				                item.MaxDeficit = data.MaxDeficit;
				                item.FDAmt = data.FDAmt;
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
				var exp = lambda.Resolve<PM_ModTask>();
                var i = (from p in ctx.DataContext.PM_ModTask.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.TaskName = i.TaskName;
										this.Timelimit = i.Timelimit;
										this.TimeUnit = i.TimeUnit;
										this.SBudExpFunCode = i.SBudExpFunCode;
										this.Active = i.Active;
										this.ExpAcctCode1 = i.ExpAcctCode1;
										this.ExpAcctCode2 = i.ExpAcctCode2;
										this.IsEscrow = i.IsEscrow;
										this.IsBudItem = i.IsBudItem;
										this.IsFinItem = i.IsFinItem;
										this.BTaskCode = i.BTaskCode;
										this.IsBudCtrl = i.IsBudCtrl;
										this.IsSpecial = i.IsSpecial;
										this.MaxDeficit = i.MaxDeficit;
										this.FDAmt = i.FDAmt;
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

	public class PM_ModTasksFactory : Common.Business.PM_ModTasks
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ModTask
                        select PM_ModTaskFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ModTask
                        select PM_ModTaskFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ModTask>();
                var i = (from p in ctx.DataContext.PM_ModTask.Where(exp)
                         select PM_ModTaskFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ModTask>();
                var i = from p in ctx.DataContext.PM_ModTask.Where(exp)
                         select PM_ModTaskFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
