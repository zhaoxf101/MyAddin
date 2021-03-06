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
	public class FI_WoffVouchFactory:Common.Business.FI_WoffVouch
    {
        public static Common.Business.FI_WoffVouch Fetch(FI_WoffVouch data)
        {
            Common.Business.FI_WoffVouch item = (Common.Business.FI_WoffVouch)Activator.CreateInstance(typeof(Common.Business.FI_WoffVouch));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.WoffCode = data.WoffCode;
				                item.RowId = data.RowId;
				                item.VouchNo = data.VouchNo;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.LineNR = data.LineNR;
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
				var exp = lambda.Resolve<FI_WoffVouch>();
                var i = (from p in ctx.DataContext.FI_WoffVouch.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.WoffCode = i.WoffCode;
										this.RowId = i.RowId;
										this.VouchNo = i.VouchNo;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.LineNR = i.LineNR;
										this.ItemText = i.ItemText;
										this.Amt = i.Amt;
					}
            }
        }
	}

	public class FI_WoffVouchsFactory : Common.Business.FI_WoffVouchs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_WoffVouch
                        select FI_WoffVouchFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_WoffVouch
                        select FI_WoffVouchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_WoffVouch>();
                var i = (from p in ctx.DataContext.FI_WoffVouch.Where(exp)
                         select FI_WoffVouchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_WoffVouch>();
                var i = from p in ctx.DataContext.FI_WoffVouch.Where(exp)
                         select FI_WoffVouchFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
