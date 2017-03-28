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
	public class SM_FeeItemFactory:Common.Business.SM_FeeItem
    {
        public static Common.Business.SM_FeeItem Fetch(SM_FeeItem data)
        {
            Common.Business.SM_FeeItem item = (Common.Business.SM_FeeItem)Activator.CreateInstance(typeof(Common.Business.SM_FeeItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.FeeItemCode = data.FeeItemCode;
				                item.FeeItemName = data.FeeItemName;
				                item.IncDetCode = data.IncDetCode;
				                item.IsEscrow = data.IsEscrow;
				                item.IsAllo = data.IsAllo;
				                item.AccType = data.AccType;
				                item.AccCode = data.AccCode;
				                item.OldFeeItemCode = data.OldFeeItemCode;
				                item.DepCode = data.DepCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<SM_FeeItem>();
                var i = (from p in ctx.DataContext.SM_FeeItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.FeeItemCode = i.FeeItemCode;
										this.FeeItemName = i.FeeItemName;
										this.IncDetCode = i.IncDetCode;
										this.IsEscrow = i.IsEscrow;
										this.IsAllo = i.IsAllo;
										this.AccType = i.AccType;
										this.AccCode = i.AccCode;
										this.OldFeeItemCode = i.OldFeeItemCode;
										this.DepCode = i.DepCode;
					}
            }
        }
	}

	public class SM_FeeItemsFactory : Common.Business.SM_FeeItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_FeeItem
                        select SM_FeeItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_FeeItem
                        select SM_FeeItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_FeeItem>();
                var i = (from p in ctx.DataContext.SM_FeeItem.Where(exp)
                         select SM_FeeItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_FeeItem>();
                var i = from p in ctx.DataContext.SM_FeeItem.Where(exp)
                         select SM_FeeItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
