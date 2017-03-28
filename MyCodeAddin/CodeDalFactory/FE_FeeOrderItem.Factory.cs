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
	public class FE_FeeOrderItemFactory:Common.Business.FE_FeeOrderItem
    {
        public static Common.Business.FE_FeeOrderItem Fetch(FE_FeeOrderItem data)
        {
            Common.Business.FE_FeeOrderItem item = (Common.Business.FE_FeeOrderItem)Activator.CreateInstance(typeof(Common.Business.FE_FeeOrderItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.PersonId = data.PersonId;
				                item.OrderNo = data.OrderNo;
				                item.RowsId = data.RowsId;
				                item.InAmt = data.InAmt;
				                item.PayAmt = data.PayAmt;
				                item.AdjustFee = data.AdjustFee;
				                item.VerifyFiled = data.VerifyFiled;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_FeeOrderItem>();
                var i = (from p in ctx.DataContext.FE_FeeOrderItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.PersonId = i.PersonId;
										this.OrderNo = i.OrderNo;
										this.RowsId = i.RowsId;
										this.InAmt = i.InAmt;
										this.PayAmt = i.PayAmt;
										this.AdjustFee = i.AdjustFee;
										this.VerifyFiled = i.VerifyFiled;
					}
            }
        }
	}

	public class FE_FeeOrderItemsFactory : Common.Business.FE_FeeOrderItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_FeeOrderItem
                        select FE_FeeOrderItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_FeeOrderItem
                        select FE_FeeOrderItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_FeeOrderItem>();
                var i = (from p in ctx.DataContext.FE_FeeOrderItem.Where(exp)
                         select FE_FeeOrderItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_FeeOrderItem>();
                var i = from p in ctx.DataContext.FE_FeeOrderItem.Where(exp)
                         select FE_FeeOrderItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
