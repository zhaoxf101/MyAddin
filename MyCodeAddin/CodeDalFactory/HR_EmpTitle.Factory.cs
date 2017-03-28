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
	public class HR_EmpTitleFactory:Common.Business.HR_EmpTitle
    {
        public static Common.Business.HR_EmpTitle Fetch(HR_EmpTitle data)
        {
            Common.Business.HR_EmpTitle item = (Common.Business.HR_EmpTitle)Activator.CreateInstance(typeof(Common.Business.HR_EmpTitle));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Id = data.Id;
				                item.Client = data.Client;
				                item.EmpCode = data.EmpCode;
				                item.TitleCode = data.TitleCode;
				                item.SalaryLevel = data.SalaryLevel;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.RowStatus = data.RowStatus;
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
				var exp = lambda.Resolve<HR_EmpTitle>();
                var i = (from p in ctx.DataContext.HR_EmpTitle.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Id = i.Id;
										this.Client = i.Client;
										this.EmpCode = i.EmpCode;
										this.TitleCode = i.TitleCode;
										this.SalaryLevel = i.SalaryLevel;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.RowStatus = i.RowStatus;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class HR_EmpTitlesFactory : Common.Business.HR_EmpTitles
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpTitle
                        select HR_EmpTitleFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpTitle
                        select HR_EmpTitleFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpTitle>();
                var i = (from p in ctx.DataContext.HR_EmpTitle.Where(exp)
                         select HR_EmpTitleFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpTitle>();
                var i = from p in ctx.DataContext.HR_EmpTitle.Where(exp)
                         select HR_EmpTitleFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
