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
	public class HR_PositionFactory:Common.Business.HR_Position
    {
        public static Common.Business.HR_Position Fetch(HR_Position data)
        {
            Common.Business.HR_Position item = (Common.Business.HR_Position)Activator.CreateInstance(typeof(Common.Business.HR_Position));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.PositionCode = data.PositionCode;
				                item.PositionName = data.PositionName;
				                item.DepCode = data.DepCode;
				                item.JobCode = data.JobCode;
				                item.CostCtr = data.CostCtr;
				                item.ProfitCtr = data.ProfitCtr;
				                item.Memo = data.Memo;
				                item.Active = data.Active;
				                item.IsDel = data.IsDel;
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
				var exp = lambda.Resolve<HR_Position>();
                var i = (from p in ctx.DataContext.HR_Position.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.PositionCode = i.PositionCode;
										this.PositionName = i.PositionName;
										this.DepCode = i.DepCode;
										this.JobCode = i.JobCode;
										this.CostCtr = i.CostCtr;
										this.ProfitCtr = i.ProfitCtr;
										this.Memo = i.Memo;
										this.Active = i.Active;
										this.IsDel = i.IsDel;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class HR_PositionsFactory : Common.Business.HR_Positions
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_Position
                        select HR_PositionFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_Position
                        select HR_PositionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_Position>();
                var i = (from p in ctx.DataContext.HR_Position.Where(exp)
                         select HR_PositionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_Position>();
                var i = from p in ctx.DataContext.HR_Position.Where(exp)
                         select HR_PositionFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
