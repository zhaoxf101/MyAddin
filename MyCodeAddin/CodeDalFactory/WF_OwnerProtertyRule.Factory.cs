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
	public class WF_OwnerProtertyRuleFactory:Common.Business.WF_OwnerProtertyRule
    {
        public static Common.Business.WF_OwnerProtertyRule Fetch(WF_OwnerProtertyRule data)
        {
            Common.Business.WF_OwnerProtertyRule item = (Common.Business.WF_OwnerProtertyRule)Activator.CreateInstance(typeof(Common.Business.WF_OwnerProtertyRule));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.WorkFlowId = data.WorkFlowId;
				                item.OwnerGroupId = data.OwnerGroupId;
				                item.PositionCode = data.PositionCode;
				                item.RowId = data.RowId;
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
				var exp = lambda.Resolve<WF_OwnerProtertyRule>();
                var i = (from p in ctx.DataContext.WF_OwnerProtertyRule.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.WorkFlowId = i.WorkFlowId;
										this.OwnerGroupId = i.OwnerGroupId;
										this.PositionCode = i.PositionCode;
										this.RowId = i.RowId;
										this.PropertyId = i.PropertyId;
										this.Operator = i.Operator;
										this.Constants = i.Constants;
										this.AndOr = i.AndOr;
					}
            }
        }
	}

	public class WF_OwnerProtertyRulesFactory : Common.Business.WF_OwnerProtertyRules
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.WF_OwnerProtertyRule
                        select WF_OwnerProtertyRuleFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.WF_OwnerProtertyRule
                        select WF_OwnerProtertyRuleFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<WF_OwnerProtertyRule>();
                var i = (from p in ctx.DataContext.WF_OwnerProtertyRule.Where(exp)
                         select WF_OwnerProtertyRuleFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<WF_OwnerProtertyRule>();
                var i = from p in ctx.DataContext.WF_OwnerProtertyRule.Where(exp)
                         select WF_OwnerProtertyRuleFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
