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
	public class Sys_DepartFactory:Common.Business.Sys_Depart
    {
        public static Common.Business.Sys_Depart Fetch(Sys_Depart data)
        {
            Common.Business.Sys_Depart item = (Common.Business.Sys_Depart)Activator.CreateInstance(typeof(Common.Business.Sys_Depart));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.DepCode = data.DepCode;
				                item.DepName = data.DepName;
				                item.PositionCode = data.PositionCode;
				                item.DepLeader = data.DepLeader;
				                item.DepTypeCode = data.DepTypeCode;
				                item.DepAddr = data.DepAddr;
				                item.DepPhone = data.DepPhone;
				                item.DepLevel = data.DepLevel;
				                item.PrimDepCode = data.PrimDepCode;
				                item.DepDescr = data.DepDescr;
				                item.AsLogUnit = data.AsLogUnit;
				                item.Tax = data.Tax;
				                item.DealRange = data.DealRange;
				                item.StatisticRangeCode = data.StatisticRangeCode;
				                item.CostCtr = data.CostCtr;
				                item.ProfitCtr = data.ProfitCtr;
				                item.IsBud = data.IsBud;
				                item.IsProj = data.IsProj;
				                item.ParentId = data.ParentId;
				                item.EndNode = data.EndNode;
				                item.SortOrder = data.SortOrder;
				                item.Active = data.Active;
				                item.IsDel = data.IsDel;
				                item.Memo = data.Memo;
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
				var exp = lambda.Resolve<Sys_Depart>();
                var i = (from p in ctx.DataContext.Sys_Depart.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.DepCode = i.DepCode;
										this.DepName = i.DepName;
										this.PositionCode = i.PositionCode;
										this.DepLeader = i.DepLeader;
										this.DepTypeCode = i.DepTypeCode;
										this.DepAddr = i.DepAddr;
										this.DepPhone = i.DepPhone;
										this.DepLevel = i.DepLevel;
										this.PrimDepCode = i.PrimDepCode;
										this.DepDescr = i.DepDescr;
										this.AsLogUnit = i.AsLogUnit;
										this.Tax = i.Tax;
										this.DealRange = i.DealRange;
										this.StatisticRangeCode = i.StatisticRangeCode;
										this.CostCtr = i.CostCtr;
										this.ProfitCtr = i.ProfitCtr;
										this.IsBud = i.IsBud;
										this.IsProj = i.IsProj;
										this.ParentId = i.ParentId;
										this.EndNode = i.EndNode;
										this.SortOrder = i.SortOrder;
										this.Active = i.Active;
										this.IsDel = i.IsDel;
										this.Memo = i.Memo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class Sys_DepartsFactory : Common.Business.Sys_Departs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_Depart
                        select Sys_DepartFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_Depart
                        select Sys_DepartFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_Depart>();
                var i = (from p in ctx.DataContext.Sys_Depart.Where(exp)
                         select Sys_DepartFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_Depart>();
                var i = from p in ctx.DataContext.Sys_Depart.Where(exp)
                         select Sys_DepartFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
