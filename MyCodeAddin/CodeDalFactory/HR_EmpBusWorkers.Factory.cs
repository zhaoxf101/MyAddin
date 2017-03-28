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
	public class HR_EmpBusWorkersFactory:Common.Business.HR_EmpBusWorkers
    {
        public static Common.Business.HR_EmpBusWorkers Fetch(HR_EmpBusWorkers data)
        {
            Common.Business.HR_EmpBusWorkers item = (Common.Business.HR_EmpBusWorkers)Activator.CreateInstance(typeof(Common.Business.HR_EmpBusWorkers));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Id = data.Id;
				                item.Client = data.Client;
				                item.EmpBusNo = data.EmpBusNo;
				                item.EmpCode = data.EmpCode;
				                item.WorkersCode = data.WorkersCode;
				                item.PositionLevel = data.PositionLevel;
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
				var exp = lambda.Resolve<HR_EmpBusWorkers>();
                var i = (from p in ctx.DataContext.HR_EmpBusWorkers.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Id = i.Id;
										this.Client = i.Client;
										this.EmpBusNo = i.EmpBusNo;
										this.EmpCode = i.EmpCode;
										this.WorkersCode = i.WorkersCode;
										this.PositionLevel = i.PositionLevel;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.ActionType = i.ActionType;
										this.OldId = i.OldId;
					}
            }
        }
	}

	public class HR_EmpBusWorkerssFactory : Common.Business.HR_EmpBusWorkerss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpBusWorkers
                        select HR_EmpBusWorkersFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpBusWorkers
                        select HR_EmpBusWorkersFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpBusWorkers>();
                var i = (from p in ctx.DataContext.HR_EmpBusWorkers.Where(exp)
                         select HR_EmpBusWorkersFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpBusWorkers>();
                var i = from p in ctx.DataContext.HR_EmpBusWorkers.Where(exp)
                         select HR_EmpBusWorkersFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
