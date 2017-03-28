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
	public class PM_ProjInBillTuiFactory:Common.Business.PM_ProjInBillTui
    {
        public static Common.Business.PM_ProjInBillTui Fetch(PM_ProjInBillTui data)
        {
            Common.Business.PM_ProjInBillTui item = (Common.Business.PM_ProjInBillTui)Activator.CreateInstance(typeof(Common.Business.PM_ProjInBillTui));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ProjInNo = data.ProjInNo;
				                item.AccYear = data.AccYear;
				                item.ClassCode = data.ClassCode;
				                item.FeeItemCode = data.FeeItemCode;
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
				var exp = lambda.Resolve<PM_ProjInBillTui>();
                var i = (from p in ctx.DataContext.PM_ProjInBillTui.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ProjInNo = i.ProjInNo;
										this.AccYear = i.AccYear;
										this.ClassCode = i.ClassCode;
										this.FeeItemCode = i.FeeItemCode;
										this.LAmt = i.LAmt;
										this.UAmt = i.UAmt;
										this.FDAmt = i.FDAmt;
										this.AppAmt = i.AppAmt;
					}
            }
        }
	}

	public class PM_ProjInBillTuisFactory : Common.Business.PM_ProjInBillTuis
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ProjInBillTui
                        select PM_ProjInBillTuiFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ProjInBillTui
                        select PM_ProjInBillTuiFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ProjInBillTui>();
                var i = (from p in ctx.DataContext.PM_ProjInBillTui.Where(exp)
                         select PM_ProjInBillTuiFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ProjInBillTui>();
                var i = from p in ctx.DataContext.PM_ProjInBillTui.Where(exp)
                         select PM_ProjInBillTuiFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
