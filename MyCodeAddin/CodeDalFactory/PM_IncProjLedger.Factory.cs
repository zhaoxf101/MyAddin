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
	public class PM_IncProjLedgerFactory:Common.Business.PM_IncProjLedger
    {
        public static Common.Business.PM_IncProjLedger Fetch(PM_IncProjLedger data)
        {
            Common.Business.PM_IncProjLedger item = (Common.Business.PM_IncProjLedger)Activator.CreateInstance(typeof(Common.Business.PM_IncProjLedger));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Year = data.Year;
				                item.IncProjCode = data.IncProjCode;
				                item.SBudIncTypeCode = data.SBudIncTypeCode;
				                item.ExpFundTypeCode = data.ExpFundTypeCode;
				                item.PBudIncTypeCode = data.PBudIncTypeCode;
				                item.DAccCode = data.DAccCode;
				                item.CAccCode = data.CAccCode;
				                item.Active = data.Active;
				                item.BudAmt = data.BudAmt;
				                item.AdjAmt = data.AdjAmt;
				                item.IncAmt = data.IncAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_IncProjLedger>();
                var i = (from p in ctx.DataContext.PM_IncProjLedger.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Year = i.Year;
										this.IncProjCode = i.IncProjCode;
										this.SBudIncTypeCode = i.SBudIncTypeCode;
										this.ExpFundTypeCode = i.ExpFundTypeCode;
										this.PBudIncTypeCode = i.PBudIncTypeCode;
										this.DAccCode = i.DAccCode;
										this.CAccCode = i.CAccCode;
										this.Active = i.Active;
										this.BudAmt = i.BudAmt;
										this.AdjAmt = i.AdjAmt;
										this.IncAmt = i.IncAmt;
					}
            }
        }
	}

	public class PM_IncProjLedgersFactory : Common.Business.PM_IncProjLedgers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_IncProjLedger
                        select PM_IncProjLedgerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_IncProjLedger
                        select PM_IncProjLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_IncProjLedger>();
                var i = (from p in ctx.DataContext.PM_IncProjLedger.Where(exp)
                         select PM_IncProjLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_IncProjLedger>();
                var i = from p in ctx.DataContext.PM_IncProjLedger.Where(exp)
                         select PM_IncProjLedgerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
