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
	public class CG_FeeItemTypeFactory:Common.Business.CG_FeeItemType
    {
        public static Common.Business.CG_FeeItemType Fetch(CG_FeeItemType data)
        {
            Common.Business.CG_FeeItemType item = (Common.Business.CG_FeeItemType)Activator.CreateInstance(typeof(Common.Business.CG_FeeItemType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.FeeItemTypeCode = data.FeeItemTypeCode;
				                item.FeeItemTypeName = data.FeeItemTypeName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CG_FeeItemType>();
                var i = (from p in ctx.DataContext.CG_FeeItemType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.FeeItemTypeCode = i.FeeItemTypeCode;
										this.FeeItemTypeName = i.FeeItemTypeName;
					}
            }
        }
	}

	public class CG_FeeItemTypesFactory : Common.Business.CG_FeeItemTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CG_FeeItemType
                        select CG_FeeItemTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CG_FeeItemType
                        select CG_FeeItemTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CG_FeeItemType>();
                var i = (from p in ctx.DataContext.CG_FeeItemType.Where(exp)
                         select CG_FeeItemTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CG_FeeItemType>();
                var i = from p in ctx.DataContext.CG_FeeItemType.Where(exp)
                         select CG_FeeItemTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
