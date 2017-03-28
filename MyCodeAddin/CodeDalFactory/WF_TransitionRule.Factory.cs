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
	public class WF_TransitionRuleFactory:Common.Business.WF_TransitionRule
    {
        public static Common.Business.WF_TransitionRule Fetch(WF_TransitionRule data)
        {
            Common.Business.WF_TransitionRule item = (Common.Business.WF_TransitionRule)Activator.CreateInstance(typeof(Common.Business.WF_TransitionRule));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.WorkflowId = data.WorkflowId;
				                item.FromState = data.FromState;
				                item.ActivityId = data.ActivityId;
				                item.ToState = data.ToState;
				                item.GrpMark = data.GrpMark;
				                item.Position = data.Position;
				                item.PropertyId = data.PropertyId;
				                item.Operator = data.Operator;
				                item.Constants = data.Constants;
				                item.AndOr = data.AndOr;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<WF_TransitionRule>();
                var i = (from p in ctx.DataContext.WF_TransitionRule.Where(exp)
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
										this.PropertyId = i.PropertyId;
										this.Operator = i.Operator;
										this.Constants = i.Constants;
										this.AndOr = i.AndOr;
					}
            }
        }
	}

	public class WF_TransitionRulesFactory : Common.Business.WF_TransitionRules
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.WF_TransitionRule
                        select WF_TransitionRuleFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.WF_TransitionRule
                        select WF_TransitionRuleFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<WF_TransitionRule>();
                var i = (from p in ctx.DataContext.WF_TransitionRule.Where(exp)
                         select WF_TransitionRuleFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<WF_TransitionRule>();
                var i = from p in ctx.DataContext.WF_TransitionRule.Where(exp)
                         select WF_TransitionRuleFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
