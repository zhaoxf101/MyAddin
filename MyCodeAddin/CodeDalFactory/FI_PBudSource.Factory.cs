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
	public class FI_PBudSourceFactory:Common.Business.FI_PBudSource
    {
        public static Common.Business.FI_PBudSource Fetch(FI_PBudSource data)
        {
            Common.Business.FI_PBudSource item = (Common.Business.FI_PBudSource)Activator.CreateInstance(typeof(Common.Business.FI_PBudSource));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.BudSourceCode = data.BudSourceCode;
				                item.BudSourceName = data.BudSourceName;
				                item.BudSourceGrpCode = data.BudSourceGrpCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_PBudSource>();
                var i = (from p in ctx.DataContext.FI_PBudSource.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.BudSourceCode = i.BudSourceCode;
										this.BudSourceName = i.BudSourceName;
										this.BudSourceGrpCode = i.BudSourceGrpCode;
					}
            }
        }
	}

	public class FI_PBudSourcesFactory : Common.Business.FI_PBudSources
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PBudSource
                        select FI_PBudSourceFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PBudSource
                        select FI_PBudSourceFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PBudSource>();
                var i = (from p in ctx.DataContext.FI_PBudSource.Where(exp)
                         select FI_PBudSourceFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PBudSource>();
                var i = from p in ctx.DataContext.FI_PBudSource.Where(exp)
                         select FI_PBudSourceFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
