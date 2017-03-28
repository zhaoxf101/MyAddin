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
	public class HR_SalaryAlterFactory:Common.Business.HR_SalaryAlter
    {
        public static Common.Business.HR_SalaryAlter Fetch(HR_SalaryAlter data)
        {
            Common.Business.HR_SalaryAlter item = (Common.Business.HR_SalaryAlter)Activator.CreateInstance(typeof(Common.Business.HR_SalaryAlter));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SalaryAlterNo = data.SalaryAlterNo;
				                item.SalaryAlterType = data.SalaryAlterType;
				                item.DText = data.DText;
				                item.FileNo = data.FileNo;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.WorkFlowId = data.WorkFlowId;
				                item.IsSubmit = data.IsSubmit;
				                item.IsConfirmEmp = data.IsConfirmEmp;
				                item.EmpCode = data.EmpCode;
				                item.IsConfirmSalary = data.IsConfirmSalary;
				                item.SalaryItemCode = data.SalaryItemCode;
				                item.IsStop = data.IsStop;
				                item.IsAppoved = data.IsAppoved;
				                item.IsBatch = data.IsBatch;
				                item.EmpBusNo = data.EmpBusNo;
				                item.BarCode = data.BarCode;
				                item.SalaryRange = data.SalaryRange;
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
				var exp = lambda.Resolve<HR_SalaryAlter>();
                var i = (from p in ctx.DataContext.HR_SalaryAlter.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SalaryAlterNo = i.SalaryAlterNo;
										this.SalaryAlterType = i.SalaryAlterType;
										this.DText = i.DText;
										this.FileNo = i.FileNo;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.WorkFlowId = i.WorkFlowId;
										this.IsSubmit = i.IsSubmit;
										this.IsConfirmEmp = i.IsConfirmEmp;
										this.EmpCode = i.EmpCode;
										this.IsConfirmSalary = i.IsConfirmSalary;
										this.SalaryItemCode = i.SalaryItemCode;
										this.IsStop = i.IsStop;
										this.IsAppoved = i.IsAppoved;
										this.IsBatch = i.IsBatch;
										this.EmpBusNo = i.EmpBusNo;
										this.BarCode = i.BarCode;
										this.SalaryRange = i.SalaryRange;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class HR_SalaryAltersFactory : Common.Business.HR_SalaryAlters
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SalaryAlter
                        select HR_SalaryAlterFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SalaryAlter
                        select HR_SalaryAlterFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SalaryAlter>();
                var i = (from p in ctx.DataContext.HR_SalaryAlter.Where(exp)
                         select HR_SalaryAlterFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SalaryAlter>();
                var i = from p in ctx.DataContext.HR_SalaryAlter.Where(exp)
                         select HR_SalaryAlterFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
