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
	public class FI_GovPayAllotFactory:Common.Business.FI_GovPayAllot
    {
        public static Common.Business.FI_GovPayAllot Fetch(FI_GovPayAllot data)
        {
            Common.Business.FI_GovPayAllot item = (Common.Business.FI_GovPayAllot)Activator.CreateInstance(typeof(Common.Business.FI_GovPayAllot));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.GovAllotNo = data.GovAllotNo;
				                item.GovAppText = data.GovAppText;
				                item.BusType = data.BusType;
				                item.AllotBusTypeCode = data.AllotBusTypeCode;
				                item.FundCode = data.FundCode;
				                item.Amt = data.Amt;
				                item.IsSubmit = data.IsSubmit;
				                item.Appovel = data.Appovel;
				                item.AccDateTime = data.AccDateTime;
				                item.GenVouX = data.GenVouX;
				                item.RefVouchNo = data.RefVouchNo;
				                item.VouchText = data.VouchText;
				                item.IsDis = data.IsDis;
				                item.AccCode = data.AccCode;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.CheckUser = data.CheckUser;
				                item.CheckDate = data.CheckDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_GovPayAllot>();
                var i = (from p in ctx.DataContext.FI_GovPayAllot.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.GovAllotNo = i.GovAllotNo;
										this.GovAppText = i.GovAppText;
										this.BusType = i.BusType;
										this.AllotBusTypeCode = i.AllotBusTypeCode;
										this.FundCode = i.FundCode;
										this.Amt = i.Amt;
										this.IsSubmit = i.IsSubmit;
										this.Appovel = i.Appovel;
										this.AccDateTime = i.AccDateTime;
										this.GenVouX = i.GenVouX;
										this.RefVouchNo = i.RefVouchNo;
										this.VouchText = i.VouchText;
										this.IsDis = i.IsDis;
										this.AccCode = i.AccCode;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.CheckUser = i.CheckUser;
										this.CheckDate = i.CheckDate;
					}
            }
        }
	}

	public class FI_GovPayAllotsFactory : Common.Business.FI_GovPayAllots
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_GovPayAllot
                        select FI_GovPayAllotFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_GovPayAllot
                        select FI_GovPayAllotFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_GovPayAllot>();
                var i = (from p in ctx.DataContext.FI_GovPayAllot.Where(exp)
                         select FI_GovPayAllotFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_GovPayAllot>();
                var i = from p in ctx.DataContext.FI_GovPayAllot.Where(exp)
                         select FI_GovPayAllotFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
