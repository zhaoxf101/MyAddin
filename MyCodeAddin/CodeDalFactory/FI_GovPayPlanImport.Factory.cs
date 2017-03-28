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
	public class FI_GovPayPlanImportFactory:Common.Business.FI_GovPayPlanImport
    {
        public static Common.Business.FI_GovPayPlanImport Fetch(FI_GovPayPlanImport data)
        {
            Common.Business.FI_GovPayPlanImport item = (Common.Business.FI_GovPayPlanImport)Activator.CreateInstance(typeof(Common.Business.FI_GovPayPlanImport));
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
				                item.PlanAmt = data.PlanAmt;
				                item.UseAmt = data.UseAmt;
				                item.ItemText = data.ItemText;
				                item.CreateTableDate = data.CreateTableDate;
				                item.IsConf = data.IsConf;
				                item.BillNo = data.BillNo;
				                item.IncDetCode = data.IncDetCode;
				                item.ProfitCtr = data.ProfitCtr;
				                item.AuthAccCode = data.AuthAccCode;
				                item.ImportUser = data.ImportUser;
				                item.ImportDate = data.ImportDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_GovPayPlanImport>();
                var i = (from p in ctx.DataContext.FI_GovPayPlanImport.Where(exp)
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
										this.PlanAmt = i.PlanAmt;
										this.UseAmt = i.UseAmt;
										this.ItemText = i.ItemText;
										this.CreateTableDate = i.CreateTableDate;
										this.IsConf = i.IsConf;
										this.BillNo = i.BillNo;
										this.IncDetCode = i.IncDetCode;
										this.ProfitCtr = i.ProfitCtr;
										this.AuthAccCode = i.AuthAccCode;
										this.ImportUser = i.ImportUser;
										this.ImportDate = i.ImportDate;
					}
            }
        }
	}

	public class FI_GovPayPlanImportsFactory : Common.Business.FI_GovPayPlanImports
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_GovPayPlanImport
                        select FI_GovPayPlanImportFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_GovPayPlanImport
                        select FI_GovPayPlanImportFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_GovPayPlanImport>();
                var i = (from p in ctx.DataContext.FI_GovPayPlanImport.Where(exp)
                         select FI_GovPayPlanImportFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_GovPayPlanImport>();
                var i = from p in ctx.DataContext.FI_GovPayPlanImport.Where(exp)
                         select FI_GovPayPlanImportFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
