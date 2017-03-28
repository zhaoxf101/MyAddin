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
	public class FI_TaxAdjSubFactory:Common.Business.FI_TaxAdjSub
    {
        public static Common.Business.FI_TaxAdjSub Fetch(FI_TaxAdjSub data)
        {
            Common.Business.FI_TaxAdjSub item = (Common.Business.FI_TaxAdjSub)Activator.CreateInstance(typeof(Common.Business.FI_TaxAdjSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.TaxAdjCode = data.TaxAdjCode;
				                item.Period = data.Period;
				                item.PersonId = data.PersonId;
				                item.Description = data.Description;
				                item.TaxAmt = data.TaxAmt;
				                item.Amt = data.Amt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_TaxAdjSub>();
                var i = (from p in ctx.DataContext.FI_TaxAdjSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TaxAdjCode = i.TaxAdjCode;
										this.Period = i.Period;
										this.PersonId = i.PersonId;
										this.Description = i.Description;
										this.TaxAmt = i.TaxAmt;
										this.Amt = i.Amt;
					}
            }
        }
	}

	public class FI_TaxAdjSubsFactory : Common.Business.FI_TaxAdjSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_TaxAdjSub
                        select FI_TaxAdjSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_TaxAdjSub
                        select FI_TaxAdjSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_TaxAdjSub>();
                var i = (from p in ctx.DataContext.FI_TaxAdjSub.Where(exp)
                         select FI_TaxAdjSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_TaxAdjSub>();
                var i = from p in ctx.DataContext.FI_TaxAdjSub.Where(exp)
                         select FI_TaxAdjSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
