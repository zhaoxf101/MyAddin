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
	public class HR_SociSecFactory:Common.Business.HR_SociSec
    {
        public static Common.Business.HR_SociSec Fetch(HR_SociSec data)
        {
            Common.Business.HR_SociSec item = (Common.Business.HR_SociSec)Activator.CreateInstance(typeof(Common.Business.HR_SociSec));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SociSecCode = data.SociSecCode;
				                item.PersonId = data.PersonId;
				                item.SociSecItemCode = data.SociSecItemCode;
				                item.SociSecItemName = data.SociSecItemName;
				                item.SociSecAmt = data.SociSecAmt;
				                item.ResouItemCode = data.ResouItemCode;
				                item.IsIncrease = data.IsIncrease;
				                item.Sort = data.Sort;
				                item.TaxPeriod = data.TaxPeriod;
				                item.CostCtr = data.CostCtr;
				                item.Staff = data.Staff;
				                item.UType = data.UType;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemId = data.ExpItemId;
				                item.Description = data.Description;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SociSec>();
                var i = (from p in ctx.DataContext.HR_SociSec.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SociSecCode = i.SociSecCode;
										this.PersonId = i.PersonId;
										this.SociSecItemCode = i.SociSecItemCode;
										this.SociSecItemName = i.SociSecItemName;
										this.SociSecAmt = i.SociSecAmt;
										this.ResouItemCode = i.ResouItemCode;
										this.IsIncrease = i.IsIncrease;
										this.Sort = i.Sort;
										this.TaxPeriod = i.TaxPeriod;
										this.CostCtr = i.CostCtr;
										this.Staff = i.Staff;
										this.UType = i.UType;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ExpItemId = i.ExpItemId;
										this.Description = i.Description;
					}
            }
        }
	}

	public class HR_SociSecsFactory : Common.Business.HR_SociSecs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SociSec
                        select HR_SociSecFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SociSec
                        select HR_SociSecFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SociSec>();
                var i = (from p in ctx.DataContext.HR_SociSec.Where(exp)
                         select HR_SociSecFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SociSec>();
                var i = from p in ctx.DataContext.HR_SociSec.Where(exp)
                         select HR_SociSecFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
