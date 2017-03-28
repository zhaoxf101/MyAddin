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
	public class HR_EmpBusFactory:Common.Business.HR_EmpBus
    {
        public static Common.Business.HR_EmpBus Fetch(HR_EmpBus data)
        {
            Common.Business.HR_EmpBus item = (Common.Business.HR_EmpBus)Activator.CreateInstance(typeof(Common.Business.HR_EmpBus));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.EmpBusNo = data.EmpBusNo;
				                item.EmpBusText = data.EmpBusText;
				                item.FileNo = data.FileNo;
				                item.EmpEvent = data.EmpEvent;
				                item.WorkFowId = data.WorkFowId;
				                item.EmpCode = data.EmpCode;
				                item.BarCode = data.BarCode;
				                item.StartDate = data.StartDate;
				                item.ContractNo = data.ContractNo;
				                item.Memo = data.Memo;
				                item.IsBatch = data.IsBatch;
				                item.IsSubmit = data.IsSubmit;
				                item.IsAppoved = data.IsAppoved;
				                item.IsConfirmSalary = data.IsConfirmSalary;
				                item.SalaryAlterNo = data.SalaryAlterNo;
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
				var exp = lambda.Resolve<HR_EmpBus>();
                var i = (from p in ctx.DataContext.HR_EmpBus.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.EmpBusNo = i.EmpBusNo;
										this.EmpBusText = i.EmpBusText;
										this.FileNo = i.FileNo;
										this.EmpEvent = i.EmpEvent;
										this.WorkFowId = i.WorkFowId;
										this.EmpCode = i.EmpCode;
										this.BarCode = i.BarCode;
										this.StartDate = i.StartDate;
										this.ContractNo = i.ContractNo;
										this.Memo = i.Memo;
										this.IsBatch = i.IsBatch;
										this.IsSubmit = i.IsSubmit;
										this.IsAppoved = i.IsAppoved;
										this.IsConfirmSalary = i.IsConfirmSalary;
										this.SalaryAlterNo = i.SalaryAlterNo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class HR_EmpBussFactory : Common.Business.HR_EmpBuss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpBus
                        select HR_EmpBusFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpBus
                        select HR_EmpBusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpBus>();
                var i = (from p in ctx.DataContext.HR_EmpBus.Where(exp)
                         select HR_EmpBusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpBus>();
                var i = from p in ctx.DataContext.HR_EmpBus.Where(exp)
                         select HR_EmpBusFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
