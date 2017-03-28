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
	public class PM_PurContAppBusFactory:Common.Business.PM_PurContAppBus
    {
        public static Common.Business.PM_PurContAppBus Fetch(PM_PurContAppBus data)
        {
            Common.Business.PM_PurContAppBus item = (Common.Business.PM_PurContAppBus)Activator.CreateInstance(typeof(Common.Business.PM_PurContAppBus));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PurContAppBusCode = data.PurContAppBusCode;
				                item.PurContAppBusName = data.PurContAppBusName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_PurContAppBus>();
                var i = (from p in ctx.DataContext.PM_PurContAppBus.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PurContAppBusCode = i.PurContAppBusCode;
										this.PurContAppBusName = i.PurContAppBusName;
					}
            }
        }
	}

	public class PM_PurContAppBussFactory : Common.Business.PM_PurContAppBuss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_PurContAppBus
                        select PM_PurContAppBusFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_PurContAppBus
                        select PM_PurContAppBusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_PurContAppBus>();
                var i = (from p in ctx.DataContext.PM_PurContAppBus.Where(exp)
                         select PM_PurContAppBusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_PurContAppBus>();
                var i = from p in ctx.DataContext.PM_PurContAppBus.Where(exp)
                         select PM_PurContAppBusFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
