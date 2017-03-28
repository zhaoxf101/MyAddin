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
	public class HR_EmpStatusBillFactory:Common.Business.HR_EmpStatusBill
    {
        public static Common.Business.HR_EmpStatusBill Fetch(HR_EmpStatusBill data)
        {
            Common.Business.HR_EmpStatusBill item = (Common.Business.HR_EmpStatusBill)Activator.CreateInstance(typeof(Common.Business.HR_EmpStatusBill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ID = data.ID;
				                item.Client = data.Client;
				                item.BillNo = data.BillNo;
				                item.EmpCode = data.EmpCode;
				                item.StatusCode = data.StatusCode;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.OldId = data.OldId;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpStatusBill>();
                var i = (from p in ctx.DataContext.HR_EmpStatusBill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ID = i.ID;
										this.Client = i.Client;
										this.BillNo = i.BillNo;
										this.EmpCode = i.EmpCode;
										this.StatusCode = i.StatusCode;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.OldId = i.OldId;
					}
            }
        }
	}

	public class HR_EmpStatusBillsFactory : Common.Business.HR_EmpStatusBills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpStatusBill
                        select HR_EmpStatusBillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpStatusBill
                        select HR_EmpStatusBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpStatusBill>();
                var i = (from p in ctx.DataContext.HR_EmpStatusBill.Where(exp)
                         select HR_EmpStatusBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpStatusBill>();
                var i = from p in ctx.DataContext.HR_EmpStatusBill.Where(exp)
                         select HR_EmpStatusBillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
