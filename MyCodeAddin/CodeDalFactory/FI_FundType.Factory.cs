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
	public class FI_FundTypeFactory:Common.Business.FI_FundType
    {
        public static Common.Business.FI_FundType Fetch(FI_FundType data)
        {
            Common.Business.FI_FundType item = (Common.Business.FI_FundType)Activator.CreateInstance(typeof(Common.Business.FI_FundType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.FundTypeCode = data.FundTypeCode;
				                item.FundTypeName = data.FundTypeName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_FundType>();
                var i = (from p in ctx.DataContext.FI_FundType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.FundTypeCode = i.FundTypeCode;
										this.FundTypeName = i.FundTypeName;
					}
            }
        }
	}

	public class FI_FundTypesFactory : Common.Business.FI_FundTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_FundType
                        select FI_FundTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_FundType
                        select FI_FundTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_FundType>();
                var i = (from p in ctx.DataContext.FI_FundType.Where(exp)
                         select FI_FundTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_FundType>();
                var i = from p in ctx.DataContext.FI_FundType.Where(exp)
                         select FI_FundTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
