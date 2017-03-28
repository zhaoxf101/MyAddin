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
	public class FI_GovPayPlanTypeFactory:Common.Business.FI_GovPayPlanType
    {
        public static Common.Business.FI_GovPayPlanType Fetch(FI_GovPayPlanType data)
        {
            Common.Business.FI_GovPayPlanType item = (Common.Business.FI_GovPayPlanType)Activator.CreateInstance(typeof(Common.Business.FI_GovPayPlanType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.GovPayPlanType = data.GovPayPlanType;
				                item.GovPayPlanName = data.GovPayPlanName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_GovPayPlanType>();
                var i = (from p in ctx.DataContext.FI_GovPayPlanType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.GovPayPlanType = i.GovPayPlanType;
										this.GovPayPlanName = i.GovPayPlanName;
					}
            }
        }
	}

	public class FI_GovPayPlanTypesFactory : Common.Business.FI_GovPayPlanTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_GovPayPlanType
                        select FI_GovPayPlanTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_GovPayPlanType
                        select FI_GovPayPlanTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_GovPayPlanType>();
                var i = (from p in ctx.DataContext.FI_GovPayPlanType.Where(exp)
                         select FI_GovPayPlanTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_GovPayPlanType>();
                var i = from p in ctx.DataContext.FI_GovPayPlanType.Where(exp)
                         select FI_GovPayPlanTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
