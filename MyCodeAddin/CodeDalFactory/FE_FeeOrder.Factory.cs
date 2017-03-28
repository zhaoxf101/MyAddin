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
	public class FE_FeeOrderFactory:Common.Business.FE_FeeOrder
    {
        public static Common.Business.FE_FeeOrder Fetch(FE_FeeOrder data)
        {
            Common.Business.FE_FeeOrder item = (Common.Business.FE_FeeOrder)Activator.CreateInstance(typeof(Common.Business.FE_FeeOrder));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.OrderNo = data.OrderNo;
				                item.OrderType = data.OrderType;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.OrderText = data.OrderText;
				                item.UserGroup = data.UserGroup;
				                item.Status = data.Status;
				                item.CreatedUser = data.CreatedUser;
				                item.DepartCode = data.DepartCode;
				                item.CreatedDate = data.CreatedDate;
				                item.OrderAmt = data.OrderAmt;
				                item.InAmt = data.InAmt;
				                item.CAmt = data.CAmt;
				                item.IsBatch = data.IsBatch;
				                item.IsIdentity = data.IsIdentity;
				                item.FeeItemCode = data.FeeItemCode;
				                item.ProfitCtrType = data.ProfitCtrType;
				                item.ProfitCtr = data.ProfitCtr;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_FeeOrder>();
                var i = (from p in ctx.DataContext.FE_FeeOrder.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.OrderNo = i.OrderNo;
										this.OrderType = i.OrderType;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.OrderText = i.OrderText;
										this.UserGroup = i.UserGroup;
										this.Status = i.Status;
										this.CreatedUser = i.CreatedUser;
										this.DepartCode = i.DepartCode;
										this.CreatedDate = i.CreatedDate;
										this.OrderAmt = i.OrderAmt;
										this.InAmt = i.InAmt;
										this.CAmt = i.CAmt;
										this.IsBatch = i.IsBatch;
										this.IsIdentity = i.IsIdentity;
										this.FeeItemCode = i.FeeItemCode;
										this.ProfitCtrType = i.ProfitCtrType;
										this.ProfitCtr = i.ProfitCtr;
					}
            }
        }
	}

	public class FE_FeeOrdersFactory : Common.Business.FE_FeeOrders
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_FeeOrder
                        select FE_FeeOrderFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_FeeOrder
                        select FE_FeeOrderFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_FeeOrder>();
                var i = (from p in ctx.DataContext.FE_FeeOrder.Where(exp)
                         select FE_FeeOrderFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_FeeOrder>();
                var i = from p in ctx.DataContext.FE_FeeOrder.Where(exp)
                         select FE_FeeOrderFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
