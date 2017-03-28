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
	public class FI_ExpBusTravelSubFactory:Common.Business.FI_ExpBusTravelSub
    {
        public static Common.Business.FI_ExpBusTravelSub Fetch(FI_ExpBusTravelSub data)
        {
            Common.Business.FI_ExpBusTravelSub item = (Common.Business.FI_ExpBusTravelSub)Activator.CreateInstance(typeof(Common.Business.FI_ExpBusTravelSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpBusCode = data.ExpBusCode;
				                item.TravelRowId = data.TravelRowId;
				                item.ResouItemCode = data.ResouItemCode;
				                item.ResouGrpCode = data.ResouGrpCode;
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
				var exp = lambda.Resolve<FI_ExpBusTravelSub>();
                var i = (from p in ctx.DataContext.FI_ExpBusTravelSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpBusCode = i.ExpBusCode;
										this.TravelRowId = i.TravelRowId;
										this.ResouItemCode = i.ResouItemCode;
										this.ResouGrpCode = i.ResouGrpCode;
										this.ExpAmt = i.ExpAmt;
										this.ActAmt = i.ActAmt;
					}
            }
        }
	}

	public class FI_ExpBusTravelSubsFactory : Common.Business.FI_ExpBusTravelSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpBusTravelSub
                        select FI_ExpBusTravelSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpBusTravelSub
                        select FI_ExpBusTravelSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpBusTravelSub>();
                var i = (from p in ctx.DataContext.FI_ExpBusTravelSub.Where(exp)
                         select FI_ExpBusTravelSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpBusTravelSub>();
                var i = from p in ctx.DataContext.FI_ExpBusTravelSub.Where(exp)
                         select FI_ExpBusTravelSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
