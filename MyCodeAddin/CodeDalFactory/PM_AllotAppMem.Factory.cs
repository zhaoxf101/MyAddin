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
	public class PM_AllotAppMemFactory:Common.Business.PM_AllotAppMem
    {
        public static Common.Business.PM_AllotAppMem Fetch(PM_AllotAppMem data)
        {
            Common.Business.PM_AllotAppMem item = (Common.Business.PM_AllotAppMem)Activator.CreateInstance(typeof(Common.Business.PM_AllotAppMem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.TaskCode = data.TaskCode;
				                item.AllotAppNo = data.AllotAppNo;
				                item.PersonId = data.PersonId;
				                item.FundCode = data.FundCode;
				                item.DepCode = data.DepCode;
				                item.CostCtr = data.CostCtr;
				                item.ProfitCtr = data.ProfitCtr;
				                item.ProjCode = data.ProjCode;
				                item.FDAmt = data.FDAmt;
				                item.AppAmt = data.AppAmt;
				                item.AlloAmt = data.AlloAmt;
				                item.TaxAmt = data.TaxAmt;
				                item.FeeAmt = data.FeeAmt;
				                item.IsEscrow = data.IsEscrow;
				                item.Active = data.Active;
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
				var exp = lambda.Resolve<PM_AllotAppMem>();
                var i = (from p in ctx.DataContext.PM_AllotAppMem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TaskCode = i.TaskCode;
										this.AllotAppNo = i.AllotAppNo;
										this.PersonId = i.PersonId;
										this.FundCode = i.FundCode;
										this.DepCode = i.DepCode;
										this.CostCtr = i.CostCtr;
										this.ProfitCtr = i.ProfitCtr;
										this.ProjCode = i.ProjCode;
										this.FDAmt = i.FDAmt;
										this.AppAmt = i.AppAmt;
										this.AlloAmt = i.AlloAmt;
										this.TaxAmt = i.TaxAmt;
										this.FeeAmt = i.FeeAmt;
										this.IsEscrow = i.IsEscrow;
										this.Active = i.Active;
										this.Memo = i.Memo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_AllotAppMemsFactory : Common.Business.PM_AllotAppMems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_AllotAppMem
                        select PM_AllotAppMemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_AllotAppMem
                        select PM_AllotAppMemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_AllotAppMem>();
                var i = (from p in ctx.DataContext.PM_AllotAppMem.Where(exp)
                         select PM_AllotAppMemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_AllotAppMem>();
                var i = from p in ctx.DataContext.PM_AllotAppMem.Where(exp)
                         select PM_AllotAppMemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
