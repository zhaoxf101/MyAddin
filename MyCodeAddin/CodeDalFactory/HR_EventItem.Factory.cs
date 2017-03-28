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
	public class HR_EventItemFactory:Common.Business.HR_EventItem
    {
        public static Common.Business.HR_EventItem Fetch(HR_EventItem data)
        {
            Common.Business.HR_EventItem item = (Common.Business.HR_EventItem)Activator.CreateInstance(typeof(Common.Business.HR_EventItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.EventItemCode = data.EventItemCode;
				                item.EventItemName = data.EventItemName;
				                item.EventTypeCode = data.EventTypeCode;
				                item.IsRelation = data.IsRelation;
				                item.Memo = data.Memo;
				                item.WebAppModule = data.WebAppModule;
				                item.WinAppModule = data.WinAppModule;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EventItem>();
                var i = (from p in ctx.DataContext.HR_EventItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.EventItemCode = i.EventItemCode;
										this.EventItemName = i.EventItemName;
										this.EventTypeCode = i.EventTypeCode;
										this.IsRelation = i.IsRelation;
										this.Memo = i.Memo;
										this.WebAppModule = i.WebAppModule;
										this.WinAppModule = i.WinAppModule;
					}
            }
        }
	}

	public class HR_EventItemsFactory : Common.Business.HR_EventItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EventItem
                        select HR_EventItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EventItem
                        select HR_EventItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EventItem>();
                var i = (from p in ctx.DataContext.HR_EventItem.Where(exp)
                         select HR_EventItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EventItem>();
                var i = from p in ctx.DataContext.HR_EventItem.Where(exp)
                         select HR_EventItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
