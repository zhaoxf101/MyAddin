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
	public class CG_FeeItemFactory:Common.Business.CG_FeeItem
    {
        public static Common.Business.CG_FeeItem Fetch(CG_FeeItem data)
        {
            Common.Business.CG_FeeItem item = (Common.Business.CG_FeeItem)Activator.CreateInstance(typeof(Common.Business.CG_FeeItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.FeeItemCode = data.FeeItemCode;
				                item.FeeItemName = data.FeeItemName;
				                item.FeeItemType = data.FeeItemType;
				                item.Sort = data.Sort;
				                item.Memo = data.Memo;
				                item.AccType = data.AccType;
				                item.AccCode = data.AccCode;
				                item.BAccCode = data.BAccCode;
				                item.IsInc = data.IsInc;
				                item.GLMark = data.GLMark;
				                item.IncDetCode = data.IncDetCode;
				                item.GetProType = data.GetProType;
				                item.SumType = data.SumType;
				                item.WorkFlowId = data.WorkFlowId;
				                item.CreateUser = data.CreateUser;
				                item.CreateDate = data.CreateDate;
				                item.ChangeUser = data.ChangeUser;
				                item.ChangeDate = data.ChangeDate;
				                item.IsOrder = data.IsOrder;
				                item.IsActive = data.IsActive;
				                item.IsDel = data.IsDel;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CG_FeeItem>();
                var i = (from p in ctx.DataContext.CG_FeeItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.FeeItemCode = i.FeeItemCode;
										this.FeeItemName = i.FeeItemName;
										this.FeeItemType = i.FeeItemType;
										this.Sort = i.Sort;
										this.Memo = i.Memo;
										this.AccType = i.AccType;
										this.AccCode = i.AccCode;
										this.BAccCode = i.BAccCode;
										this.IsInc = i.IsInc;
										this.GLMark = i.GLMark;
										this.IncDetCode = i.IncDetCode;
										this.GetProType = i.GetProType;
										this.SumType = i.SumType;
										this.WorkFlowId = i.WorkFlowId;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
										this.IsOrder = i.IsOrder;
										this.IsActive = i.IsActive;
										this.IsDel = i.IsDel;
					}
            }
        }
	}

	public class CG_FeeItemsFactory : Common.Business.CG_FeeItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CG_FeeItem
                        select CG_FeeItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CG_FeeItem
                        select CG_FeeItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CG_FeeItem>();
                var i = (from p in ctx.DataContext.CG_FeeItem.Where(exp)
                         select CG_FeeItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CG_FeeItem>();
                var i = from p in ctx.DataContext.CG_FeeItem.Where(exp)
                         select CG_FeeItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
