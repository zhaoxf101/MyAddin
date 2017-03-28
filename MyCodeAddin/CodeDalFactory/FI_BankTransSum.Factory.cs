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
	public class FI_BankTransSumFactory:Common.Business.FI_BankTransSum
    {
        public static Common.Business.FI_BankTransSum Fetch(FI_BankTransSum data)
        {
            Common.Business.FI_BankTransSum item = (Common.Business.FI_BankTransSum)Activator.CreateInstance(typeof(Common.Business.FI_BankTransSum));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.TransBillNo = data.TransBillNo;
				                item.FreeItemCode = data.FreeItemCode;
				                item.SumType = data.SumType;
				                item.SumItemCode = data.SumItemCode;
				                item.ProfitCtr = data.ProfitCtr;
				                item.ItemText = data.ItemText;
				                item.Amt = data.Amt;
				                item.IncDetCode = data.IncDetCode;
				                item.IsInc = data.IsInc;
				                item.RelPartyCode = data.RelPartyCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_BankTransSum>();
                var i = (from p in ctx.DataContext.FI_BankTransSum.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TransBillNo = i.TransBillNo;
										this.FreeItemCode = i.FreeItemCode;
										this.SumType = i.SumType;
										this.SumItemCode = i.SumItemCode;
										this.ProfitCtr = i.ProfitCtr;
										this.ItemText = i.ItemText;
										this.Amt = i.Amt;
										this.IncDetCode = i.IncDetCode;
										this.IsInc = i.IsInc;
										this.RelPartyCode = i.RelPartyCode;
					}
            }
        }
	}

	public class FI_BankTransSumsFactory : Common.Business.FI_BankTransSums
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BankTransSum
                        select FI_BankTransSumFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BankTransSum
                        select FI_BankTransSumFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BankTransSum>();
                var i = (from p in ctx.DataContext.FI_BankTransSum.Where(exp)
                         select FI_BankTransSumFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BankTransSum>();
                var i = from p in ctx.DataContext.FI_BankTransSum.Where(exp)
                         select FI_BankTransSumFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
