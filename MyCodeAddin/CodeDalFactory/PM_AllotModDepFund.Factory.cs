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
	public class PM_AllotModDepFundFactory:Common.Business.PM_AllotModDepFund
    {
        public static Common.Business.PM_AllotModDepFund Fetch(PM_AllotModDepFund data)
        {
            Common.Business.PM_AllotModDepFund item = (Common.Business.PM_AllotModDepFund)Activator.CreateInstance(typeof(Common.Business.PM_AllotModDepFund));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AllotModCode = data.AllotModCode;
				                item.AllotItemCode = data.AllotItemCode;
				                item.DepCode = data.DepCode;
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
				var exp = lambda.Resolve<PM_AllotModDepFund>();
                var i = (from p in ctx.DataContext.PM_AllotModDepFund.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AllotModCode = i.AllotModCode;
										this.AllotItemCode = i.AllotItemCode;
										this.DepCode = i.DepCode;
										this.FundCode = i.FundCode;
					}
            }
        }
	}

	public class PM_AllotModDepFundsFactory : Common.Business.PM_AllotModDepFunds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_AllotModDepFund
                        select PM_AllotModDepFundFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_AllotModDepFund
                        select PM_AllotModDepFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_AllotModDepFund>();
                var i = (from p in ctx.DataContext.PM_AllotModDepFund.Where(exp)
                         select PM_AllotModDepFundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_AllotModDepFund>();
                var i = from p in ctx.DataContext.PM_AllotModDepFund.Where(exp)
                         select PM_AllotModDepFundFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
