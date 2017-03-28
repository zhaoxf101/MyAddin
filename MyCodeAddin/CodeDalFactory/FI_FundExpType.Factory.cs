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
	public class FI_FundExpTypeFactory:Common.Business.FI_FundExpType
    {
        public static Common.Business.FI_FundExpType Fetch(FI_FundExpType data)
        {
            Common.Business.FI_FundExpType item = (Common.Business.FI_FundExpType)Activator.CreateInstance(typeof(Common.Business.FI_FundExpType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.FundExpTypeCode = data.FundExpTypeCode;
				                item.FundExpTypeName = data.FundExpTypeName;
				                item.FundExpTypeGrpCode = data.FundExpTypeGrpCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_FundExpType>();
                var i = (from p in ctx.DataContext.FI_FundExpType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.FundExpTypeCode = i.FundExpTypeCode;
										this.FundExpTypeName = i.FundExpTypeName;
										this.FundExpTypeGrpCode = i.FundExpTypeGrpCode;
					}
            }
        }
	}

	public class FI_FundExpTypesFactory : Common.Business.FI_FundExpTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_FundExpType
                        select FI_FundExpTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_FundExpType
                        select FI_FundExpTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_FundExpType>();
                var i = (from p in ctx.DataContext.FI_FundExpType.Where(exp)
                         select FI_FundExpTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_FundExpType>();
                var i = from p in ctx.DataContext.FI_FundExpType.Where(exp)
                         select FI_FundExpTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
