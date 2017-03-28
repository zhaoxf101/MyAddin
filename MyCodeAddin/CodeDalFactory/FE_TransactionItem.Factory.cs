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
	public class FE_TransactionItemFactory:Common.Business.FE_TransactionItem
    {
        public static Common.Business.FE_TransactionItem Fetch(FE_TransactionItem data)
        {
            Common.Business.FE_TransactionItem item = (Common.Business.FE_TransactionItem)Activator.CreateInstance(typeof(Common.Business.FE_TransactionItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Out_Trade_No = data.Out_Trade_No;
				                item.PersonId = data.PersonId;
				                item.OrderNo = data.OrderNo;
				                item.PayFee = data.PayFee;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_TransactionItem>();
                var i = (from p in ctx.DataContext.FE_TransactionItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Out_Trade_No = i.Out_Trade_No;
										this.PersonId = i.PersonId;
										this.OrderNo = i.OrderNo;
										this.PayFee = i.PayFee;
					}
            }
        }
	}

	public class FE_TransactionItemsFactory : Common.Business.FE_TransactionItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_TransactionItem
                        select FE_TransactionItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_TransactionItem
                        select FE_TransactionItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_TransactionItem>();
                var i = (from p in ctx.DataContext.FE_TransactionItem.Where(exp)
                         select FE_TransactionItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_TransactionItem>();
                var i = from p in ctx.DataContext.FE_TransactionItem.Where(exp)
                         select FE_TransactionItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
