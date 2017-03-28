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
	public class FI_GovPayPlanAdjSubFactory:Common.Business.FI_GovPayPlanAdjSub
    {
        public static Common.Business.FI_GovPayPlanAdjSub Fetch(FI_GovPayPlanAdjSub data)
        {
            Common.Business.FI_GovPayPlanAdjSub item = (Common.Business.FI_GovPayPlanAdjSub)Activator.CreateInstance(typeof(Common.Business.FI_GovPayPlanAdjSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.BillNo = data.BillNo;
				                item.GovPlayCode = data.GovPlayCode;
				                item.Year = data.Year;
				                item.Amt = data.Amt;
				                item.ItemText = data.ItemText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_GovPayPlanAdjSub>();
                var i = (from p in ctx.DataContext.FI_GovPayPlanAdjSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.BillNo = i.BillNo;
										this.GovPlayCode = i.GovPlayCode;
										this.Year = i.Year;
										this.Amt = i.Amt;
										this.ItemText = i.ItemText;
					}
            }
        }
	}

	public class FI_GovPayPlanAdjSubsFactory : Common.Business.FI_GovPayPlanAdjSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_GovPayPlanAdjSub
                        select FI_GovPayPlanAdjSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_GovPayPlanAdjSub
                        select FI_GovPayPlanAdjSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_GovPayPlanAdjSub>();
                var i = (from p in ctx.DataContext.FI_GovPayPlanAdjSub.Where(exp)
                         select FI_GovPayPlanAdjSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_GovPayPlanAdjSub>();
                var i = from p in ctx.DataContext.FI_GovPayPlanAdjSub.Where(exp)
                         select FI_GovPayPlanAdjSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
