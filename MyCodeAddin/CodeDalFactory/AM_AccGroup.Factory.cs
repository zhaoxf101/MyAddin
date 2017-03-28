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
	public class AM_AccGroupFactory:Common.Business.AM_AccGroup
    {
        public static Common.Business.AM_AccGroup Fetch(AM_AccGroup data)
        {
            Common.Business.AM_AccGroup item = (Common.Business.AM_AccGroup)Activator.CreateInstance(typeof(Common.Business.AM_AccGroup));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AccGroup = data.AccGroup;
				                item.DText = data.DText;
				                item.DAccCode = data.DAccCode;
				                item.CAccCode = data.CAccCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<AM_AccGroup>();
                var i = (from p in ctx.DataContext.AM_AccGroup.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AccGroup = i.AccGroup;
										this.DText = i.DText;
										this.DAccCode = i.DAccCode;
										this.CAccCode = i.CAccCode;
					}
            }
        }
	}

	public class AM_AccGroupsFactory : Common.Business.AM_AccGroups
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.AM_AccGroup
                        select AM_AccGroupFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.AM_AccGroup
                        select AM_AccGroupFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<AM_AccGroup>();
                var i = (from p in ctx.DataContext.AM_AccGroup.Where(exp)
                         select AM_AccGroupFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<AM_AccGroup>();
                var i = from p in ctx.DataContext.AM_AccGroup.Where(exp)
                         select AM_AccGroupFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
