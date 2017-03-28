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
	public class FE_FeeItemTypeFactory:Common.Business.FE_FeeItemType
    {
        public static Common.Business.FE_FeeItemType Fetch(FE_FeeItemType data)
        {
            Common.Business.FE_FeeItemType item = (Common.Business.FE_FeeItemType)Activator.CreateInstance(typeof(Common.Business.FE_FeeItemType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.FeeItemType = data.FeeItemType;
				                item.FeeItemName = data.FeeItemName;
				                item.TCode = data.TCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_FeeItemType>();
                var i = (from p in ctx.DataContext.FE_FeeItemType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.FeeItemType = i.FeeItemType;
										this.FeeItemName = i.FeeItemName;
										this.TCode = i.TCode;
					}
            }
        }
	}

	public class FE_FeeItemTypesFactory : Common.Business.FE_FeeItemTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_FeeItemType
                        select FE_FeeItemTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_FeeItemType
                        select FE_FeeItemTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_FeeItemType>();
                var i = (from p in ctx.DataContext.FE_FeeItemType.Where(exp)
                         select FE_FeeItemTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_FeeItemType>();
                var i = from p in ctx.DataContext.FE_FeeItemType.Where(exp)
                         select FE_FeeItemTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
