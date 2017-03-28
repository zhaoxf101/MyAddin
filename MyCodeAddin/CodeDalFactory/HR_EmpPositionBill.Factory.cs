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
	public class HR_EmpPositionBillFactory:Common.Business.HR_EmpPositionBill
    {
        public static Common.Business.HR_EmpPositionBill Fetch(HR_EmpPositionBill data)
        {
            Common.Business.HR_EmpPositionBill item = (Common.Business.HR_EmpPositionBill)Activator.CreateInstance(typeof(Common.Business.HR_EmpPositionBill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ID = data.ID;
				                item.Client = data.Client;
				                item.BillNo = data.BillNo;
				                item.EmpCode = data.EmpCode;
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
				var exp = lambda.Resolve<HR_EmpPositionBill>();
                var i = (from p in ctx.DataContext.HR_EmpPositionBill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ID = i.ID;
										this.Client = i.Client;
										this.BillNo = i.BillNo;
										this.EmpCode = i.EmpCode;
										this.PositionCode = i.PositionCode;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.OldID = i.OldID;
					}
            }
        }
	}

	public class HR_EmpPositionBillsFactory : Common.Business.HR_EmpPositionBills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpPositionBill
                        select HR_EmpPositionBillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpPositionBill
                        select HR_EmpPositionBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpPositionBill>();
                var i = (from p in ctx.DataContext.HR_EmpPositionBill.Where(exp)
                         select HR_EmpPositionBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpPositionBill>();
                var i = from p in ctx.DataContext.HR_EmpPositionBill.Where(exp)
                         select HR_EmpPositionBillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
