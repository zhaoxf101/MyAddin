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
	public class WF_StateFactory:Common.Business.WF_State
    {
        public static Common.Business.WF_State Fetch(WF_State data)
        {
            Common.Business.WF_State item = (Common.Business.WF_State)Activator.CreateInstance(typeof(Common.Business.WF_State));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.WorkflowId = data.WorkflowId;
				                item.StateId = data.StateId;
				                item.StateName = data.StateName;
				                item.CheckName = data.CheckName;
				                item.Description = data.Description;
				                item.OwnerGroupId = data.OwnerGroupId;
				                item.IsOwnerSubmitter = data.IsOwnerSubmitter;
				                item.IsRule = data.IsRule;
				                item.IsSpecActivity = data.IsSpecActivity;
				                item.StateObjectName = data.StateObjectName;
				                item.WinformName = data.WinformName;
				                item.WebformName = data.WebformName;
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
				var exp = lambda.Resolve<WF_State>();
                var i = (from p in ctx.DataContext.WF_State.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.WorkflowId = i.WorkflowId;
										this.StateId = i.StateId;
										this.StateName = i.StateName;
										this.CheckName = i.CheckName;
										this.Description = i.Description;
										this.OwnerGroupId = i.OwnerGroupId;
										this.IsOwnerSubmitter = i.IsOwnerSubmitter;
										this.IsRule = i.IsRule;
										this.IsSpecActivity = i.IsSpecActivity;
										this.StateObjectName = i.StateObjectName;
										this.WinformName = i.WinformName;
										this.WebformName = i.WebformName;
										this.TimeStamp = i.TimeStamp;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class WF_StatesFactory : Common.Business.WF_States
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.WF_State
                        select WF_StateFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.WF_State
                        select WF_StateFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<WF_State>();
                var i = (from p in ctx.DataContext.WF_State.Where(exp)
                         select WF_StateFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<WF_State>();
                var i = from p in ctx.DataContext.WF_State.Where(exp)
                         select WF_StateFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
