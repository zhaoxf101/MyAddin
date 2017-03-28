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
	public class FI_GovPayPlanBillFactory:Common.Business.FI_GovPayPlanBill
    {
        public static Common.Business.FI_GovPayPlanBill Fetch(FI_GovPayPlanBill data)
        {
            Common.Business.FI_GovPayPlanBill item = (Common.Business.FI_GovPayPlanBill)Activator.CreateInstance(typeof(Common.Business.FI_GovPayPlanBill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.BillNo = data.BillNo;
				                item.BusType = data.BusType;
				                item.IncConfTypeCode = data.IncConfTypeCode;
				                item.IsAdj = data.IsAdj;
				                item.RemType = data.RemType;
				                item.BillText = data.BillText;
				                item.IsSubmit = data.IsSubmit;
				                item.Appovel = data.Appovel;
				                item.AccDateTime = data.AccDateTime;
				                item.GenVouX = data.GenVouX;
				                item.VouchNo = data.VouchNo;
				                item.VouchText = data.VouchText;
				                item.Year = data.Year;
				                item.GovPlayCode = data.GovPlayCode;
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
				var exp = lambda.Resolve<FI_GovPayPlanBill>();
                var i = (from p in ctx.DataContext.FI_GovPayPlanBill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.BillNo = i.BillNo;
										this.BusType = i.BusType;
										this.IncConfTypeCode = i.IncConfTypeCode;
										this.IsAdj = i.IsAdj;
										this.RemType = i.RemType;
										this.BillText = i.BillText;
										this.IsSubmit = i.IsSubmit;
										this.Appovel = i.Appovel;
										this.AccDateTime = i.AccDateTime;
										this.GenVouX = i.GenVouX;
										this.VouchNo = i.VouchNo;
										this.VouchText = i.VouchText;
										this.Year = i.Year;
										this.GovPlayCode = i.GovPlayCode;
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

	public class FI_GovPayPlanBillsFactory : Common.Business.FI_GovPayPlanBills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_GovPayPlanBill
                        select FI_GovPayPlanBillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_GovPayPlanBill
                        select FI_GovPayPlanBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_GovPayPlanBill>();
                var i = (from p in ctx.DataContext.FI_GovPayPlanBill.Where(exp)
                         select FI_GovPayPlanBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_GovPayPlanBill>();
                var i = from p in ctx.DataContext.FI_GovPayPlanBill.Where(exp)
                         select FI_GovPayPlanBillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
