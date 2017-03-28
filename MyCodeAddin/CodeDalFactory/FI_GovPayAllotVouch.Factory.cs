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
	public class FI_GovPayAllotVouchFactory:Common.Business.FI_GovPayAllotVouch
    {
        public static Common.Business.FI_GovPayAllotVouch Fetch(FI_GovPayAllotVouch data)
        {
            Common.Business.FI_GovPayAllotVouch item = (Common.Business.FI_GovPayAllotVouch)Activator.CreateInstance(typeof(Common.Business.FI_GovPayAllotVouch));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.GovAllotNo = data.GovAllotNo;
				                item.VouchNo = data.VouchNo;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.LineNR = data.LineNR;
				                item.VendorCode = data.VendorCode;
				                item.GovPlayCode = data.GovPlayCode;
				                item.ItemText = data.ItemText;
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
				var exp = lambda.Resolve<FI_GovPayAllotVouch>();
                var i = (from p in ctx.DataContext.FI_GovPayAllotVouch.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.GovAllotNo = i.GovAllotNo;
										this.VouchNo = i.VouchNo;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.LineNR = i.LineNR;
										this.VendorCode = i.VendorCode;
										this.GovPlayCode = i.GovPlayCode;
										this.ItemText = i.ItemText;
										this.Amt = i.Amt;
					}
            }
        }
	}

	public class FI_GovPayAllotVouchsFactory : Common.Business.FI_GovPayAllotVouchs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_GovPayAllotVouch
                        select FI_GovPayAllotVouchFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_GovPayAllotVouch
                        select FI_GovPayAllotVouchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_GovPayAllotVouch>();
                var i = (from p in ctx.DataContext.FI_GovPayAllotVouch.Where(exp)
                         select FI_GovPayAllotVouchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_GovPayAllotVouch>();
                var i = from p in ctx.DataContext.FI_GovPayAllotVouch.Where(exp)
                         select FI_GovPayAllotVouchFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
