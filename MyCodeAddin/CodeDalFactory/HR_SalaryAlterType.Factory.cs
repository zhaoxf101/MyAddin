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
	public class HR_SalaryAlterTypeFactory:Common.Business.HR_SalaryAlterType
    {
        public static Common.Business.HR_SalaryAlterType Fetch(HR_SalaryAlterType data)
        {
            Common.Business.HR_SalaryAlterType item = (Common.Business.HR_SalaryAlterType)Activator.CreateInstance(typeof(Common.Business.HR_SalaryAlterType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SalaryAlterType = data.SalaryAlterType;
				                item.DText = data.DText;
				                item.IsConfirmEmp = data.IsConfirmEmp;
				                item.IsConfirmSalary = data.IsConfirmSalary;
				                item.WorkFlowId = data.WorkFlowId;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SalaryAlterType>();
                var i = (from p in ctx.DataContext.HR_SalaryAlterType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SalaryAlterType = i.SalaryAlterType;
										this.DText = i.DText;
										this.IsConfirmEmp = i.IsConfirmEmp;
										this.IsConfirmSalary = i.IsConfirmSalary;
										this.WorkFlowId = i.WorkFlowId;
					}
            }
        }
	}

	public class HR_SalaryAlterTypesFactory : Common.Business.HR_SalaryAlterTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SalaryAlterType
                        select HR_SalaryAlterTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SalaryAlterType
                        select HR_SalaryAlterTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SalaryAlterType>();
                var i = (from p in ctx.DataContext.HR_SalaryAlterType.Where(exp)
                         select HR_SalaryAlterTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SalaryAlterType>();
                var i = from p in ctx.DataContext.HR_SalaryAlterType.Where(exp)
                         select HR_SalaryAlterTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
