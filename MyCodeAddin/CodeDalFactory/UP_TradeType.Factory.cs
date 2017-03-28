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
	public class UP_TradeTypeFactory:Common.Business.UP_TradeType
    {
        public static Common.Business.UP_TradeType Fetch(UP_TradeType data)
        {
            Common.Business.UP_TradeType item = (Common.Business.UP_TradeType)Activator.CreateInstance(typeof(Common.Business.UP_TradeType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TradeTypeCode = data.TradeTypeCode;
				                item.TradeTypeName = data.TradeTypeName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<UP_TradeType>();
                var i = (from p in ctx.DataContext.UP_TradeType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TradeTypeCode = i.TradeTypeCode;
										this.TradeTypeName = i.TradeTypeName;
					}
            }
        }
	}

	public class UP_TradeTypesFactory : Common.Business.UP_TradeTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_TradeType
                        select UP_TradeTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_TradeType
                        select UP_TradeTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_TradeType>();
                var i = (from p in ctx.DataContext.UP_TradeType.Where(exp)
                         select UP_TradeTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_TradeType>();
                var i = from p in ctx.DataContext.UP_TradeType.Where(exp)
                         select UP_TradeTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
