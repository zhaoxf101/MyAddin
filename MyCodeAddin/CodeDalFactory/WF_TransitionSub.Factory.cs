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
	public class WF_TransitionSubFactory:Common.Business.WF_TransitionSub
    {
        public static Common.Business.WF_TransitionSub Fetch(WF_TransitionSub data)
        {
            Common.Business.WF_TransitionSub item = (Common.Business.WF_TransitionSub)Activator.CreateInstance(typeof(Common.Business.WF_TransitionSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.WorkflowId = data.WorkflowId;
				                item.FromState = data.FromState;
				                item.ActivityId = data.ActivityId;
				                item.ToState = data.ToState;
				                item.GrpMark = data.GrpMark;
				                item.RuleText = data.RuleText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<WF_TransitionSub>();
                var i = (from p in ctx.DataContext.WF_TransitionSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.WorkflowId = i.WorkflowId;
										this.FromState = i.FromState;
										this.ActivityId = i.ActivityId;
										this.ToState = i.ToState;
										this.GrpMark = i.GrpMark;
										this.RuleText = i.RuleText;
					}
            }
        }
	}

	public class WF_TransitionSubsFactory : Common.Business.WF_TransitionSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.WF_TransitionSub
                        select WF_TransitionSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.WF_TransitionSub
                        select WF_TransitionSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<WF_TransitionSub>();
                var i = (from p in ctx.DataContext.WF_TransitionSub.Where(exp)
                         select WF_TransitionSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<WF_TransitionSub>();
                var i = from p in ctx.DataContext.WF_TransitionSub.Where(exp)
                         select WF_TransitionSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
