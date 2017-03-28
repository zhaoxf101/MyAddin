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
	public class Rpt_RuleSubFactory:Common.Business.Rpt_RuleSub
    {
        public static Common.Business.Rpt_RuleSub Fetch(Rpt_RuleSub data)
        {
            Common.Business.Rpt_RuleSub item = (Common.Business.Rpt_RuleSub)Activator.CreateInstance(typeof(Common.Business.Rpt_RuleSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.RuleId = data.RuleId;
				                item.Position = data.Position;
				                item.PropertyId = data.PropertyId;
				                item.Operator = data.Operator;
				                item.Constants = data.Constants;
				                item.IsGroup = data.IsGroup;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Rpt_RuleSub>();
                var i = (from p in ctx.DataContext.Rpt_RuleSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.RuleId = i.RuleId;
										this.Position = i.Position;
										this.PropertyId = i.PropertyId;
										this.Operator = i.Operator;
										this.Constants = i.Constants;
										this.IsGroup = i.IsGroup;
					}
            }
        }
	}

	public class Rpt_RuleSubsFactory : Common.Business.Rpt_RuleSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Rpt_RuleSub
                        select Rpt_RuleSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Rpt_RuleSub
                        select Rpt_RuleSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Rpt_RuleSub>();
                var i = (from p in ctx.DataContext.Rpt_RuleSub.Where(exp)
                         select Rpt_RuleSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Rpt_RuleSub>();
                var i = from p in ctx.DataContext.Rpt_RuleSub.Where(exp)
                         select Rpt_RuleSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
