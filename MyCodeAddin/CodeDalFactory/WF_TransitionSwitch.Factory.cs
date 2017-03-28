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
	public class WF_TransitionSwitchFactory:Common.Business.WF_TransitionSwitch
    {
        public static Common.Business.WF_TransitionSwitch Fetch(WF_TransitionSwitch data)
        {
            Common.Business.WF_TransitionSwitch item = (Common.Business.WF_TransitionSwitch)Activator.CreateInstance(typeof(Common.Business.WF_TransitionSwitch));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.WorkflowId = data.WorkflowId;
				                item.FromState = data.FromState;
				                item.ActivityId = data.ActivityId;
				                item.ToState = data.ToState;
				                item.GrpMark = data.GrpMark;
				                item.Position = data.Position;
				                item.RuleId = data.RuleId;
				                item.Value = data.Value;
				                item.Args = data.Args;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<WF_TransitionSwitch>();
                var i = (from p in ctx.DataContext.WF_TransitionSwitch.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.WorkflowId = i.WorkflowId;
										this.FromState = i.FromState;
										this.ActivityId = i.ActivityId;
										this.ToState = i.ToState;
										this.GrpMark = i.GrpMark;
										this.Position = i.Position;
										this.RuleId = i.RuleId;
										this.Value = i.Value;
										this.Args = i.Args;
					}
            }
        }
	}

	public class WF_TransitionSwitchsFactory : Common.Business.WF_TransitionSwitchs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.WF_TransitionSwitch
                        select WF_TransitionSwitchFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.WF_TransitionSwitch
                        select WF_TransitionSwitchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<WF_TransitionSwitch>();
                var i = (from p in ctx.DataContext.WF_TransitionSwitch.Where(exp)
                         select WF_TransitionSwitchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<WF_TransitionSwitch>();
                var i = from p in ctx.DataContext.WF_TransitionSwitch.Where(exp)
                         select WF_TransitionSwitchFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
