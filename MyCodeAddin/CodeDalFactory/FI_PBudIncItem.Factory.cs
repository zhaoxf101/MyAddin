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
	public class FI_PBudIncItemFactory:Common.Business.FI_PBudIncItem
    {
        public static Common.Business.FI_PBudIncItem Fetch(FI_PBudIncItem data)
        {
            Common.Business.FI_PBudIncItem item = (Common.Business.FI_PBudIncItem)Activator.CreateInstance(typeof(Common.Business.FI_PBudIncItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PBudIncItemCode = data.PBudIncItemCode;
				                item.PBudIncItemName = data.PBudIncItemName;
				                item.PBudIncTypeCode = data.PBudIncTypeCode;
				                item.PCode = data.PCode;
				                item.IsSpecial = data.IsSpecial;
				                item.FundSourceCode = data.FundSourceCode;
				                item.AccCode = data.AccCode;
				                item.IsGroup = data.IsGroup;
				                item.Active = data.Active;
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
				var exp = lambda.Resolve<FI_PBudIncItem>();
                var i = (from p in ctx.DataContext.FI_PBudIncItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PBudIncItemCode = i.PBudIncItemCode;
										this.PBudIncItemName = i.PBudIncItemName;
										this.PBudIncTypeCode = i.PBudIncTypeCode;
										this.PCode = i.PCode;
										this.IsSpecial = i.IsSpecial;
										this.FundSourceCode = i.FundSourceCode;
										this.AccCode = i.AccCode;
										this.IsGroup = i.IsGroup;
										this.Active = i.Active;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_PBudIncItemsFactory : Common.Business.FI_PBudIncItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PBudIncItem
                        select FI_PBudIncItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PBudIncItem
                        select FI_PBudIncItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PBudIncItem>();
                var i = (from p in ctx.DataContext.FI_PBudIncItem.Where(exp)
                         select FI_PBudIncItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PBudIncItem>();
                var i = from p in ctx.DataContext.FI_PBudIncItem.Where(exp)
                         select FI_PBudIncItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
