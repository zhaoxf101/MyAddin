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
	public class WF_InsHistoryFactory:Common.Business.WF_InsHistory
    {
        public static Common.Business.WF_InsHistory Fetch(WF_InsHistory data)
        {
            Common.Business.WF_InsHistory item = (Common.Business.WF_InsHistory)Activator.CreateInstance(typeof(Common.Business.WF_InsHistory));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.iRowId = data.iRowId;
				                item.Client = data.Client;
				                item.WorkflowId = data.WorkflowId;
				                item.ItemId = data.ItemId;
				                item.CurrentState = data.CurrentState;
				                item.FromState = data.FromState;
				                item.ActivityId = data.ActivityId;
				                item.Suggestion = data.Suggestion;
				                item.CheckReason = data.CheckReason;
				                item.Submitter = data.Submitter;
				                item.SubmitDate = data.SubmitDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<WF_InsHistory>();
                var i = (from p in ctx.DataContext.WF_InsHistory.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.iRowId = i.iRowId;
										this.Client = i.Client;
										this.WorkflowId = i.WorkflowId;
										this.ItemId = i.ItemId;
										this.CurrentState = i.CurrentState;
										this.FromState = i.FromState;
										this.ActivityId = i.ActivityId;
										this.Suggestion = i.Suggestion;
										this.CheckReason = i.CheckReason;
										this.Submitter = i.Submitter;
										this.SubmitDate = i.SubmitDate;
					}
            }
        }
	}

	public class WF_InsHistorysFactory : Common.Business.WF_InsHistorys
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.WF_InsHistory
                        select WF_InsHistoryFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.WF_InsHistory
                        select WF_InsHistoryFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<WF_InsHistory>();
                var i = (from p in ctx.DataContext.WF_InsHistory.Where(exp)
                         select WF_InsHistoryFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<WF_InsHistory>();
                var i = from p in ctx.DataContext.WF_InsHistory.Where(exp)
                         select WF_InsHistoryFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
