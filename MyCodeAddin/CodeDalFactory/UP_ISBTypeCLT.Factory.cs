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
	public class UP_ISBTypeCLTFactory:Common.Business.UP_ISBTypeCLT
    {
        public static Common.Business.UP_ISBTypeCLT Fetch(UP_ISBTypeCLT data)
        {
            Common.Business.UP_ISBTypeCLT item = (Common.Business.UP_ISBTypeCLT)Activator.CreateInstance(typeof(Common.Business.UP_ISBTypeCLT));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ISBType = data.ISBType;
				                item.AccountId = data.AccountId;
				                item.NSendApi = data.NSendApi;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<UP_ISBTypeCLT>();
                var i = (from p in ctx.DataContext.UP_ISBTypeCLT.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ISBType = i.ISBType;
										this.AccountId = i.AccountId;
										this.NSendApi = i.NSendApi;
					}
            }
        }
	}

	public class UP_ISBTypeCLTsFactory : Common.Business.UP_ISBTypeCLTs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_ISBTypeCLT
                        select UP_ISBTypeCLTFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_ISBTypeCLT
                        select UP_ISBTypeCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_ISBTypeCLT>();
                var i = (from p in ctx.DataContext.UP_ISBTypeCLT.Where(exp)
                         select UP_ISBTypeCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_ISBTypeCLT>();
                var i = from p in ctx.DataContext.UP_ISBTypeCLT.Where(exp)
                         select UP_ISBTypeCLTFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
