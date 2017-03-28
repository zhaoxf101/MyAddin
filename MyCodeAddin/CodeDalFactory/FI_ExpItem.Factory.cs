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
	public class FI_ExpItemFactory:Common.Business.FI_ExpItem
    {
        public static Common.Business.FI_ExpItem Fetch(FI_ExpItem data)
        {
            Common.Business.FI_ExpItem item = (Common.Business.FI_ExpItem)Activator.CreateInstance(typeof(Common.Business.FI_ExpItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ExpItemCode = data.ExpItemCode;
				                item.ExpItemName = data.ExpItemName;
				                item.ExpItemGrpCode = data.ExpItemGrpCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.ResExpTypeCode = data.ResExpTypeCode;
				                item.IsResBud = data.IsResBud;
				                item.IsThreeExp = data.IsThreeExp;
				                item.Memo = data.Memo;
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
				var exp = lambda.Resolve<FI_ExpItem>();
                var i = (from p in ctx.DataContext.FI_ExpItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ExpItemCode = i.ExpItemCode;
										this.ExpItemName = i.ExpItemName;
										this.ExpItemGrpCode = i.ExpItemGrpCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.ResExpTypeCode = i.ResExpTypeCode;
										this.IsResBud = i.IsResBud;
										this.IsThreeExp = i.IsThreeExp;
										this.Memo = i.Memo;
										this.Active = i.Active;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_ExpItemsFactory : Common.Business.FI_ExpItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpItem
                        select FI_ExpItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpItem
                        select FI_ExpItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpItem>();
                var i = (from p in ctx.DataContext.FI_ExpItem.Where(exp)
                         select FI_ExpItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpItem>();
                var i = from p in ctx.DataContext.FI_ExpItem.Where(exp)
                         select FI_ExpItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
