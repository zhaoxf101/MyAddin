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
	public class WF_WorkFlowFactory:Common.Business.WF_WorkFlow
    {
        public static Common.Business.WF_WorkFlow Fetch(WF_WorkFlow data)
        {
            Common.Business.WF_WorkFlow item = (Common.Business.WF_WorkFlow)Activator.CreateInstance(typeof(Common.Business.WF_WorkFlow));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.WorkflowId = data.WorkflowId;
				                item.WorkflowName = data.WorkflowName;
				                item.WorkflowGroup = data.WorkflowGroup;
				                item.InitialState = data.InitialState;
				                item.Stoped = data.Stoped;
				                item.Description = data.Description;
				                item.TimeStamp = data.TimeStamp;
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
				var exp = lambda.Resolve<WF_WorkFlow>();
                var i = (from p in ctx.DataContext.WF_WorkFlow.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.WorkflowId = i.WorkflowId;
										this.WorkflowName = i.WorkflowName;
										this.WorkflowGroup = i.WorkflowGroup;
										this.InitialState = i.InitialState;
										this.Stoped = i.Stoped;
										this.Description = i.Description;
										this.TimeStamp = i.TimeStamp;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class WF_WorkFlowsFactory : Common.Business.WF_WorkFlows
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.WF_WorkFlow
                        select WF_WorkFlowFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.WF_WorkFlow
                        select WF_WorkFlowFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<WF_WorkFlow>();
                var i = (from p in ctx.DataContext.WF_WorkFlow.Where(exp)
                         select WF_WorkFlowFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<WF_WorkFlow>();
                var i = from p in ctx.DataContext.WF_WorkFlow.Where(exp)
                         select WF_WorkFlowFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
