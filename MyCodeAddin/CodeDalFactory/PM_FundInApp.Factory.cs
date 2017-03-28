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
	public class PM_FundInAppFactory:Common.Business.PM_FundInApp
    {
        public static Common.Business.PM_FundInApp Fetch(PM_FundInApp data)
        {
            Common.Business.PM_FundInApp item = (Common.Business.PM_FundInApp)Activator.CreateInstance(typeof(Common.Business.PM_FundInApp));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Year = data.Year;
				                item.InNo = data.InNo;
				                item.Memo = data.Memo;
				                item.IsAppr = data.IsAppr;
				                item.IsCheck = data.IsCheck;
				                item.Cancelled = data.Cancelled;
				                item.Approved = data.Approved;
				                item.ObjectId = data.ObjectId;
				                item.WorkflowId = data.WorkflowId;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.CheckedUser = data.CheckedUser;
				                item.CheckedDate = data.CheckedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_FundInApp>();
                var i = (from p in ctx.DataContext.PM_FundInApp.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Year = i.Year;
										this.InNo = i.InNo;
										this.Memo = i.Memo;
										this.IsAppr = i.IsAppr;
										this.IsCheck = i.IsCheck;
										this.Cancelled = i.Cancelled;
										this.Approved = i.Approved;
										this.ObjectId = i.ObjectId;
										this.WorkflowId = i.WorkflowId;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.CheckedUser = i.CheckedUser;
										this.CheckedDate = i.CheckedDate;
					}
            }
        }
	}

	public class PM_FundInAppsFactory : Common.Business.PM_FundInApps
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_FundInApp
                        select PM_FundInAppFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_FundInApp
                        select PM_FundInAppFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_FundInApp>();
                var i = (from p in ctx.DataContext.PM_FundInApp.Where(exp)
                         select PM_FundInAppFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_FundInApp>();
                var i = from p in ctx.DataContext.PM_FundInApp.Where(exp)
                         select PM_FundInAppFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
