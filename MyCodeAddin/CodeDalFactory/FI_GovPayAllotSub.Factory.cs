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
	public class FI_GovPayAllotSubFactory:Common.Business.FI_GovPayAllotSub
    {
        public static Common.Business.FI_GovPayAllotSub Fetch(FI_GovPayAllotSub data)
        {
            Common.Business.FI_GovPayAllotSub item = (Common.Business.FI_GovPayAllotSub)Activator.CreateInstance(typeof(Common.Business.FI_GovPayAllotSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.GovAllotNo = data.GovAllotNo;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.FundCode = data.FundCode;
				                item.GovPlayCode = data.GovPlayCode;
				                item.VouchNo = data.VouchNo;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.LineNR = data.LineNR;
				                item.VendorCode = data.VendorCode;
				                item.Amt = data.Amt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_GovPayAllotSub>();
                var i = (from p in ctx.DataContext.FI_GovPayAllotSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.GovAllotNo = i.GovAllotNo;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.FundCode = i.FundCode;
										this.GovPlayCode = i.GovPlayCode;
										this.VouchNo = i.VouchNo;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.LineNR = i.LineNR;
										this.VendorCode = i.VendorCode;
										this.Amt = i.Amt;
					}
            }
        }
	}

	public class FI_GovPayAllotSubsFactory : Common.Business.FI_GovPayAllotSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_GovPayAllotSub
                        select FI_GovPayAllotSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_GovPayAllotSub
                        select FI_GovPayAllotSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_GovPayAllotSub>();
                var i = (from p in ctx.DataContext.FI_GovPayAllotSub.Where(exp)
                         select FI_GovPayAllotSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_GovPayAllotSub>();
                var i = from p in ctx.DataContext.FI_GovPayAllotSub.Where(exp)
                         select FI_GovPayAllotSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
