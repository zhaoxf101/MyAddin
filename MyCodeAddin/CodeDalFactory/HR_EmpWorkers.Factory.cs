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
	public class HR_EmpWorkersFactory:Common.Business.HR_EmpWorkers
    {
        public static Common.Business.HR_EmpWorkers Fetch(HR_EmpWorkers data)
        {
            Common.Business.HR_EmpWorkers item = (Common.Business.HR_EmpWorkers)Activator.CreateInstance(typeof(Common.Business.HR_EmpWorkers));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Id = data.Id;
				                item.Client = data.Client;
				                item.EmpCode = data.EmpCode;
				                item.WorkersCode = data.WorkersCode;
				                item.PositionLevell = data.PositionLevell;
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
				var exp = lambda.Resolve<HR_EmpWorkers>();
                var i = (from p in ctx.DataContext.HR_EmpWorkers.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Id = i.Id;
										this.Client = i.Client;
										this.EmpCode = i.EmpCode;
										this.WorkersCode = i.WorkersCode;
										this.PositionLevell = i.PositionLevell;
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

	public class HR_EmpWorkerssFactory : Common.Business.HR_EmpWorkerss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpWorkers
                        select HR_EmpWorkersFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpWorkers
                        select HR_EmpWorkersFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpWorkers>();
                var i = (from p in ctx.DataContext.HR_EmpWorkers.Where(exp)
                         select HR_EmpWorkersFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpWorkers>();
                var i = from p in ctx.DataContext.HR_EmpWorkers.Where(exp)
                         select HR_EmpWorkersFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
