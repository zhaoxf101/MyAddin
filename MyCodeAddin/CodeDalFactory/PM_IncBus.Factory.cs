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
	public class PM_IncBusFactory:Common.Business.PM_IncBus
    {
        public static Common.Business.PM_IncBus Fetch(PM_IncBus data)
        {
            Common.Business.PM_IncBus item = (Common.Business.PM_IncBus)Activator.CreateInstance(typeof(Common.Business.PM_IncBus));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.IncBusCode = data.IncBusCode;
				                item.IncItemCode = data.IncItemCode;
				                item.BillTypeCode = data.BillTypeCode;
				                item.IncAmt = data.IncAmt;
				                item.ActAmt = data.ActAmt;
				                item.Description = data.Description;
				                item.EmpCode = data.EmpCode;
				                item.IsAuto = data.IsAuto;
				                item.WorkFlowID = data.WorkFlowID;
				                item.Cancelled = data.Cancelled;
				                item.Approved = data.Approved;
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
				var exp = lambda.Resolve<PM_IncBus>();
                var i = (from p in ctx.DataContext.PM_IncBus.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.IncBusCode = i.IncBusCode;
										this.IncItemCode = i.IncItemCode;
										this.BillTypeCode = i.BillTypeCode;
										this.IncAmt = i.IncAmt;
										this.ActAmt = i.ActAmt;
										this.Description = i.Description;
										this.EmpCode = i.EmpCode;
										this.IsAuto = i.IsAuto;
										this.WorkFlowID = i.WorkFlowID;
										this.Cancelled = i.Cancelled;
										this.Approved = i.Approved;
										this.TimeStamp = i.TimeStamp;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_IncBussFactory : Common.Business.PM_IncBuss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_IncBus
                        select PM_IncBusFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_IncBus
                        select PM_IncBusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_IncBus>();
                var i = (from p in ctx.DataContext.PM_IncBus.Where(exp)
                         select PM_IncBusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_IncBus>();
                var i = from p in ctx.DataContext.PM_IncBus.Where(exp)
                         select PM_IncBusFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
