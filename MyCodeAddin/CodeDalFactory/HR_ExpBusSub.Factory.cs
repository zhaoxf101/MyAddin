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
	public class HR_ExpBusSubFactory:Common.Business.HR_ExpBusSub
    {
        public static Common.Business.HR_ExpBusSub Fetch(HR_ExpBusSub data)
        {
            Common.Business.HR_ExpBusSub item = (Common.Business.HR_ExpBusSub)Activator.CreateInstance(typeof(Common.Business.HR_ExpBusSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpBusCode = data.ExpBusCode;
				                item.SalaryItemCode = data.SalaryItemCode;
				                item.CostCtr = data.CostCtr;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemId = data.ExpItemId;
				                item.ExpItemCode = data.ExpItemCode;
				                item.Amt = data.Amt;
				                item.IsIncrease = data.IsIncrease;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_ExpBusSub>();
                var i = (from p in ctx.DataContext.HR_ExpBusSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpBusCode = i.ExpBusCode;
										this.SalaryItemCode = i.SalaryItemCode;
										this.CostCtr = i.CostCtr;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ExpItemId = i.ExpItemId;
										this.ExpItemCode = i.ExpItemCode;
										this.Amt = i.Amt;
										this.IsIncrease = i.IsIncrease;
					}
            }
        }
	}

	public class HR_ExpBusSubsFactory : Common.Business.HR_ExpBusSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_ExpBusSub
                        select HR_ExpBusSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_ExpBusSub
                        select HR_ExpBusSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_ExpBusSub>();
                var i = (from p in ctx.DataContext.HR_ExpBusSub.Where(exp)
                         select HR_ExpBusSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_ExpBusSub>();
                var i = from p in ctx.DataContext.HR_ExpBusSub.Where(exp)
                         select HR_ExpBusSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
