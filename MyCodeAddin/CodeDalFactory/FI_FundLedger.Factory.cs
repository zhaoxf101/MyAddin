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
	public class FI_FundLedgerFactory:Common.Business.FI_FundLedger
    {
        public static Common.Business.FI_FundLedger Fetch(FI_FundLedger data)
        {
            Common.Business.FI_FundLedger item = (Common.Business.FI_FundLedger)Activator.CreateInstance(typeof(Common.Business.FI_FundLedger));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Year = data.Year;
				                item.FundCode = data.FundCode;
				                item.Memo = data.Memo;
				                item.LRAmt = data.LRAmt;
				                item.InAmt = data.InAmt;
				                item.LRLoanAmt = data.LRLoanAmt;
				                item.LoanAmt = data.LoanAmt;
				                item.WoffAmt = data.WoffAmt;
				                item.ExpAmt = data.ExpAmt;
				                item.OrdAmt = data.OrdAmt;
				                item.FIOrdAmt = data.FIOrdAmt;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.BAmt = data.BAmt;
				                item.IncAmt01 = data.IncAmt01;
				                item.IncAmt02 = data.IncAmt02;
				                item.IncAmt03 = data.IncAmt03;
				                item.IncAmt04 = data.IncAmt04;
				                item.IncAmt05 = data.IncAmt05;
				                item.IncAmt06 = data.IncAmt06;
				                item.IncAmt07 = data.IncAmt07;
				                item.IncAmt08 = data.IncAmt08;
				                item.IncAmt09 = data.IncAmt09;
				                item.IncAmt10 = data.IncAmt10;
				                item.IncAmt11 = data.IncAmt11;
				                item.IncAmt12 = data.IncAmt12;
				                item.IncAmt13 = data.IncAmt13;
				                item.IncAmt14 = data.IncAmt14;
				                item.IncAmt15 = data.IncAmt15;
				                item.IncAmt16 = data.IncAmt16;
				                item.ExpAmt01 = data.ExpAmt01;
				                item.ExpAmt02 = data.ExpAmt02;
				                item.ExpAmt03 = data.ExpAmt03;
				                item.ExpAmt04 = data.ExpAmt04;
				                item.ExpAmt05 = data.ExpAmt05;
				                item.ExpAmt06 = data.ExpAmt06;
				                item.ExpAmt07 = data.ExpAmt07;
				                item.ExpAmt08 = data.ExpAmt08;
				                item.ExpAmt09 = data.ExpAmt09;
				                item.ExpAmt10 = data.ExpAmt10;
				                item.ExpAmt11 = data.ExpAmt11;
				                item.ExpAmt12 = data.ExpAmt12;
				                item.ExpAmt13 = data.ExpAmt13;
				                item.ExpAmt14 = data.ExpAmt14;
				                item.ExpAmt15 = data.ExpAmt15;
				                item.ExpAmt16 = data.ExpAmt16;
				                item.BLAmt = data.BLAmt;
				                item.LoaAmt01 = data.LoaAmt01;
				                item.LoaAmt02 = data.LoaAmt02;
				                item.LoaAmt03 = data.LoaAmt03;
				                item.LoaAmt04 = data.LoaAmt04;
				                item.LoaAmt05 = data.LoaAmt05;
				                item.LoaAmt06 = data.LoaAmt06;
				                item.LoaAmt07 = data.LoaAmt07;
				                item.LoaAmt08 = data.LoaAmt08;
				                item.LoaAmt09 = data.LoaAmt09;
				                item.LoaAmt10 = data.LoaAmt10;
				                item.LoaAmt11 = data.LoaAmt11;
				                item.LoaAmt12 = data.LoaAmt12;
				                item.LoaAmt13 = data.LoaAmt13;
				                item.LoaAmt14 = data.LoaAmt14;
				                item.LoaAmt15 = data.LoaAmt15;
				                item.LoaAmt16 = data.LoaAmt16;
				                item.LorAmt01 = data.LorAmt01;
				                item.LorAmt02 = data.LorAmt02;
				                item.LorAmt03 = data.LorAmt03;
				                item.LorAmt04 = data.LorAmt04;
				                item.LorAmt05 = data.LorAmt05;
				                item.LorAmt06 = data.LorAmt06;
				                item.LorAmt07 = data.LorAmt07;
				                item.LorAmt08 = data.LorAmt08;
				                item.LorAmt09 = data.LorAmt09;
				                item.LorAmt10 = data.LorAmt10;
				                item.LorAmt11 = data.LorAmt11;
				                item.LorAmt12 = data.LorAmt12;
				                item.LorAmt13 = data.LorAmt13;
				                item.LorAmt14 = data.LorAmt14;
				                item.LorAmt15 = data.LorAmt15;
				                item.LorAmt16 = data.LorAmt16;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_FundLedger>();
                var i = (from p in ctx.DataContext.FI_FundLedger.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Year = i.Year;
										this.FundCode = i.FundCode;
										this.Memo = i.Memo;
										this.LRAmt = i.LRAmt;
										this.InAmt = i.InAmt;
										this.LRLoanAmt = i.LRLoanAmt;
										this.LoanAmt = i.LoanAmt;
										this.WoffAmt = i.WoffAmt;
										this.ExpAmt = i.ExpAmt;
										this.OrdAmt = i.OrdAmt;
										this.FIOrdAmt = i.FIOrdAmt;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.BAmt = i.BAmt;
										this.IncAmt01 = i.IncAmt01;
										this.IncAmt02 = i.IncAmt02;
										this.IncAmt03 = i.IncAmt03;
										this.IncAmt04 = i.IncAmt04;
										this.IncAmt05 = i.IncAmt05;
										this.IncAmt06 = i.IncAmt06;
										this.IncAmt07 = i.IncAmt07;
										this.IncAmt08 = i.IncAmt08;
										this.IncAmt09 = i.IncAmt09;
										this.IncAmt10 = i.IncAmt10;
										this.IncAmt11 = i.IncAmt11;
										this.IncAmt12 = i.IncAmt12;
										this.IncAmt13 = i.IncAmt13;
										this.IncAmt14 = i.IncAmt14;
										this.IncAmt15 = i.IncAmt15;
										this.IncAmt16 = i.IncAmt16;
										this.ExpAmt01 = i.ExpAmt01;
										this.ExpAmt02 = i.ExpAmt02;
										this.ExpAmt03 = i.ExpAmt03;
										this.ExpAmt04 = i.ExpAmt04;
										this.ExpAmt05 = i.ExpAmt05;
										this.ExpAmt06 = i.ExpAmt06;
										this.ExpAmt07 = i.ExpAmt07;
										this.ExpAmt08 = i.ExpAmt08;
										this.ExpAmt09 = i.ExpAmt09;
										this.ExpAmt10 = i.ExpAmt10;
										this.ExpAmt11 = i.ExpAmt11;
										this.ExpAmt12 = i.ExpAmt12;
										this.ExpAmt13 = i.ExpAmt13;
										this.ExpAmt14 = i.ExpAmt14;
										this.ExpAmt15 = i.ExpAmt15;
										this.ExpAmt16 = i.ExpAmt16;
										this.BLAmt = i.BLAmt;
										this.LoaAmt01 = i.LoaAmt01;
										this.LoaAmt02 = i.LoaAmt02;
										this.LoaAmt03 = i.LoaAmt03;
										this.LoaAmt04 = i.LoaAmt04;
										this.LoaAmt05 = i.LoaAmt05;
										this.LoaAmt06 = i.LoaAmt06;
										this.LoaAmt07 = i.LoaAmt07;
										this.LoaAmt08 = i.LoaAmt08;
										this.LoaAmt09 = i.LoaAmt09;
										this.LoaAmt10 = i.LoaAmt10;
										this.LoaAmt11 = i.LoaAmt11;
										this.LoaAmt12 = i.LoaAmt12;
										this.LoaAmt13 = i.LoaAmt13;
										this.LoaAmt14 = i.LoaAmt14;
										this.LoaAmt15 = i.LoaAmt15;
										this.LoaAmt16 = i.LoaAmt16;
										this.LorAmt01 = i.LorAmt01;
										this.LorAmt02 = i.LorAmt02;
										this.LorAmt03 = i.LorAmt03;
										this.LorAmt04 = i.LorAmt04;
										this.LorAmt05 = i.LorAmt05;
										this.LorAmt06 = i.LorAmt06;
										this.LorAmt07 = i.LorAmt07;
										this.LorAmt08 = i.LorAmt08;
										this.LorAmt09 = i.LorAmt09;
										this.LorAmt10 = i.LorAmt10;
										this.LorAmt11 = i.LorAmt11;
										this.LorAmt12 = i.LorAmt12;
										this.LorAmt13 = i.LorAmt13;
										this.LorAmt14 = i.LorAmt14;
										this.LorAmt15 = i.LorAmt15;
										this.LorAmt16 = i.LorAmt16;
					}
            }
        }
	}

	public class FI_FundLedgersFactory : Common.Business.FI_FundLedgers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_FundLedger
                        select FI_FundLedgerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_FundLedger
                        select FI_FundLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_FundLedger>();
                var i = (from p in ctx.DataContext.FI_FundLedger.Where(exp)
                         select FI_FundLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_FundLedger>();
                var i = from p in ctx.DataContext.FI_FundLedger.Where(exp)
                         select FI_FundLedgerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
