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
	public class HR_SociSecItemFactory:Common.Business.HR_SociSecItem
    {
        public static Common.Business.HR_SociSecItem Fetch(HR_SociSecItem data)
        {
            Common.Business.HR_SociSecItem item = (Common.Business.HR_SociSecItem)Activator.CreateInstance(typeof(Common.Business.HR_SociSecItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SociSecItemCode = data.SociSecItemCode;
				                item.SociSecItemName = data.SociSecItemName;
				                item.ResouItemCode = data.ResouItemCode;
				                item.IsIncrease = data.IsIncrease;
				                item.AccCode = data.AccCode;
				                item.Sort = data.Sort;
				                item.SalaryItemCode = data.SalaryItemCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SociSecItem>();
                var i = (from p in ctx.DataContext.HR_SociSecItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SociSecItemCode = i.SociSecItemCode;
										this.SociSecItemName = i.SociSecItemName;
										this.ResouItemCode = i.ResouItemCode;
										this.IsIncrease = i.IsIncrease;
										this.AccCode = i.AccCode;
										this.Sort = i.Sort;
										this.SalaryItemCode = i.SalaryItemCode;
					}
            }
        }
	}

	public class HR_SociSecItemsFactory : Common.Business.HR_SociSecItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SociSecItem
                        select HR_SociSecItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SociSecItem
                        select HR_SociSecItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SociSecItem>();
                var i = (from p in ctx.DataContext.HR_SociSecItem.Where(exp)
                         select HR_SociSecItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SociSecItem>();
                var i = from p in ctx.DataContext.HR_SociSecItem.Where(exp)
                         select HR_SociSecItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
