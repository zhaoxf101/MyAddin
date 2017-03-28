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
	public class WF_InstanceFactory:Common.Business.WF_Instance
    {
        public static Common.Business.WF_Instance Fetch(WF_Instance data)
        {
            Common.Business.WF_Instance item = (Common.Business.WF_Instance)Activator.CreateInstance(typeof(Common.Business.WF_Instance));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.WorkflowId = data.WorkflowId;
				                item.ItemId = data.ItemId;
				                item.BarCode = data.BarCode;
				                item.CurrentState = data.CurrentState;
				                item.FromState = data.FromState;
				                item.ActivityId = data.ActivityId;
				                item.Suggestion = data.Suggestion;
				                item.CheckReason = data.CheckReason;
				                item.Submitter = data.Submitter;
				                item.SubmitDate = data.SubmitDate;
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
				var exp = lambda.Resolve<WF_Instance>();
                var i = (from p in ctx.DataContext.WF_Instance.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.WorkflowId = i.WorkflowId;
										this.ItemId = i.ItemId;
										this.BarCode = i.BarCode;
										this.CurrentState = i.CurrentState;
										this.FromState = i.FromState;
										this.ActivityId = i.ActivityId;
										this.Suggestion = i.Suggestion;
										this.CheckReason = i.CheckReason;
										this.Submitter = i.Submitter;
										this.SubmitDate = i.SubmitDate;
										this.TimeStamp = i.TimeStamp;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class WF_InstancesFactory : Common.Business.WF_Instances
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.WF_Instance
                        select WF_InstanceFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.WF_Instance
                        select WF_InstanceFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<WF_Instance>();
                var i = (from p in ctx.DataContext.WF_Instance.Where(exp)
                         select WF_InstanceFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<WF_Instance>();
                var i = from p in ctx.DataContext.WF_Instance.Where(exp)
                         select WF_InstanceFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
