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
	public class WF_OwnerGroupSwitchFactory:Common.Business.WF_OwnerGroupSwitch
    {
        public static Common.Business.WF_OwnerGroupSwitch Fetch(WF_OwnerGroupSwitch data)
        {
            Common.Business.WF_OwnerGroupSwitch item = (Common.Business.WF_OwnerGroupSwitch)Activator.CreateInstance(typeof(Common.Business.WF_OwnerGroupSwitch));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.WorkFlowId = data.WorkFlowId;
				                item.OwnerGroupId = data.OwnerGroupId;
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
				var exp = lambda.Resolve<WF_OwnerGroupSwitch>();
                var i = (from p in ctx.DataContext.WF_OwnerGroupSwitch.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.WorkFlowId = i.WorkFlowId;
										this.OwnerGroupId = i.OwnerGroupId;
										this.Position = i.Position;
										this.RuleId = i.RuleId;
										this.Value = i.Value;
										this.Args = i.Args;
					}
            }
        }
	}

	public class WF_OwnerGroupSwitchsFactory : Common.Business.WF_OwnerGroupSwitchs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.WF_OwnerGroupSwitch
                        select WF_OwnerGroupSwitchFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.WF_OwnerGroupSwitch
                        select WF_OwnerGroupSwitchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<WF_OwnerGroupSwitch>();
                var i = (from p in ctx.DataContext.WF_OwnerGroupSwitch.Where(exp)
                         select WF_OwnerGroupSwitchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<WF_OwnerGroupSwitch>();
                var i = from p in ctx.DataContext.WF_OwnerGroupSwitch.Where(exp)
                         select WF_OwnerGroupSwitchFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
