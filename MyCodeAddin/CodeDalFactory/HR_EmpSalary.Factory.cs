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
	public class HR_EmpSalaryFactory:Common.Business.HR_EmpSalary
    {
        public static Common.Business.HR_EmpSalary Fetch(HR_EmpSalary data)
        {
            Common.Business.HR_EmpSalary item = (Common.Business.HR_EmpSalary)Activator.CreateInstance(typeof(Common.Business.HR_EmpSalary));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ID = data.ID;
				                item.Client = data.Client;
				                item.EmpCode = data.EmpCode;
				                item.IsSalary = data.IsSalary;
				                item.IsInsReturn = data.IsInsReturn;
				                item.IsSalReturn = data.IsSalReturn;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.IsDel = data.IsDel;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpSalary>();
                var i = (from p in ctx.DataContext.HR_EmpSalary.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ID = i.ID;
										this.Client = i.Client;
										this.EmpCode = i.EmpCode;
										this.IsSalary = i.IsSalary;
										this.IsInsReturn = i.IsInsReturn;
										this.IsSalReturn = i.IsSalReturn;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.IsDel = i.IsDel;
					}
            }
        }
	}

	public class HR_EmpSalarysFactory : Common.Business.HR_EmpSalarys
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpSalary
                        select HR_EmpSalaryFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpSalary
                        select HR_EmpSalaryFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpSalary>();
                var i = (from p in ctx.DataContext.HR_EmpSalary.Where(exp)
                         select HR_EmpSalaryFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpSalary>();
                var i = from p in ctx.DataContext.HR_EmpSalary.Where(exp)
                         select HR_EmpSalaryFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
