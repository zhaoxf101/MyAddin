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
	public class FI_GovPayPlanFactory:Common.Business.FI_GovPayPlan
    {
        public static Common.Business.FI_GovPayPlan Fetch(FI_GovPayPlan data)
        {
            Common.Business.FI_GovPayPlan item = (Common.Business.FI_GovPayPlan)Activator.CreateInstance(typeof(Common.Business.FI_GovPayPlan));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Year = data.Year;
				                item.GovPlayCode = data.GovPlayCode;
				                item.Period = data.Period;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.PBudExpFunCode = data.PBudExpFunCode;
				                item.PProjCode = data.PProjCode;
				                item.PayType = data.PayType;
				                item.BudSourceCode = data.BudSourceCode;
				                item.FundCode = data.FundCode;
				                item.AccCode = data.AccCode;
				                item.BAccCode = data.BAccCode;
				                item.PlanAmt = data.PlanAmt;
				                item.UseAmt = data.UseAmt;
				                item.ExpAmt = data.ExpAmt;
				                item.OrderAmt = data.OrderAmt;
				                item.CreateTableDate = data.CreateTableDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_GovPayPlan>();
                var i = (from p in ctx.DataContext.FI_GovPayPlan.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Year = i.Year;
										this.GovPlayCode = i.GovPlayCode;
										this.Period = i.Period;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.PBudExpFunCode = i.PBudExpFunCode;
										this.PProjCode = i.PProjCode;
										this.PayType = i.PayType;
										this.BudSourceCode = i.BudSourceCode;
										this.FundCode = i.FundCode;
										this.AccCode = i.AccCode;
										this.BAccCode = i.BAccCode;
										this.PlanAmt = i.PlanAmt;
										this.UseAmt = i.UseAmt;
										this.ExpAmt = i.ExpAmt;
										this.OrderAmt = i.OrderAmt;
										this.CreateTableDate = i.CreateTableDate;
					}
            }
        }
	}

	public class FI_GovPayPlansFactory : Common.Business.FI_GovPayPlans
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_GovPayPlan
                        select FI_GovPayPlanFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_GovPayPlan
                        select FI_GovPayPlanFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_GovPayPlan>();
                var i = (from p in ctx.DataContext.FI_GovPayPlan.Where(exp)
                         select FI_GovPayPlanFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_GovPayPlan>();
                var i = from p in ctx.DataContext.FI_GovPayPlan.Where(exp)
                         select FI_GovPayPlanFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
