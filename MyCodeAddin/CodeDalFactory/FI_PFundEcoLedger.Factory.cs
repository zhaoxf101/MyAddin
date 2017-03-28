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
	public class FI_PFundEcoLedgerFactory:Common.Business.FI_PFundEcoLedger
    {
        public static Common.Business.FI_PFundEcoLedger Fetch(FI_PFundEcoLedger data)
        {
            Common.Business.FI_PFundEcoLedger item = (Common.Business.FI_PFundEcoLedger)Activator.CreateInstance(typeof(Common.Business.FI_PFundEcoLedger));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Year = data.Year;
				                item.PProjCode = data.PProjCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.PFundEcoType = data.PFundEcoType;
				                item.LRAmt = data.LRAmt;
				                item.BudAmt = data.BudAmt;
				                item.InAmt = data.InAmt;
				                item.AdjAmt = data.AdjAmt;
				                item.ExpAmt = data.ExpAmt;
				                item.Memo = data.Memo;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_PFundEcoLedger>();
                var i = (from p in ctx.DataContext.FI_PFundEcoLedger.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Year = i.Year;
										this.PProjCode = i.PProjCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.PFundEcoType = i.PFundEcoType;
										this.LRAmt = i.LRAmt;
										this.BudAmt = i.BudAmt;
										this.InAmt = i.InAmt;
										this.AdjAmt = i.AdjAmt;
										this.ExpAmt = i.ExpAmt;
										this.Memo = i.Memo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_PFundEcoLedgersFactory : Common.Business.FI_PFundEcoLedgers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PFundEcoLedger
                        select FI_PFundEcoLedgerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PFundEcoLedger
                        select FI_PFundEcoLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PFundEcoLedger>();
                var i = (from p in ctx.DataContext.FI_PFundEcoLedger.Where(exp)
                         select FI_PFundEcoLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PFundEcoLedger>();
                var i = from p in ctx.DataContext.FI_PFundEcoLedger.Where(exp)
                         select FI_PFundEcoLedgerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
