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
	public class FI_ExpTypeResFactory:Common.Business.FI_ExpTypeRes
    {
        public static Common.Business.FI_ExpTypeRes Fetch(FI_ExpTypeRes data)
        {
            Common.Business.FI_ExpTypeRes item = (Common.Business.FI_ExpTypeRes)Activator.CreateInstance(typeof(Common.Business.FI_ExpTypeRes));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpTypeCode = data.ExpTypeCode;
				                item.ResouItemCode = data.ResouItemCode;
				                item.IsSubsidy = data.IsSubsidy;
				                item.SubsidyStand = data.SubsidyStand;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ExpTypeRes>();
                var i = (from p in ctx.DataContext.FI_ExpTypeRes.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpTypeCode = i.ExpTypeCode;
										this.ResouItemCode = i.ResouItemCode;
										this.IsSubsidy = i.IsSubsidy;
										this.SubsidyStand = i.SubsidyStand;
					}
            }
        }
	}

	public class FI_ExpTypeRessFactory : Common.Business.FI_ExpTypeRess
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpTypeRes
                        select FI_ExpTypeResFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpTypeRes
                        select FI_ExpTypeResFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpTypeRes>();
                var i = (from p in ctx.DataContext.FI_ExpTypeRes.Where(exp)
                         select FI_ExpTypeResFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpTypeRes>();
                var i = from p in ctx.DataContext.FI_ExpTypeRes.Where(exp)
                         select FI_ExpTypeResFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
