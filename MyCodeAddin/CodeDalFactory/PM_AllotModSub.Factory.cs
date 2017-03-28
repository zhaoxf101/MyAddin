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
	public class PM_AllotModSubFactory:Common.Business.PM_AllotModSub
    {
        public static Common.Business.PM_AllotModSub Fetch(PM_AllotModSub data)
        {
            Common.Business.PM_AllotModSub item = (Common.Business.PM_AllotModSub)Activator.CreateInstance(typeof(Common.Business.PM_AllotModSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AllotModCode = data.AllotModCode;
				                item.AllotItemCode = data.AllotItemCode;
				                item.DepCode = data.DepCode;
				                item.IsNod = data.IsNod;
				                item.MaxAllotRate = data.MaxAllotRate;
				                item.FundCode = data.FundCode;
				                item.IsAcc = data.IsAcc;
				                item.IsExp = data.IsExp;
				                item.ResouItemCode = data.ResouItemCode;
				                item.ExpItemCode = data.ExpItemCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.CAccCode = data.CAccCode;
				                item.DAccCode = data.DAccCode;
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
				var exp = lambda.Resolve<PM_AllotModSub>();
                var i = (from p in ctx.DataContext.PM_AllotModSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AllotModCode = i.AllotModCode;
										this.AllotItemCode = i.AllotItemCode;
										this.DepCode = i.DepCode;
										this.IsNod = i.IsNod;
										this.MaxAllotRate = i.MaxAllotRate;
										this.FundCode = i.FundCode;
										this.IsAcc = i.IsAcc;
										this.IsExp = i.IsExp;
										this.ResouItemCode = i.ResouItemCode;
										this.ExpItemCode = i.ExpItemCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.CAccCode = i.CAccCode;
										this.DAccCode = i.DAccCode;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_AllotModSubsFactory : Common.Business.PM_AllotModSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_AllotModSub
                        select PM_AllotModSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_AllotModSub
                        select PM_AllotModSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_AllotModSub>();
                var i = (from p in ctx.DataContext.PM_AllotModSub.Where(exp)
                         select PM_AllotModSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_AllotModSub>();
                var i = from p in ctx.DataContext.PM_AllotModSub.Where(exp)
                         select PM_AllotModSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
