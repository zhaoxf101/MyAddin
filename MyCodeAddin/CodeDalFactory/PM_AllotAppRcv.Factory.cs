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
	public class PM_AllotAppRcvFactory:Common.Business.PM_AllotAppRcv
    {
        public static Common.Business.PM_AllotAppRcv Fetch(PM_AllotAppRcv data)
        {
            Common.Business.PM_AllotAppRcv item = (Common.Business.PM_AllotAppRcv)Activator.CreateInstance(typeof(Common.Business.PM_AllotAppRcv));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AllotAppNo = data.AllotAppNo;
				                item.VouchNo = data.VouchNo;
				                item.LineNR = data.LineNR;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.ProjInNo = data.ProjInNo;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.FundCode = data.FundCode;
				                item.VendorCode = data.VendorCode;
				                item.GovPlayCode = data.GovPlayCode;
				                item.OneTimeParty = data.OneTimeParty;
				                item.ItemText = data.ItemText;
				                item.LAmt = data.LAmt;
				                item.CAmt = data.CAmt;
				                item.OAmt = data.OAmt;
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
				var exp = lambda.Resolve<PM_AllotAppRcv>();
                var i = (from p in ctx.DataContext.PM_AllotAppRcv.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AllotAppNo = i.AllotAppNo;
										this.VouchNo = i.VouchNo;
										this.LineNR = i.LineNR;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.ProjInNo = i.ProjInNo;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.FundCode = i.FundCode;
										this.VendorCode = i.VendorCode;
										this.GovPlayCode = i.GovPlayCode;
										this.OneTimeParty = i.OneTimeParty;
										this.ItemText = i.ItemText;
										this.LAmt = i.LAmt;
										this.CAmt = i.CAmt;
										this.OAmt = i.OAmt;
										this.UAmt = i.UAmt;
										this.FDAmt = i.FDAmt;
										this.AppAmt = i.AppAmt;
					}
            }
        }
	}

	public class PM_AllotAppRcvsFactory : Common.Business.PM_AllotAppRcvs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_AllotAppRcv
                        select PM_AllotAppRcvFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_AllotAppRcv
                        select PM_AllotAppRcvFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_AllotAppRcv>();
                var i = (from p in ctx.DataContext.PM_AllotAppRcv.Where(exp)
                         select PM_AllotAppRcvFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_AllotAppRcv>();
                var i = from p in ctx.DataContext.PM_AllotAppRcv.Where(exp)
                         select PM_AllotAppRcvFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
