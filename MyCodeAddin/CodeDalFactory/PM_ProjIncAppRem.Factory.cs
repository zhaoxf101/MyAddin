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
	public class PM_ProjIncAppRemFactory:Common.Business.PM_ProjIncAppRem
    {
        public static Common.Business.PM_ProjIncAppRem Fetch(PM_ProjIncAppRem data)
        {
            Common.Business.PM_ProjIncAppRem item = (Common.Business.PM_ProjIncAppRem)Activator.CreateInstance(typeof(Common.Business.PM_ProjIncAppRem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ProjIncAppNo = data.ProjIncAppNo;
				                item.BName = data.BName;
				                item.ProjCode = data.ProjCode;
				                item.VouchNo = data.VouchNo;
				                item.DeptCode = data.DeptCode;
				                item.FDAmt = data.FDAmt;
				                item.IncAppAmt = data.IncAppAmt;
				                item.LExpFDAmt = data.LExpFDAmt;
				                item.LExpAppAmt = data.LExpAppAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_ProjIncAppRem>();
                var i = (from p in ctx.DataContext.PM_ProjIncAppRem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ProjIncAppNo = i.ProjIncAppNo;
										this.BName = i.BName;
										this.ProjCode = i.ProjCode;
										this.VouchNo = i.VouchNo;
										this.DeptCode = i.DeptCode;
										this.FDAmt = i.FDAmt;
										this.IncAppAmt = i.IncAppAmt;
										this.LExpFDAmt = i.LExpFDAmt;
										this.LExpAppAmt = i.LExpAppAmt;
					}
            }
        }
	}

	public class PM_ProjIncAppRemsFactory : Common.Business.PM_ProjIncAppRems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ProjIncAppRem
                        select PM_ProjIncAppRemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ProjIncAppRem
                        select PM_ProjIncAppRemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ProjIncAppRem>();
                var i = (from p in ctx.DataContext.PM_ProjIncAppRem.Where(exp)
                         select PM_ProjIncAppRemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ProjIncAppRem>();
                var i = from p in ctx.DataContext.PM_ProjIncAppRem.Where(exp)
                         select PM_ProjIncAppRemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
