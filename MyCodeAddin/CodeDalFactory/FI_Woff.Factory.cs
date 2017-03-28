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
	public class FI_WoffFactory:Common.Business.FI_Woff
    {
        public static Common.Business.FI_Woff Fetch(FI_Woff data)
        {
            Common.Business.FI_Woff item = (Common.Business.FI_Woff)Activator.CreateInstance(typeof(Common.Business.FI_Woff));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.WoffCode = data.WoffCode;
				                item.WoffName = data.WoffName;
				                item.ProjCode = data.ProjCode;
				                item.BusType = data.BusType;
				                item.AccType = data.AccType;
				                item.BarCode = data.BarCode;
				                item.WoffAmt = data.WoffAmt;
				                item.WoffActAmt = data.WoffActAmt;
				                item.BankAmt = data.BankAmt;
				                item.WoffUser = data.WoffUser;
				                item.WorkFlowId = data.WorkFlowId;
				                item.Description = data.Description;
				                item.AccDateTime = data.AccDateTime;
				                item.GenVouX = data.GenVouX;
				                item.VouchNo = data.VouchNo;
				                item.VouchText = data.VouchText;
				                item.IsAccVou = data.IsAccVou;
				                item.Cancelled = data.Cancelled;
				                item.Approved = data.Approved;
				                item.IsSubmit = data.IsSubmit;
				                item.IsDetails = data.IsDetails;
				                item.TimeStamp = data.TimeStamp;
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
				var exp = lambda.Resolve<FI_Woff>();
                var i = (from p in ctx.DataContext.FI_Woff.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.WoffCode = i.WoffCode;
										this.WoffName = i.WoffName;
										this.ProjCode = i.ProjCode;
										this.BusType = i.BusType;
										this.AccType = i.AccType;
										this.BarCode = i.BarCode;
										this.WoffAmt = i.WoffAmt;
										this.WoffActAmt = i.WoffActAmt;
										this.BankAmt = i.BankAmt;
										this.WoffUser = i.WoffUser;
										this.WorkFlowId = i.WorkFlowId;
										this.Description = i.Description;
										this.AccDateTime = i.AccDateTime;
										this.GenVouX = i.GenVouX;
										this.VouchNo = i.VouchNo;
										this.VouchText = i.VouchText;
										this.IsAccVou = i.IsAccVou;
										this.Cancelled = i.Cancelled;
										this.Approved = i.Approved;
										this.IsSubmit = i.IsSubmit;
										this.IsDetails = i.IsDetails;
										this.TimeStamp = i.TimeStamp;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_WoffsFactory : Common.Business.FI_Woffs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_Woff
                        select FI_WoffFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_Woff
                        select FI_WoffFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_Woff>();
                var i = (from p in ctx.DataContext.FI_Woff.Where(exp)
                         select FI_WoffFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_Woff>();
                var i = from p in ctx.DataContext.FI_Woff.Where(exp)
                         select FI_WoffFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
