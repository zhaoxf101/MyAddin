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
	public class FE_ConfigGroupFactory:Common.Business.FE_ConfigGroup
    {
        public static Common.Business.FE_ConfigGroup Fetch(FE_ConfigGroup data)
        {
            Common.Business.FE_ConfigGroup item = (Common.Business.FE_ConfigGroup)Activator.CreateInstance(typeof(Common.Business.FE_ConfigGroup));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ConfigGroupCode = data.ConfigGroupCode;
				                item.ConfigGroupName = data.ConfigGroupName;
				                item.ConfigGroupDesc = data.ConfigGroupDesc;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_ConfigGroup>();
                var i = (from p in ctx.DataContext.FE_ConfigGroup.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ConfigGroupCode = i.ConfigGroupCode;
										this.ConfigGroupName = i.ConfigGroupName;
										this.ConfigGroupDesc = i.ConfigGroupDesc;
					}
            }
        }
	}

	public class FE_ConfigGroupsFactory : Common.Business.FE_ConfigGroups
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_ConfigGroup
                        select FE_ConfigGroupFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_ConfigGroup
                        select FE_ConfigGroupFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_ConfigGroup>();
                var i = (from p in ctx.DataContext.FE_ConfigGroup.Where(exp)
                         select FE_ConfigGroupFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_ConfigGroup>();
                var i = from p in ctx.DataContext.FE_ConfigGroup.Where(exp)
                         select FE_ConfigGroupFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
