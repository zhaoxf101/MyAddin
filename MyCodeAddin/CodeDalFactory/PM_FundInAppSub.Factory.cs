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
	public class PM_FundInAppSubFactory:Common.Business.PM_FundInAppSub
    {
        public static Common.Business.PM_FundInAppSub Fetch(PM_FundInAppSub data)
        {
            Common.Business.PM_FundInAppSub item = (Common.Business.PM_FundInAppSub)Activator.CreateInstance(typeof(Common.Business.PM_FundInAppSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Year = data.Year;
				                item.InNo = data.InNo;
				                item.FundCode = data.FundCode;
				                item.PostDate = data.PostDate;
				                item.AppAmt = data.AppAmt;
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
				var exp = lambda.Resolve<PM_FundInAppSub>();
                var i = (from p in ctx.DataContext.PM_FundInAppSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Year = i.Year;
										this.InNo = i.InNo;
										this.FundCode = i.FundCode;
										this.PostDate = i.PostDate;
										this.AppAmt = i.AppAmt;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_FundInAppSubsFactory : Common.Business.PM_FundInAppSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_FundInAppSub
                        select PM_FundInAppSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_FundInAppSub
                        select PM_FundInAppSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_FundInAppSub>();
                var i = (from p in ctx.DataContext.PM_FundInAppSub.Where(exp)
                         select PM_FundInAppSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_FundInAppSub>();
                var i = from p in ctx.DataContext.PM_FundInAppSub.Where(exp)
                         select PM_FundInAppSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
