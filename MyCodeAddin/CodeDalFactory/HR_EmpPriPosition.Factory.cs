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
	public class HR_EmpPriPositionFactory:Common.Business.HR_EmpPriPosition
    {
        public static Common.Business.HR_EmpPriPosition Fetch(HR_EmpPriPosition data)
        {
            Common.Business.HR_EmpPriPosition item = (Common.Business.HR_EmpPriPosition)Activator.CreateInstance(typeof(Common.Business.HR_EmpPriPosition));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.EmpCode = data.EmpCode;
				                item.PositionCode = data.PositionCode;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.DepCode = data.DepCode;
				                item.EmpStatusCode = data.EmpStatusCode;
				                item.CostCtr = data.CostCtr;
				                item.ProfitCtr = data.ProfitCtr;
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
				var exp = lambda.Resolve<HR_EmpPriPosition>();
                var i = (from p in ctx.DataContext.HR_EmpPriPosition.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.EmpCode = i.EmpCode;
										this.PositionCode = i.PositionCode;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.DepCode = i.DepCode;
										this.EmpStatusCode = i.EmpStatusCode;
										this.CostCtr = i.CostCtr;
										this.ProfitCtr = i.ProfitCtr;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class HR_EmpPriPositionsFactory : Common.Business.HR_EmpPriPositions
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpPriPosition
                        select HR_EmpPriPositionFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpPriPosition
                        select HR_EmpPriPositionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpPriPosition>();
                var i = (from p in ctx.DataContext.HR_EmpPriPosition.Where(exp)
                         select HR_EmpPriPositionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpPriPosition>();
                var i = from p in ctx.DataContext.HR_EmpPriPosition.Where(exp)
                         select HR_EmpPriPositionFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
