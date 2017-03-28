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
	public class HR_PayRollCreditFactory:Common.Business.HR_PayRollCredit
    {
        public static Common.Business.HR_PayRollCredit Fetch(HR_PayRollCredit data)
        {
            Common.Business.HR_PayRollCredit item = (Common.Business.HR_PayRollCredit)Activator.CreateInstance(typeof(Common.Business.HR_PayRollCredit));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.DepCode = data.DepCode;
				                item.CustCode = data.CustCode;
				                item.ProfitCtr = data.ProfitCtr;
				                item.IncDetCode = data.IncDetCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_PayRollCredit>();
                var i = (from p in ctx.DataContext.HR_PayRollCredit.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.DepCode = i.DepCode;
										this.CustCode = i.CustCode;
										this.ProfitCtr = i.ProfitCtr;
										this.IncDetCode = i.IncDetCode;
					}
            }
        }
	}

	public class HR_PayRollCreditsFactory : Common.Business.HR_PayRollCredits
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_PayRollCredit
                        select HR_PayRollCreditFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_PayRollCredit
                        select HR_PayRollCreditFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_PayRollCredit>();
                var i = (from p in ctx.DataContext.HR_PayRollCredit.Where(exp)
                         select HR_PayRollCreditFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_PayRollCredit>();
                var i = from p in ctx.DataContext.HR_PayRollCredit.Where(exp)
                         select HR_PayRollCreditFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
