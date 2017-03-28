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
	public class HR_EmpStatusFactory:Common.Business.HR_EmpStatus
    {
        public static Common.Business.HR_EmpStatus Fetch(HR_EmpStatus data)
        {
            Common.Business.HR_EmpStatus item = (Common.Business.HR_EmpStatus)Activator.CreateInstance(typeof(Common.Business.HR_EmpStatus));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.EmpStatusCode = data.EmpStatusCode;
				                item.EmpStatusName = data.EmpStatusName;
				                item.Memo = data.Memo;
				                item.IsFreeTax = data.IsFreeTax;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpStatus>();
                var i = (from p in ctx.DataContext.HR_EmpStatus.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.EmpStatusCode = i.EmpStatusCode;
										this.EmpStatusName = i.EmpStatusName;
										this.Memo = i.Memo;
										this.IsFreeTax = i.IsFreeTax;
					}
            }
        }
	}

	public class HR_EmpStatussFactory : Common.Business.HR_EmpStatuss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpStatus
                        select HR_EmpStatusFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpStatus
                        select HR_EmpStatusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpStatus>();
                var i = (from p in ctx.DataContext.HR_EmpStatus.Where(exp)
                         select HR_EmpStatusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpStatus>();
                var i = from p in ctx.DataContext.HR_EmpStatus.Where(exp)
                         select HR_EmpStatusFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
