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
	public class HR_EmpBusPostFactory:Common.Business.HR_EmpBusPost
    {
        public static Common.Business.HR_EmpBusPost Fetch(HR_EmpBusPost data)
        {
            Common.Business.HR_EmpBusPost item = (Common.Business.HR_EmpBusPost)Activator.CreateInstance(typeof(Common.Business.HR_EmpBusPost));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.EmpBusNo = data.EmpBusNo;
				                item.EmpCode = data.EmpCode;
				                item.PostCode = data.PostCode;
				                item.SalaryLevel = data.SalaryLevel;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.ActionType = data.ActionType;
				                item.OldId = data.OldId;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpBusPost>();
                var i = (from p in ctx.DataContext.HR_EmpBusPost.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.EmpBusNo = i.EmpBusNo;
										this.EmpCode = i.EmpCode;
										this.PostCode = i.PostCode;
										this.SalaryLevel = i.SalaryLevel;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.ActionType = i.ActionType;
										this.OldId = i.OldId;
					}
            }
        }
	}

	public class HR_EmpBusPostsFactory : Common.Business.HR_EmpBusPosts
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpBusPost
                        select HR_EmpBusPostFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpBusPost
                        select HR_EmpBusPostFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpBusPost>();
                var i = (from p in ctx.DataContext.HR_EmpBusPost.Where(exp)
                         select HR_EmpBusPostFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpBusPost>();
                var i = from p in ctx.DataContext.HR_EmpBusPost.Where(exp)
                         select HR_EmpBusPostFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
