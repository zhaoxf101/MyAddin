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
	public class FI_ExpItemGrpFactory:Common.Business.FI_ExpItemGrp
    {
        public static Common.Business.FI_ExpItemGrp Fetch(FI_ExpItemGrp data)
        {
            Common.Business.FI_ExpItemGrp item = (Common.Business.FI_ExpItemGrp)Activator.CreateInstance(typeof(Common.Business.FI_ExpItemGrp));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ExpItemGrpCode = data.ExpItemGrpCode;
				                item.ExpItemGrpName = data.ExpItemGrpName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ExpItemGrp>();
                var i = (from p in ctx.DataContext.FI_ExpItemGrp.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ExpItemGrpCode = i.ExpItemGrpCode;
										this.ExpItemGrpName = i.ExpItemGrpName;
					}
            }
        }
	}

	public class FI_ExpItemGrpsFactory : Common.Business.FI_ExpItemGrps
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpItemGrp
                        select FI_ExpItemGrpFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpItemGrp
                        select FI_ExpItemGrpFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpItemGrp>();
                var i = (from p in ctx.DataContext.FI_ExpItemGrp.Where(exp)
                         select FI_ExpItemGrpFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpItemGrp>();
                var i = from p in ctx.DataContext.FI_ExpItemGrp.Where(exp)
                         select FI_ExpItemGrpFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
