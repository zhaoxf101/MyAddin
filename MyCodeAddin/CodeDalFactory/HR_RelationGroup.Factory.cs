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
	public class HR_RelationGroupFactory:Common.Business.HR_RelationGroup
    {
        public static Common.Business.HR_RelationGroup Fetch(HR_RelationGroup data)
        {
            Common.Business.HR_RelationGroup item = (Common.Business.HR_RelationGroup)Activator.CreateInstance(typeof(Common.Business.HR_RelationGroup));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.RelationGroup = data.RelationGroup;
				                item.RelationGroupText = data.RelationGroupText;
				                item.WebObject = data.WebObject;
				                item.WinObject = data.WinObject;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_RelationGroup>();
                var i = (from p in ctx.DataContext.HR_RelationGroup.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.RelationGroup = i.RelationGroup;
										this.RelationGroupText = i.RelationGroupText;
										this.WebObject = i.WebObject;
										this.WinObject = i.WinObject;
					}
            }
        }
	}

	public class HR_RelationGroupsFactory : Common.Business.HR_RelationGroups
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_RelationGroup
                        select HR_RelationGroupFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_RelationGroup
                        select HR_RelationGroupFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_RelationGroup>();
                var i = (from p in ctx.DataContext.HR_RelationGroup.Where(exp)
                         select HR_RelationGroupFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_RelationGroup>();
                var i = from p in ctx.DataContext.HR_RelationGroup.Where(exp)
                         select HR_RelationGroupFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
