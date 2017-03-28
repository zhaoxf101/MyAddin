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
	public class FE_UserMessageGroupFactory:Common.Business.FE_UserMessageGroup
    {
        public static Common.Business.FE_UserMessageGroup Fetch(FE_UserMessageGroup data)
        {
            Common.Business.FE_UserMessageGroup item = (Common.Business.FE_UserMessageGroup)Activator.CreateInstance(typeof(Common.Business.FE_UserMessageGroup));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.MessageID = data.MessageID;
				                item.UserName = data.UserName;
				                item.GroupName = data.GroupName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_UserMessageGroup>();
                var i = (from p in ctx.DataContext.FE_UserMessageGroup.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.MessageID = i.MessageID;
										this.UserName = i.UserName;
										this.GroupName = i.GroupName;
					}
            }
        }
	}

	public class FE_UserMessageGroupsFactory : Common.Business.FE_UserMessageGroups
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_UserMessageGroup
                        select FE_UserMessageGroupFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_UserMessageGroup
                        select FE_UserMessageGroupFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_UserMessageGroup>();
                var i = (from p in ctx.DataContext.FE_UserMessageGroup.Where(exp)
                         select FE_UserMessageGroupFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_UserMessageGroup>();
                var i = from p in ctx.DataContext.FE_UserMessageGroup.Where(exp)
                         select FE_UserMessageGroupFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
