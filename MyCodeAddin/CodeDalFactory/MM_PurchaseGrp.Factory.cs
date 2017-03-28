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
	public class MM_PurchaseGrpFactory:Common.Business.MM_PurchaseGrp
    {
        public static Common.Business.MM_PurchaseGrp Fetch(MM_PurchaseGrp data)
        {
            Common.Business.MM_PurchaseGrp item = (Common.Business.MM_PurchaseGrp)Activator.CreateInstance(typeof(Common.Business.MM_PurchaseGrp));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.PurchaseGrp = data.PurchaseGrp;
				                item.SText = data.SText;
				                item.LText = data.LText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<MM_PurchaseGrp>();
                var i = (from p in ctx.DataContext.MM_PurchaseGrp.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.PurchaseGrp = i.PurchaseGrp;
										this.SText = i.SText;
										this.LText = i.LText;
					}
            }
        }
	}

	public class MM_PurchaseGrpsFactory : Common.Business.MM_PurchaseGrps
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.MM_PurchaseGrp
                        select MM_PurchaseGrpFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.MM_PurchaseGrp
                        select MM_PurchaseGrpFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<MM_PurchaseGrp>();
                var i = (from p in ctx.DataContext.MM_PurchaseGrp.Where(exp)
                         select MM_PurchaseGrpFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<MM_PurchaseGrp>();
                var i = from p in ctx.DataContext.MM_PurchaseGrp.Where(exp)
                         select MM_PurchaseGrpFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
