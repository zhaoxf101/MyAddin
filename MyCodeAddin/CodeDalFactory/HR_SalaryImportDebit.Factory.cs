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
	public class HR_SalaryImportDebitFactory:Common.Business.HR_SalaryImportDebit
    {
        public static Common.Business.HR_SalaryImportDebit Fetch(HR_SalaryImportDebit data)
        {
            Common.Business.HR_SalaryImportDebit item = (Common.Business.HR_SalaryImportDebit)Activator.CreateInstance(typeof(Common.Business.HR_SalaryImportDebit));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SalaryCode = data.SalaryCode;
				                item.PersonId = data.PersonId;
				                item.DebitItemCode = data.DebitItemCode;
				                item.DebitItemName = data.DebitItemName;
				                item.DetbitAmt = data.DetbitAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SalaryImportDebit>();
                var i = (from p in ctx.DataContext.HR_SalaryImportDebit.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SalaryCode = i.SalaryCode;
										this.PersonId = i.PersonId;
										this.DebitItemCode = i.DebitItemCode;
										this.DebitItemName = i.DebitItemName;
										this.DetbitAmt = i.DetbitAmt;
					}
            }
        }
	}

	public class HR_SalaryImportDebitsFactory : Common.Business.HR_SalaryImportDebits
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SalaryImportDebit
                        select HR_SalaryImportDebitFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SalaryImportDebit
                        select HR_SalaryImportDebitFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SalaryImportDebit>();
                var i = (from p in ctx.DataContext.HR_SalaryImportDebit.Where(exp)
                         select HR_SalaryImportDebitFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SalaryImportDebit>();
                var i = from p in ctx.DataContext.HR_SalaryImportDebit.Where(exp)
                         select HR_SalaryImportDebitFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
