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
	public class FI_AccYearSetFactory:Common.Business.FI_AccYearSet
    {
        public static Common.Business.FI_AccYearSet Fetch(FI_AccYearSet data)
        {
            Common.Business.FI_AccYearSet item = (Common.Business.FI_AccYearSet)Activator.CreateInstance(typeof(Common.Business.FI_AccYearSet));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.AccYearSet = data.AccYearSet;
				                item.IsGCalendar = data.IsGCalendar;
				                item.PidQty = data.PidQty;
				                item.SpecPidQty = data.SpecPidQty;
				                item.DText = data.DText;
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
				var exp = lambda.Resolve<FI_AccYearSet>();
                var i = (from p in ctx.DataContext.FI_AccYearSet.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.AccYearSet = i.AccYearSet;
										this.IsGCalendar = i.IsGCalendar;
										this.PidQty = i.PidQty;
										this.SpecPidQty = i.SpecPidQty;
										this.DText = i.DText;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_AccYearSetsFactory : Common.Business.FI_AccYearSets
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_AccYearSet
                        select FI_AccYearSetFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_AccYearSet
                        select FI_AccYearSetFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_AccYearSet>();
                var i = (from p in ctx.DataContext.FI_AccYearSet.Where(exp)
                         select FI_AccYearSetFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_AccYearSet>();
                var i = from p in ctx.DataContext.FI_AccYearSet.Where(exp)
                         select FI_AccYearSetFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
