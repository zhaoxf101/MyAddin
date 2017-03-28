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
	public class WF_RightsNodeFactory:Common.Business.WF_RightsNode
    {
        public static Common.Business.WF_RightsNode Fetch(WF_RightsNode data)
        {
            Common.Business.WF_RightsNode item = (Common.Business.WF_RightsNode)Activator.CreateInstance(typeof(Common.Business.WF_RightsNode));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.RNodeCode = data.RNodeCode;
				                item.RNodeName = data.RNodeName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<WF_RightsNode>();
                var i = (from p in ctx.DataContext.WF_RightsNode.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.RNodeCode = i.RNodeCode;
										this.RNodeName = i.RNodeName;
					}
            }
        }
	}

	public class WF_RightsNodesFactory : Common.Business.WF_RightsNodes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.WF_RightsNode
                        select WF_RightsNodeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.WF_RightsNode
                        select WF_RightsNodeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<WF_RightsNode>();
                var i = (from p in ctx.DataContext.WF_RightsNode.Where(exp)
                         select WF_RightsNodeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<WF_RightsNode>();
                var i = from p in ctx.DataContext.WF_RightsNode.Where(exp)
                         select WF_RightsNodeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
