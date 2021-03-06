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
	public class WF_RightsNodeUserFactory:Common.Business.WF_RightsNodeUser
    {
        public static Common.Business.WF_RightsNodeUser Fetch(WF_RightsNodeUser data)
        {
            Common.Business.WF_RightsNodeUser item = (Common.Business.WF_RightsNodeUser)Activator.CreateInstance(typeof(Common.Business.WF_RightsNodeUser));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.RNodeCode = data.RNodeCode;
				                item.DepCode = data.DepCode;
				                item.PositionCode = data.PositionCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<WF_RightsNodeUser>();
                var i = (from p in ctx.DataContext.WF_RightsNodeUser.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.RNodeCode = i.RNodeCode;
										this.DepCode = i.DepCode;
										this.PositionCode = i.PositionCode;
					}
            }
        }
	}

	public class WF_RightsNodeUsersFactory : Common.Business.WF_RightsNodeUsers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.WF_RightsNodeUser
                        select WF_RightsNodeUserFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.WF_RightsNodeUser
                        select WF_RightsNodeUserFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<WF_RightsNodeUser>();
                var i = (from p in ctx.DataContext.WF_RightsNodeUser.Where(exp)
                         select WF_RightsNodeUserFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<WF_RightsNodeUser>();
                var i = from p in ctx.DataContext.WF_RightsNodeUser.Where(exp)
                         select WF_RightsNodeUserFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
