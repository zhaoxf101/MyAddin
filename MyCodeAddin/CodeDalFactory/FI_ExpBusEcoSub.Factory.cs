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
	public class FI_ExpBusEcoSubFactory:Common.Business.FI_ExpBusEcoSub
    {
        public static Common.Business.FI_ExpBusEcoSub Fetch(FI_ExpBusEcoSub data)
        {
            Common.Business.FI_ExpBusEcoSub item = (Common.Business.FI_ExpBusEcoSub)Activator.CreateInstance(typeof(Common.Business.FI_ExpBusEcoSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpBusCode = data.ExpBusCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.ExpAmt = data.ExpAmt;
				                item.ActAmt = data.ActAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ExpBusEcoSub>();
                var i = (from p in ctx.DataContext.FI_ExpBusEcoSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpBusCode = i.ExpBusCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.ExpAmt = i.ExpAmt;
										this.ActAmt = i.ActAmt;
					}
            }
        }
	}

	public class FI_ExpBusEcoSubsFactory : Common.Business.FI_ExpBusEcoSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpBusEcoSub
                        select FI_ExpBusEcoSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpBusEcoSub
                        select FI_ExpBusEcoSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpBusEcoSub>();
                var i = (from p in ctx.DataContext.FI_ExpBusEcoSub.Where(exp)
                         select FI_ExpBusEcoSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpBusEcoSub>();
                var i = from p in ctx.DataContext.FI_ExpBusEcoSub.Where(exp)
                         select FI_ExpBusEcoSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
