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
	public class PM_AllotAppTuiFactory:Common.Business.PM_AllotAppTui
    {
        public static Common.Business.PM_AllotAppTui Fetch(PM_AllotAppTui data)
        {
            Common.Business.PM_AllotAppTui item = (Common.Business.PM_AllotAppTui)Activator.CreateInstance(typeof(Common.Business.PM_AllotAppTui));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AllotAppNo = data.AllotAppNo;
				                item.AccYear = data.AccYear;
				                item.ClassCode = data.ClassCode;
				                item.FeeItemCode = data.FeeItemCode;
				                item.ProjCode = data.ProjCode;
				                item.LAmt = data.LAmt;
				                item.UAmt = data.UAmt;
				                item.FDAmt = data.FDAmt;
				                item.AppAmt = data.AppAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_AllotAppTui>();
                var i = (from p in ctx.DataContext.PM_AllotAppTui.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AllotAppNo = i.AllotAppNo;
										this.AccYear = i.AccYear;
										this.ClassCode = i.ClassCode;
										this.FeeItemCode = i.FeeItemCode;
										this.ProjCode = i.ProjCode;
										this.LAmt = i.LAmt;
										this.UAmt = i.UAmt;
										this.FDAmt = i.FDAmt;
										this.AppAmt = i.AppAmt;
					}
            }
        }
	}

	public class PM_AllotAppTuisFactory : Common.Business.PM_AllotAppTuis
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_AllotAppTui
                        select PM_AllotAppTuiFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_AllotAppTui
                        select PM_AllotAppTuiFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_AllotAppTui>();
                var i = (from p in ctx.DataContext.PM_AllotAppTui.Where(exp)
                         select PM_AllotAppTuiFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_AllotAppTui>();
                var i = from p in ctx.DataContext.PM_AllotAppTui.Where(exp)
                         select PM_AllotAppTuiFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
