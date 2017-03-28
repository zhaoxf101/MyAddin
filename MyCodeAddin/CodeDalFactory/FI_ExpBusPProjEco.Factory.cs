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
	public class FI_ExpBusPProjEcoFactory:Common.Business.FI_ExpBusPProjEco
    {
        public static Common.Business.FI_ExpBusPProjEco Fetch(FI_ExpBusPProjEco data)
        {
            Common.Business.FI_ExpBusPProjEco item = (Common.Business.FI_ExpBusPProjEco)Activator.CreateInstance(typeof(Common.Business.FI_ExpBusPProjEco));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Year = data.Year;
				                item.PProjCode = data.PProjCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.ExpBusCode = data.ExpBusCode;
				                item.PFundEcoType = data.PFundEcoType;
				                item.Amt = data.Amt;
				                item.ActAmt = data.ActAmt;
				                item.Memo = data.Memo;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ExpBusPProjEco>();
                var i = (from p in ctx.DataContext.FI_ExpBusPProjEco.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Year = i.Year;
										this.PProjCode = i.PProjCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.ExpBusCode = i.ExpBusCode;
										this.PFundEcoType = i.PFundEcoType;
										this.Amt = i.Amt;
										this.ActAmt = i.ActAmt;
										this.Memo = i.Memo;
					}
            }
        }
	}

	public class FI_ExpBusPProjEcosFactory : Common.Business.FI_ExpBusPProjEcos
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpBusPProjEco
                        select FI_ExpBusPProjEcoFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpBusPProjEco
                        select FI_ExpBusPProjEcoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpBusPProjEco>();
                var i = (from p in ctx.DataContext.FI_ExpBusPProjEco.Where(exp)
                         select FI_ExpBusPProjEcoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpBusPProjEco>();
                var i = from p in ctx.DataContext.FI_ExpBusPProjEco.Where(exp)
                         select FI_ExpBusPProjEcoFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
