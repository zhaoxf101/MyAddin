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
	public class FI_SIncItemFactory:Common.Business.FI_SIncItem
    {
        public static Common.Business.FI_SIncItem Fetch(FI_SIncItem data)
        {
            Common.Business.FI_SIncItem item = (Common.Business.FI_SIncItem)Activator.CreateInstance(typeof(Common.Business.FI_SIncItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SIncItemCode = data.SIncItemCode;
				                item.SIncItemName = data.SIncItemName;
				                item.SIncTypeCode = data.SIncTypeCode;
				                item.ExpFundTypeCode = data.ExpFundTypeCode;
				                item.PBudIncTypeCode = data.PBudIncTypeCode;
				                item.FundBudAreaCode = data.FundBudAreaCode;
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
				var exp = lambda.Resolve<FI_SIncItem>();
                var i = (from p in ctx.DataContext.FI_SIncItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SIncItemCode = i.SIncItemCode;
										this.SIncItemName = i.SIncItemName;
										this.SIncTypeCode = i.SIncTypeCode;
										this.ExpFundTypeCode = i.ExpFundTypeCode;
										this.PBudIncTypeCode = i.PBudIncTypeCode;
										this.FundBudAreaCode = i.FundBudAreaCode;
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

	public class FI_SIncItemsFactory : Common.Business.FI_SIncItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_SIncItem
                        select FI_SIncItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_SIncItem
                        select FI_SIncItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_SIncItem>();
                var i = (from p in ctx.DataContext.FI_SIncItem.Where(exp)
                         select FI_SIncItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_SIncItem>();
                var i = from p in ctx.DataContext.FI_SIncItem.Where(exp)
                         select FI_SIncItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
