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
	public class PM_PostBusFactory:Common.Business.PM_PostBus
    {
        public static Common.Business.PM_PostBus Fetch(PM_PostBus data)
        {
            Common.Business.PM_PostBus item = (Common.Business.PM_PostBus)Activator.CreateInstance(typeof(Common.Business.PM_PostBus));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PostBus = data.PostBus;
				                item.PostMark = data.PostMark;
				                item.PostProj = data.PostProj;
				                item.PostFund = data.PostFund;
				                item.PostAss = data.PostAss;
				                item.PostCont = data.PostCont;
				                item.Status = data.Status;
				                item.DText = data.DText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_PostBus>();
                var i = (from p in ctx.DataContext.PM_PostBus.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PostBus = i.PostBus;
										this.PostMark = i.PostMark;
										this.PostProj = i.PostProj;
										this.PostFund = i.PostFund;
										this.PostAss = i.PostAss;
										this.PostCont = i.PostCont;
										this.Status = i.Status;
										this.DText = i.DText;
					}
            }
        }
	}

	public class PM_PostBussFactory : Common.Business.PM_PostBuss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_PostBus
                        select PM_PostBusFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_PostBus
                        select PM_PostBusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_PostBus>();
                var i = (from p in ctx.DataContext.PM_PostBus.Where(exp)
                         select PM_PostBusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_PostBus>();
                var i = from p in ctx.DataContext.PM_PostBus.Where(exp)
                         select PM_PostBusFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
