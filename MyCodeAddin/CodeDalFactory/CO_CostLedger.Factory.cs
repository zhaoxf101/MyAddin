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
	public class CO_CostLedgerFactory:Common.Business.CO_CostLedger
    {
        public static Common.Business.CO_CostLedger Fetch(CO_CostLedger data)
        {
            Common.Business.CO_CostLedger item = (Common.Business.CO_CostLedger)Activator.CreateInstance(typeof(Common.Business.CO_CostLedger));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.CostArea = data.CostArea;
				                item.CostCtr = data.CostCtr;
				                item.CostElem = data.CostElem;
				                item.ExpItemCode = data.ExpItemCode;
				                item.AccYear = data.AccYear;
				                item.LBAmt = data.LBAmt;
				                item.LDAmt01 = data.LDAmt01;
				                item.LDAmt02 = data.LDAmt02;
				                item.LDAmt03 = data.LDAmt03;
				                item.LDAmt04 = data.LDAmt04;
				                item.LDAmt05 = data.LDAmt05;
				                item.LDAmt06 = data.LDAmt06;
				                item.LDAmt07 = data.LDAmt07;
				                item.LDAmt08 = data.LDAmt08;
				                item.LDAmt09 = data.LDAmt09;
				                item.LDAmt10 = data.LDAmt10;
				                item.LDAmt11 = data.LDAmt11;
				                item.LDAmt12 = data.LDAmt12;
				                item.LDAmt13 = data.LDAmt13;
				                item.LDAmt14 = data.LDAmt14;
				                item.LDAmt15 = data.LDAmt15;
				                item.LDAmt16 = data.LDAmt16;
				                item.LCAmt01 = data.LCAmt01;
				                item.LCAmt02 = data.LCAmt02;
				                item.LCAmt03 = data.LCAmt03;
				                item.LCAmt04 = data.LCAmt04;
				                item.LCAmt05 = data.LCAmt05;
				                item.LCAmt06 = data.LCAmt06;
				                item.LCAmt07 = data.LCAmt07;
				                item.LCAmt08 = data.LCAmt08;
				                item.LCAmt09 = data.LCAmt09;
				                item.LCAmt10 = data.LCAmt10;
				                item.LCAmt11 = data.LCAmt11;
				                item.LCAmt12 = data.LCAmt12;
				                item.LCAmt13 = data.LCAmt13;
				                item.LCAmt14 = data.LCAmt14;
				                item.LCAmt15 = data.LCAmt15;
				                item.LCAmt16 = data.LCAmt16;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CO_CostLedger>();
                var i = (from p in ctx.DataContext.CO_CostLedger.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.CostArea = i.CostArea;
										this.CostCtr = i.CostCtr;
										this.CostElem = i.CostElem;
										this.ExpItemCode = i.ExpItemCode;
										this.AccYear = i.AccYear;
										this.LBAmt = i.LBAmt;
										this.LDAmt01 = i.LDAmt01;
										this.LDAmt02 = i.LDAmt02;
										this.LDAmt03 = i.LDAmt03;
										this.LDAmt04 = i.LDAmt04;
										this.LDAmt05 = i.LDAmt05;
										this.LDAmt06 = i.LDAmt06;
										this.LDAmt07 = i.LDAmt07;
										this.LDAmt08 = i.LDAmt08;
										this.LDAmt09 = i.LDAmt09;
										this.LDAmt10 = i.LDAmt10;
										this.LDAmt11 = i.LDAmt11;
										this.LDAmt12 = i.LDAmt12;
										this.LDAmt13 = i.LDAmt13;
										this.LDAmt14 = i.LDAmt14;
										this.LDAmt15 = i.LDAmt15;
										this.LDAmt16 = i.LDAmt16;
										this.LCAmt01 = i.LCAmt01;
										this.LCAmt02 = i.LCAmt02;
										this.LCAmt03 = i.LCAmt03;
										this.LCAmt04 = i.LCAmt04;
										this.LCAmt05 = i.LCAmt05;
										this.LCAmt06 = i.LCAmt06;
										this.LCAmt07 = i.LCAmt07;
										this.LCAmt08 = i.LCAmt08;
										this.LCAmt09 = i.LCAmt09;
										this.LCAmt10 = i.LCAmt10;
										this.LCAmt11 = i.LCAmt11;
										this.LCAmt12 = i.LCAmt12;
										this.LCAmt13 = i.LCAmt13;
										this.LCAmt14 = i.LCAmt14;
										this.LCAmt15 = i.LCAmt15;
										this.LCAmt16 = i.LCAmt16;
					}
            }
        }
	}

	public class CO_CostLedgersFactory : Common.Business.CO_CostLedgers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CO_CostLedger
                        select CO_CostLedgerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CO_CostLedger
                        select CO_CostLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CO_CostLedger>();
                var i = (from p in ctx.DataContext.CO_CostLedger.Where(exp)
                         select CO_CostLedgerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CO_CostLedger>();
                var i = from p in ctx.DataContext.CO_CostLedger.Where(exp)
                         select CO_CostLedgerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
