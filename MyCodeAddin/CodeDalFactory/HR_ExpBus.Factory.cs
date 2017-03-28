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
	public class HR_ExpBusFactory:Common.Business.HR_ExpBus
    {
        public static Common.Business.HR_ExpBus Fetch(HR_ExpBus data)
        {
            Common.Business.HR_ExpBus item = (Common.Business.HR_ExpBus)Activator.CreateInstance(typeof(Common.Business.HR_ExpBus));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpBusCode = data.ExpBusCode;
				                item.ExpBusText = data.ExpBusText;
				                item.ExpTypeCode = data.ExpTypeCode;
				                item.WorkFlowID = data.WorkFlowID;
				                item.ExpAmt = data.ExpAmt;
				                item.Period = data.Period;
				                item.BarCode = data.BarCode;
				                item.Cancelled = data.Cancelled;
				                item.Approved = data.Approved;
				                item.IsOffset = data.IsOffset;
				                item.IsSubmit = data.IsSubmit;
				                item.Description = data.Description;
				                item.GenVouX = data.GenVouX;
				                item.ExpBusUser = data.ExpBusUser;
				                item.AccDateTime = data.AccDateTime;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.VouchNo = data.VouchNo;
				                item.VouchText = data.VouchText;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.CheckUser = data.CheckUser;
				                item.CheckDate = data.CheckDate;
				                item.ExpStatus = data.ExpStatus;
				                item.EttItemCode = data.EttItemCode;
				                item.AccCode = data.AccCode;
				                item.EndPeriod = data.EndPeriod;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_ExpBus>();
                var i = (from p in ctx.DataContext.HR_ExpBus.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpBusCode = i.ExpBusCode;
										this.ExpBusText = i.ExpBusText;
										this.ExpTypeCode = i.ExpTypeCode;
										this.WorkFlowID = i.WorkFlowID;
										this.ExpAmt = i.ExpAmt;
										this.Period = i.Period;
										this.BarCode = i.BarCode;
										this.Cancelled = i.Cancelled;
										this.Approved = i.Approved;
										this.IsOffset = i.IsOffset;
										this.IsSubmit = i.IsSubmit;
										this.Description = i.Description;
										this.GenVouX = i.GenVouX;
										this.ExpBusUser = i.ExpBusUser;
										this.AccDateTime = i.AccDateTime;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.VouchNo = i.VouchNo;
										this.VouchText = i.VouchText;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.CheckUser = i.CheckUser;
										this.CheckDate = i.CheckDate;
										this.ExpStatus = i.ExpStatus;
										this.EttItemCode = i.EttItemCode;
										this.AccCode = i.AccCode;
										this.EndPeriod = i.EndPeriod;
					}
            }
        }
	}

	public class HR_ExpBussFactory : Common.Business.HR_ExpBuss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_ExpBus
                        select HR_ExpBusFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_ExpBus
                        select HR_ExpBusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_ExpBus>();
                var i = (from p in ctx.DataContext.HR_ExpBus.Where(exp)
                         select HR_ExpBusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_ExpBus>();
                var i = from p in ctx.DataContext.HR_ExpBus.Where(exp)
                         select HR_ExpBusFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
