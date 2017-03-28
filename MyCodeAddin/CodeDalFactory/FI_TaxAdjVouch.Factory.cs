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
	public class FI_TaxAdjVouchFactory:Common.Business.FI_TaxAdjVouch
    {
        public static Common.Business.FI_TaxAdjVouch Fetch(FI_TaxAdjVouch data)
        {
            Common.Business.FI_TaxAdjVouch item = (Common.Business.FI_TaxAdjVouch)Activator.CreateInstance(typeof(Common.Business.FI_TaxAdjVouch));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.TaxAdjCode = data.TaxAdjCode;
				                item.VouchNo = data.VouchNo;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.LineNR = data.LineNR;
				                item.VendorCode = data.VendorCode;
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
				var exp = lambda.Resolve<FI_TaxAdjVouch>();
                var i = (from p in ctx.DataContext.FI_TaxAdjVouch.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TaxAdjCode = i.TaxAdjCode;
										this.VouchNo = i.VouchNo;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.LineNR = i.LineNR;
										this.VendorCode = i.VendorCode;
										this.ItemText = i.ItemText;
										this.Amt = i.Amt;
					}
            }
        }
	}

	public class FI_TaxAdjVouchsFactory : Common.Business.FI_TaxAdjVouchs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_TaxAdjVouch
                        select FI_TaxAdjVouchFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_TaxAdjVouch
                        select FI_TaxAdjVouchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_TaxAdjVouch>();
                var i = (from p in ctx.DataContext.FI_TaxAdjVouch.Where(exp)
                         select FI_TaxAdjVouchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_TaxAdjVouch>();
                var i = from p in ctx.DataContext.FI_TaxAdjVouch.Where(exp)
                         select FI_TaxAdjVouchFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
