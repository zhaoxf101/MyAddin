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
	public class FI_BudIncItemFactory:Common.Business.FI_BudIncItem
    {
        public static Common.Business.FI_BudIncItem Fetch(FI_BudIncItem data)
        {
            Common.Business.FI_BudIncItem item = (Common.Business.FI_BudIncItem)Activator.CreateInstance(typeof(Common.Business.FI_BudIncItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.BudIncItemCode = data.BudIncItemCode;
				                item.BudIncItemName = data.BudIncItemName;
				                item.SBudIncTypeCode = data.SBudIncTypeCode;
				                item.Flag = data.Flag;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_BudIncItem>();
                var i = (from p in ctx.DataContext.FI_BudIncItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.BudIncItemCode = i.BudIncItemCode;
										this.BudIncItemName = i.BudIncItemName;
										this.SBudIncTypeCode = i.SBudIncTypeCode;
										this.Flag = i.Flag;
					}
            }
        }
	}

	public class FI_BudIncItemsFactory : Common.Business.FI_BudIncItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BudIncItem
                        select FI_BudIncItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BudIncItem
                        select FI_BudIncItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BudIncItem>();
                var i = (from p in ctx.DataContext.FI_BudIncItem.Where(exp)
                         select FI_BudIncItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BudIncItem>();
                var i = from p in ctx.DataContext.FI_BudIncItem.Where(exp)
                         select FI_BudIncItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
