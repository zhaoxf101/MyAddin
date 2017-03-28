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
	public class PM_BudIncBillFactory:Common.Business.PM_BudIncBill
    {
        public static Common.Business.PM_BudIncBill Fetch(PM_BudIncBill data)
        {
            Common.Business.PM_BudIncBill item = (Common.Business.PM_BudIncBill)Activator.CreateInstance(typeof(Common.Business.PM_BudIncBill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.AppNo = data.AppNo;
				                item.Client = data.Client;
				                item.Year = data.Year;
				                item.BudBusCode = data.BudBusCode;
				                item.DepCode = data.DepCode;
				                item.Memo = data.Memo;
				                item.IsAppr = data.IsAppr;
				                item.IsCheck = data.IsCheck;
				                item.Cancelled = data.Cancelled;
				                item.Approved = data.Approved;
				                item.ObjectId = data.ObjectId;
				                item.WorkflowId = data.WorkflowId;
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
				var exp = lambda.Resolve<PM_BudIncBill>();
                var i = (from p in ctx.DataContext.PM_BudIncBill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.AppNo = i.AppNo;
										this.Client = i.Client;
										this.Year = i.Year;
										this.BudBusCode = i.BudBusCode;
										this.DepCode = i.DepCode;
										this.Memo = i.Memo;
										this.IsAppr = i.IsAppr;
										this.IsCheck = i.IsCheck;
										this.Cancelled = i.Cancelled;
										this.Approved = i.Approved;
										this.ObjectId = i.ObjectId;
										this.WorkflowId = i.WorkflowId;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_BudIncBillsFactory : Common.Business.PM_BudIncBills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_BudIncBill
                        select PM_BudIncBillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_BudIncBill
                        select PM_BudIncBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_BudIncBill>();
                var i = (from p in ctx.DataContext.PM_BudIncBill.Where(exp)
                         select PM_BudIncBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_BudIncBill>();
                var i = from p in ctx.DataContext.PM_BudIncBill.Where(exp)
                         select PM_BudIncBillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
