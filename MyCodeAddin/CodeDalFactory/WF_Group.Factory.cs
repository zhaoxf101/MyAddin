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
	public class WF_GroupFactory:Common.Business.WF_Group
    {
        public static Common.Business.WF_Group Fetch(WF_Group data)
        {
            Common.Business.WF_Group item = (Common.Business.WF_Group)Activator.CreateInstance(typeof(Common.Business.WF_Group));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.WorkflowGroup = data.WorkflowGroup;
				                item.WorkflowGroupName = data.WorkflowGroupName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<WF_Group>();
                var i = (from p in ctx.DataContext.WF_Group.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.WorkflowGroup = i.WorkflowGroup;
										this.WorkflowGroupName = i.WorkflowGroupName;
					}
            }
        }
	}

	public class WF_GroupsFactory : Common.Business.WF_Groups
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.WF_Group
                        select WF_GroupFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.WF_Group
                        select WF_GroupFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<WF_Group>();
                var i = (from p in ctx.DataContext.WF_Group.Where(exp)
                         select WF_GroupFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<WF_Group>();
                var i = from p in ctx.DataContext.WF_Group.Where(exp)
                         select WF_GroupFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
