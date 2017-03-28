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
	public class EF_BarPrefixFactory:Common.Business.EF_BarPrefix
    {
        public static Common.Business.EF_BarPrefix Fetch(EF_BarPrefix data)
        {
            Common.Business.EF_BarPrefix item = (Common.Business.EF_BarPrefix)Activator.CreateInstance(typeof(Common.Business.EF_BarPrefix));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.BarPrefix = data.BarPrefix;
				                item.BarMark = data.BarMark;
				                item.IsWF = data.IsWF;
				                item.WinformName = data.WinformName;
				                item.WebformName = data.WebformName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_BarPrefix>();
                var i = (from p in ctx.DataContext.EF_BarPrefix.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.BarPrefix = i.BarPrefix;
										this.BarMark = i.BarMark;
										this.IsWF = i.IsWF;
										this.WinformName = i.WinformName;
										this.WebformName = i.WebformName;
					}
            }
        }
	}

	public class EF_BarPrefixsFactory : Common.Business.EF_BarPrefixs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_BarPrefix
                        select EF_BarPrefixFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_BarPrefix
                        select EF_BarPrefixFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_BarPrefix>();
                var i = (from p in ctx.DataContext.EF_BarPrefix.Where(exp)
                         select EF_BarPrefixFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_BarPrefix>();
                var i = from p in ctx.DataContext.EF_BarPrefix.Where(exp)
                         select EF_BarPrefixFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
