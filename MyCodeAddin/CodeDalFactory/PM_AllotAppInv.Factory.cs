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
	public class PM_AllotAppInvFactory:Common.Business.PM_AllotAppInv
    {
        public static Common.Business.PM_AllotAppInv Fetch(PM_AllotAppInv data)
        {
            Common.Business.PM_AllotAppInv item = (Common.Business.PM_AllotAppInv)Activator.CreateInstance(typeof(Common.Business.PM_AllotAppInv));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AllotAppNo = data.AllotAppNo;
				                item.VouchNo = data.VouchNo;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.LineNR = data.LineNR;
				                item.ItemText = data.ItemText;
				                item.LAmt = data.LAmt;
				                item.CAmt = data.CAmt;
				                item.OAmt = data.OAmt;
				                item.ProjCode = data.ProjCode;
				                item.UAmt = data.UAmt;
				                item.FDAmt = data.FDAmt;
				                item.AppAmt = data.AppAmt;
				                item.Memo = data.Memo;
				                item.InvNo = data.InvNo;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_AllotAppInv>();
                var i = (from p in ctx.DataContext.PM_AllotAppInv.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AllotAppNo = i.AllotAppNo;
										this.VouchNo = i.VouchNo;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.LineNR = i.LineNR;
										this.ItemText = i.ItemText;
										this.LAmt = i.LAmt;
										this.CAmt = i.CAmt;
										this.OAmt = i.OAmt;
										this.ProjCode = i.ProjCode;
										this.UAmt = i.UAmt;
										this.FDAmt = i.FDAmt;
										this.AppAmt = i.AppAmt;
										this.Memo = i.Memo;
										this.InvNo = i.InvNo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_AllotAppInvsFactory : Common.Business.PM_AllotAppInvs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_AllotAppInv
                        select PM_AllotAppInvFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_AllotAppInv
                        select PM_AllotAppInvFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_AllotAppInv>();
                var i = (from p in ctx.DataContext.PM_AllotAppInv.Where(exp)
                         select PM_AllotAppInvFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_AllotAppInv>();
                var i = from p in ctx.DataContext.PM_AllotAppInv.Where(exp)
                         select PM_AllotAppInvFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
