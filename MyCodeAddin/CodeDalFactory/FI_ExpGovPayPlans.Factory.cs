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
	public class FI_ExpGovPayPlansFactory:Common.Business.FI_ExpGovPayPlans
    {
        public static Common.Business.FI_ExpGovPayPlans Fetch(FI_ExpGovPayPlans data)
        {
            Common.Business.FI_ExpGovPayPlans item = (Common.Business.FI_ExpGovPayPlans)Activator.CreateInstance(typeof(Common.Business.FI_ExpGovPayPlans));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ObjId = data.ObjId;
				                item.ItemCode = data.ItemCode;
				                item.Year = data.Year;
				                item.GovPlayCode = data.GovPlayCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.PBudExpFunCode = data.PBudExpFunCode;
				                item.PProjCode = data.PProjCode;
				                item.PayType = data.PayType;
				                item.BudSourceCode = data.BudSourceCode;
				                item.Amt = data.Amt;
				                item.ActAmt = data.ActAmt;
				                item.FundCode = data.FundCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ExpGovPayPlans>();
                var i = (from p in ctx.DataContext.FI_ExpGovPayPlans.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ObjId = i.ObjId;
										this.ItemCode = i.ItemCode;
										this.Year = i.Year;
										this.GovPlayCode = i.GovPlayCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.PBudExpFunCode = i.PBudExpFunCode;
										this.PProjCode = i.PProjCode;
										this.PayType = i.PayType;
										this.BudSourceCode = i.BudSourceCode;
										this.Amt = i.Amt;
										this.ActAmt = i.ActAmt;
										this.FundCode = i.FundCode;
					}
            }
        }
	}

	public class FI_ExpGovPayPlanssFactory : Common.Business.FI_ExpGovPayPlanss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpGovPayPlans
                        select FI_ExpGovPayPlansFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpGovPayPlans
                        select FI_ExpGovPayPlansFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpGovPayPlans>();
                var i = (from p in ctx.DataContext.FI_ExpGovPayPlans.Where(exp)
                         select FI_ExpGovPayPlansFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpGovPayPlans>();
                var i = from p in ctx.DataContext.FI_ExpGovPayPlans.Where(exp)
                         select FI_ExpGovPayPlansFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
