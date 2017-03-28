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
	public class FI_ExpItemResFactory:Common.Business.FI_ExpItemRes
    {
        public static Common.Business.FI_ExpItemRes Fetch(FI_ExpItemRes data)
        {
            Common.Business.FI_ExpItemRes item = (Common.Business.FI_ExpItemRes)Activator.CreateInstance(typeof(Common.Business.FI_ExpItemRes));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ExpItemCode = data.ExpItemCode;
				                item.ResouItemCode = data.ResouItemCode;
				                item.ResRow = data.ResRow;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ExpItemRes>();
                var i = (from p in ctx.DataContext.FI_ExpItemRes.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ExpItemCode = i.ExpItemCode;
										this.ResouItemCode = i.ResouItemCode;
										this.ResRow = i.ResRow;
					}
            }
        }
	}

	public class FI_ExpItemRessFactory : Common.Business.FI_ExpItemRess
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpItemRes
                        select FI_ExpItemResFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpItemRes
                        select FI_ExpItemResFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpItemRes>();
                var i = (from p in ctx.DataContext.FI_ExpItemRes.Where(exp)
                         select FI_ExpItemResFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpItemRes>();
                var i = from p in ctx.DataContext.FI_ExpItemRes.Where(exp)
                         select FI_ExpItemResFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
