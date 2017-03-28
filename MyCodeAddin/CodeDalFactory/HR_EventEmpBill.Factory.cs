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
	public class HR_EventEmpBillFactory:Common.Business.HR_EventEmpBill
    {
        public static Common.Business.HR_EventEmpBill Fetch(HR_EventEmpBill data)
        {
            Common.Business.HR_EventEmpBill item = (Common.Business.HR_EventEmpBill)Activator.CreateInstance(typeof(Common.Business.HR_EventEmpBill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.BillNo = data.BillNo;
				                item.EmpCode = data.EmpCode;
				                item.FileNo = data.FileNo;
				                item.DText = data.DText;
				                item.GetDate = data.GetDate;
				                item.Appovel = data.Appovel;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EventEmpBill>();
                var i = (from p in ctx.DataContext.HR_EventEmpBill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.BillNo = i.BillNo;
										this.EmpCode = i.EmpCode;
										this.FileNo = i.FileNo;
										this.DText = i.DText;
										this.GetDate = i.GetDate;
										this.Appovel = i.Appovel;
					}
            }
        }
	}

	public class HR_EventEmpBillsFactory : Common.Business.HR_EventEmpBills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EventEmpBill
                        select HR_EventEmpBillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EventEmpBill
                        select HR_EventEmpBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EventEmpBill>();
                var i = (from p in ctx.DataContext.HR_EventEmpBill.Where(exp)
                         select HR_EventEmpBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EventEmpBill>();
                var i = from p in ctx.DataContext.HR_EventEmpBill.Where(exp)
                         select HR_EventEmpBillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
