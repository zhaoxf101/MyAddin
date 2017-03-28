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
	public class FI_BudSourceTypeFactory:Common.Business.FI_BudSourceType
    {
        public static Common.Business.FI_BudSourceType Fetch(FI_BudSourceType data)
        {
            Common.Business.FI_BudSourceType item = (Common.Business.FI_BudSourceType)Activator.CreateInstance(typeof(Common.Business.FI_BudSourceType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.BudSourceGrpCode = data.BudSourceGrpCode;
				                item.BudSourceGrpName = data.BudSourceGrpName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_BudSourceType>();
                var i = (from p in ctx.DataContext.FI_BudSourceType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.BudSourceGrpCode = i.BudSourceGrpCode;
										this.BudSourceGrpName = i.BudSourceGrpName;
					}
            }
        }
	}

	public class FI_BudSourceTypesFactory : Common.Business.FI_BudSourceTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BudSourceType
                        select FI_BudSourceTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BudSourceType
                        select FI_BudSourceTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BudSourceType>();
                var i = (from p in ctx.DataContext.FI_BudSourceType.Where(exp)
                         select FI_BudSourceTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BudSourceType>();
                var i = from p in ctx.DataContext.FI_BudSourceType.Where(exp)
                         select FI_BudSourceTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
