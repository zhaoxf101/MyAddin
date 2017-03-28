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
	public class PM_ResouItemFactory:Common.Business.PM_ResouItem
    {
        public static Common.Business.PM_ResouItem Fetch(PM_ResouItem data)
        {
            Common.Business.PM_ResouItem item = (Common.Business.PM_ResouItem)Activator.CreateInstance(typeof(Common.Business.PM_ResouItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ResouItemCode = data.ResouItemCode;
				                item.ResouItemName = data.ResouItemName;
				                item.ResouGrpCode = data.ResouGrpCode;
				                item.ResouTypeCode = data.ResouTypeCode;
				                item.ResouExpCode = data.ResouExpCode;
				                item.TaxTypeCode = data.TaxTypeCode;
				                item.IsMat = data.IsMat;
				                item.IsNumMg = data.IsNumMg;
				                item.IsTimelyTax = data.IsTimelyTax;
				                item.IsCalTax = data.IsCalTax;
				                item.TaxMinIncome = data.TaxMinIncome;
				                item.TaxPeriod = data.TaxPeriod;
				                item.IsSubsidy = data.IsSubsidy;
				                item.SubsidyStand = data.SubsidyStand;
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
				var exp = lambda.Resolve<PM_ResouItem>();
                var i = (from p in ctx.DataContext.PM_ResouItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ResouItemCode = i.ResouItemCode;
										this.ResouItemName = i.ResouItemName;
										this.ResouGrpCode = i.ResouGrpCode;
										this.ResouTypeCode = i.ResouTypeCode;
										this.ResouExpCode = i.ResouExpCode;
										this.TaxTypeCode = i.TaxTypeCode;
										this.IsMat = i.IsMat;
										this.IsNumMg = i.IsNumMg;
										this.IsTimelyTax = i.IsTimelyTax;
										this.IsCalTax = i.IsCalTax;
										this.TaxMinIncome = i.TaxMinIncome;
										this.TaxPeriod = i.TaxPeriod;
										this.IsSubsidy = i.IsSubsidy;
										this.SubsidyStand = i.SubsidyStand;
										this.Active = i.Active;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_ResouItemsFactory : Common.Business.PM_ResouItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ResouItem
                        select PM_ResouItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ResouItem
                        select PM_ResouItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ResouItem>();
                var i = (from p in ctx.DataContext.PM_ResouItem.Where(exp)
                         select PM_ResouItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ResouItem>();
                var i = from p in ctx.DataContext.PM_ResouItem.Where(exp)
                         select PM_ResouItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
