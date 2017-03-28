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
	public class PM_ProjMemLedgerFactory:Common.Business.PM_ProjMemLedger
    {
        public static Common.Business.PM_ProjMemLedger Fetch(PM_ProjMemLedger data)
        {
            Common.Business.PM_ProjMemLedger item = (Common.Business.PM_ProjMemLedger)Activator.CreateInstance(typeof(Common.Business.PM_ProjMemLedger));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Year = data.Year;
				                item.ProjCode = data.ProjCode;
				                item.PersonId = data.PersonId;
				                item.BudAmt = data.BudAmt;
				                item.LoanAmt = data.LoanAmt;
				                item.WoffAmt = data.WoffAmt;
				                item.ExpAmt = data.ExpAmt;
				                item.OrdAmt = data.OrdAmt;
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
				var exp = lambda.Resolve<PM_ProjMemLedger>();
                var i = (from p in ctx.DataContext.PM_ProjMemLedger.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Year = i.Year;
										this.ProjCode = i.ProjCode;
										this.PersonId = i.PersonId;
										this.BudAmt = i.BudAmt;
										this.LoanAmt = i.LoanAmt;
										this.WoffAmt = i.WoffAmt;
										this.ExpAmt = i.ExpAmt;
										this.OrdAmt = i.OrdAmt;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_ProjMemLedgersFactory : Common.Business.PM_ProjMemLedgers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ProjMemLedger
                        select PM_ProjMemLedgerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ProjMemLedger
                        select PM_ProjMemLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ProjMemLedger>();
                var i = (from p in ctx.DataContext.PM_ProjMemLedger.Where(exp)
                         select PM_ProjMemLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ProjMemLedger>();
                var i = from p in ctx.DataContext.PM_ProjMemLedger.Where(exp)
                         select PM_ProjMemLedgerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
