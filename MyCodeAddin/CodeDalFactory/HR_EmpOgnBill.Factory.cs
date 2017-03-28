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
	public class HR_EmpOgnBillFactory:Common.Business.HR_EmpOgnBill
    {
        public static Common.Business.HR_EmpOgnBill Fetch(HR_EmpOgnBill data)
        {
            Common.Business.HR_EmpOgnBill item = (Common.Business.HR_EmpOgnBill)Activator.CreateInstance(typeof(Common.Business.HR_EmpOgnBill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ID = data.ID;
				                item.Client = data.Client;
				                item.BillNo = data.BillNo;
				                item.EmpCode = data.EmpCode;
				                item.DepCode = data.DepCode;
				                item.PositionCode = data.PositionCode;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.OldID = data.OldID;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpOgnBill>();
                var i = (from p in ctx.DataContext.HR_EmpOgnBill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ID = i.ID;
										this.Client = i.Client;
										this.BillNo = i.BillNo;
										this.EmpCode = i.EmpCode;
										this.DepCode = i.DepCode;
										this.PositionCode = i.PositionCode;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.OldID = i.OldID;
					}
            }
        }
	}

	public class HR_EmpOgnBillsFactory : Common.Business.HR_EmpOgnBills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpOgnBill
                        select HR_EmpOgnBillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpOgnBill
                        select HR_EmpOgnBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpOgnBill>();
                var i = (from p in ctx.DataContext.HR_EmpOgnBill.Where(exp)
                         select HR_EmpOgnBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpOgnBill>();
                var i = from p in ctx.DataContext.HR_EmpOgnBill.Where(exp)
                         select HR_EmpOgnBillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
