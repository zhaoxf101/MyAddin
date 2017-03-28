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
	public class PM_BudIncProjFactory:Common.Business.PM_BudIncProj
    {
        public static Common.Business.PM_BudIncProj Fetch(PM_BudIncProj data)
        {
            Common.Business.PM_BudIncProj item = (Common.Business.PM_BudIncProj)Activator.CreateInstance(typeof(Common.Business.PM_BudIncProj));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AppNo = data.AppNo;
				                item.IncDetCode = data.IncDetCode;
				                item.Year = data.Year;
				                item.SIncItemCode = data.SIncItemCode;
				                item.SBudIncTypeCode = data.SBudIncTypeCode;
				                item.ExpFundTypeCode = data.ExpFundTypeCode;
				                item.PBudIncTypeCode = data.PBudIncTypeCode;
				                item.FundBudAreaCode = data.FundBudAreaCode;
				                item.HisAmt = data.HisAmt;
				                item.CurAmt = data.CurAmt;
				                item.IsN = data.IsN;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.CheckedUser = data.CheckedUser;
				                item.CheckedDate = data.CheckedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_BudIncProj>();
                var i = (from p in ctx.DataContext.PM_BudIncProj.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AppNo = i.AppNo;
										this.IncDetCode = i.IncDetCode;
										this.Year = i.Year;
										this.SIncItemCode = i.SIncItemCode;
										this.SBudIncTypeCode = i.SBudIncTypeCode;
										this.ExpFundTypeCode = i.ExpFundTypeCode;
										this.PBudIncTypeCode = i.PBudIncTypeCode;
										this.FundBudAreaCode = i.FundBudAreaCode;
										this.HisAmt = i.HisAmt;
										this.CurAmt = i.CurAmt;
										this.IsN = i.IsN;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.CheckedUser = i.CheckedUser;
										this.CheckedDate = i.CheckedDate;
					}
            }
        }
	}

	public class PM_BudIncProjsFactory : Common.Business.PM_BudIncProjs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_BudIncProj
                        select PM_BudIncProjFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_BudIncProj
                        select PM_BudIncProjFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_BudIncProj>();
                var i = (from p in ctx.DataContext.PM_BudIncProj.Where(exp)
                         select PM_BudIncProjFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_BudIncProj>();
                var i = from p in ctx.DataContext.PM_BudIncProj.Where(exp)
                         select PM_BudIncProjFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
