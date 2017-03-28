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
	public class HR_EmpSalaryItemFactory:Common.Business.HR_EmpSalaryItem
    {
        public static Common.Business.HR_EmpSalaryItem Fetch(HR_EmpSalaryItem data)
        {
            Common.Business.HR_EmpSalaryItem item = (Common.Business.HR_EmpSalaryItem)Activator.CreateInstance(typeof(Common.Business.HR_EmpSalaryItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.SalaryRange = data.SalaryRange;
				                item.EmpCode = data.EmpCode;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.SalaryItemCode = data.SalaryItemCode;
				                item.Amt = data.Amt;
				                item.Memo = data.Memo;
				                item.RowStatus = data.RowStatus;
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
				var exp = lambda.Resolve<HR_EmpSalaryItem>();
                var i = (from p in ctx.DataContext.HR_EmpSalaryItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.SalaryRange = i.SalaryRange;
										this.EmpCode = i.EmpCode;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.SalaryItemCode = i.SalaryItemCode;
										this.Amt = i.Amt;
										this.Memo = i.Memo;
										this.RowStatus = i.RowStatus;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class HR_EmpSalaryItemsFactory : Common.Business.HR_EmpSalaryItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpSalaryItem
                        select HR_EmpSalaryItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpSalaryItem
                        select HR_EmpSalaryItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpSalaryItem>();
                var i = (from p in ctx.DataContext.HR_EmpSalaryItem.Where(exp)
                         select HR_EmpSalaryItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpSalaryItem>();
                var i = from p in ctx.DataContext.HR_EmpSalaryItem.Where(exp)
                         select HR_EmpSalaryItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
