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
	public class HR_EventBillFactory:Common.Business.HR_EventBill
    {
        public static Common.Business.HR_EventBill Fetch(HR_EventBill data)
        {
            Common.Business.HR_EventBill item = (Common.Business.HR_EventBill)Activator.CreateInstance(typeof(Common.Business.HR_EventBill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.BillNo = data.BillNo;
				                item.EventCode = data.EventCode;
				                item.BillText = data.BillText;
				                item.FileNo = data.FileNo;
				                item.StartDate = data.StartDate;
				                item.EmpCode = data.EmpCode;
				                item.Memo = data.Memo;
				                item.IsBatch = data.IsBatch;
				                item.IsSubmit = data.IsSubmit;
				                item.Appovel = data.Appovel;
				                item.CreateDate = data.CreateDate;
				                item.CreateUser = data.CreateUser;
				                item.ChangeDate = data.ChangeDate;
				                item.ChangeUser = data.ChangeUser;
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
				var exp = lambda.Resolve<HR_EventBill>();
                var i = (from p in ctx.DataContext.HR_EventBill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.BillNo = i.BillNo;
										this.EventCode = i.EventCode;
										this.BillText = i.BillText;
										this.FileNo = i.FileNo;
										this.StartDate = i.StartDate;
										this.EmpCode = i.EmpCode;
										this.Memo = i.Memo;
										this.IsBatch = i.IsBatch;
										this.IsSubmit = i.IsSubmit;
										this.Appovel = i.Appovel;
										this.CreateDate = i.CreateDate;
										this.CreateUser = i.CreateUser;
										this.ChangeDate = i.ChangeDate;
										this.ChangeUser = i.ChangeUser;
										this.CheckUser = i.CheckUser;
										this.CheckDate = i.CheckDate;
					}
            }
        }
	}

	public class HR_EventBillsFactory : Common.Business.HR_EventBills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EventBill
                        select HR_EventBillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EventBill
                        select HR_EventBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EventBill>();
                var i = (from p in ctx.DataContext.HR_EventBill.Where(exp)
                         select HR_EventBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EventBill>();
                var i = from p in ctx.DataContext.HR_EventBill.Where(exp)
                         select HR_EventBillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
