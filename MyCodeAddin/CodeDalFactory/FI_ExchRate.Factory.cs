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
	public class FI_ExchRateFactory:Common.Business.FI_ExchRate
    {
        public static Common.Business.FI_ExchRate Fetch(FI_ExchRate data)
        {
            Common.Business.FI_ExchRate item = (Common.Business.FI_ExchRate)Activator.CreateInstance(typeof(Common.Business.FI_ExchRate));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.FCurr = data.FCurr;
				                item.TCurr = data.TCurr;
				                item.VDate = data.VDate;
				                item.Rate = data.Rate;
				                item.FRatio = data.FRatio;
				                item.TRatio = data.TRatio;
				                item.Active = data.Active;
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
				var exp = lambda.Resolve<FI_ExchRate>();
                var i = (from p in ctx.DataContext.FI_ExchRate.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.FCurr = i.FCurr;
										this.TCurr = i.TCurr;
										this.VDate = i.VDate;
										this.Rate = i.Rate;
										this.FRatio = i.FRatio;
										this.TRatio = i.TRatio;
										this.Active = i.Active;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_ExchRatesFactory : Common.Business.FI_ExchRates
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExchRate
                        select FI_ExchRateFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExchRate
                        select FI_ExchRateFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExchRate>();
                var i = (from p in ctx.DataContext.FI_ExchRate.Where(exp)
                         select FI_ExchRateFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExchRate>();
                var i = from p in ctx.DataContext.FI_ExchRate.Where(exp)
                         select FI_ExchRateFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
