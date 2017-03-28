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
	public class HR_SalaryAlterSubFactory:Common.Business.HR_SalaryAlterSub
    {
        public static Common.Business.HR_SalaryAlterSub Fetch(HR_SalaryAlterSub data)
        {
            Common.Business.HR_SalaryAlterSub item = (Common.Business.HR_SalaryAlterSub)Activator.CreateInstance(typeof(Common.Business.HR_SalaryAlterSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.SalaryAlterNo = data.SalaryAlterNo;
				                item.EmpCode = data.EmpCode;
				                item.SalaryItemCode = data.SalaryItemCode;
				                item.Amt = data.Amt;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.Memo = data.Memo;
				                item.OldId = data.OldId;
				                item.ActionType = data.ActionType;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SalaryAlterSub>();
                var i = (from p in ctx.DataContext.HR_SalaryAlterSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.SalaryAlterNo = i.SalaryAlterNo;
										this.EmpCode = i.EmpCode;
										this.SalaryItemCode = i.SalaryItemCode;
										this.Amt = i.Amt;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.Memo = i.Memo;
										this.OldId = i.OldId;
										this.ActionType = i.ActionType;
					}
            }
        }
	}

	public class HR_SalaryAlterSubsFactory : Common.Business.HR_SalaryAlterSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SalaryAlterSub
                        select HR_SalaryAlterSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SalaryAlterSub
                        select HR_SalaryAlterSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SalaryAlterSub>();
                var i = (from p in ctx.DataContext.HR_SalaryAlterSub.Where(exp)
                         select HR_SalaryAlterSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SalaryAlterSub>();
                var i = from p in ctx.DataContext.HR_SalaryAlterSub.Where(exp)
                         select HR_SalaryAlterSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
