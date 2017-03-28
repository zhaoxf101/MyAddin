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
	public class HR_SalaryImportFactory:Common.Business.HR_SalaryImport
    {
        public static Common.Business.HR_SalaryImport Fetch(HR_SalaryImport data)
        {
            Common.Business.HR_SalaryImport item = (Common.Business.HR_SalaryImport)Activator.CreateInstance(typeof(Common.Business.HR_SalaryImport));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SalaryCode = data.SalaryCode;
				                item.Period = data.Period;
				                item.ModeCode = data.ModeCode;
				                item.Memo = data.Memo;
				                item.ProjCode = data.ProjCode;
				                item.IsApprove = data.IsApprove;
				                item.IsConf = data.IsConf;
				                item.BillNo = data.BillNo;
				                item.IsHaveTax = data.IsHaveTax;
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
				var exp = lambda.Resolve<HR_SalaryImport>();
                var i = (from p in ctx.DataContext.HR_SalaryImport.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SalaryCode = i.SalaryCode;
										this.Period = i.Period;
										this.ModeCode = i.ModeCode;
										this.Memo = i.Memo;
										this.ProjCode = i.ProjCode;
										this.IsApprove = i.IsApprove;
										this.IsConf = i.IsConf;
										this.BillNo = i.BillNo;
										this.IsHaveTax = i.IsHaveTax;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class HR_SalaryImportsFactory : Common.Business.HR_SalaryImports
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SalaryImport
                        select HR_SalaryImportFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SalaryImport
                        select HR_SalaryImportFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SalaryImport>();
                var i = (from p in ctx.DataContext.HR_SalaryImport.Where(exp)
                         select HR_SalaryImportFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SalaryImport>();
                var i = from p in ctx.DataContext.HR_SalaryImport.Where(exp)
                         select HR_SalaryImportFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
