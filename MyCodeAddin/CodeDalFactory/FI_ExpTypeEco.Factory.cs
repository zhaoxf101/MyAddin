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
	public class FI_ExpTypeEcoFactory:Common.Business.FI_ExpTypeEco
    {
        public static Common.Business.FI_ExpTypeEco Fetch(FI_ExpTypeEco data)
        {
            Common.Business.FI_ExpTypeEco item = (Common.Business.FI_ExpTypeEco)Activator.CreateInstance(typeof(Common.Business.FI_ExpTypeEco));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpTypeCode = data.ExpTypeCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.IsAuto = data.IsAuto;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ExpTypeEco>();
                var i = (from p in ctx.DataContext.FI_ExpTypeEco.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpTypeCode = i.ExpTypeCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.IsAuto = i.IsAuto;
					}
            }
        }
	}

	public class FI_ExpTypeEcosFactory : Common.Business.FI_ExpTypeEcos
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpTypeEco
                        select FI_ExpTypeEcoFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpTypeEco
                        select FI_ExpTypeEcoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpTypeEco>();
                var i = (from p in ctx.DataContext.FI_ExpTypeEco.Where(exp)
                         select FI_ExpTypeEcoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpTypeEco>();
                var i = from p in ctx.DataContext.FI_ExpTypeEco.Where(exp)
                         select FI_ExpTypeEcoFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
