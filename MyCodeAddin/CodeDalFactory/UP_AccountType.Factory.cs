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
	public class UP_AccountTypeFactory:Common.Business.UP_AccountType
    {
        public static Common.Business.UP_AccountType Fetch(UP_AccountType data)
        {
            Common.Business.UP_AccountType item = (Common.Business.UP_AccountType)Activator.CreateInstance(typeof(Common.Business.UP_AccountType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.AccTypeCode = data.AccTypeCode;
				                item.AccTypeName = data.AccTypeName;
				                item.AccountGroupId = data.AccountGroupId;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<UP_AccountType>();
                var i = (from p in ctx.DataContext.UP_AccountType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.AccTypeCode = i.AccTypeCode;
										this.AccTypeName = i.AccTypeName;
										this.AccountGroupId = i.AccountGroupId;
					}
            }
        }
	}

	public class UP_AccountTypesFactory : Common.Business.UP_AccountTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_AccountType
                        select UP_AccountTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_AccountType
                        select UP_AccountTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_AccountType>();
                var i = (from p in ctx.DataContext.UP_AccountType.Where(exp)
                         select UP_AccountTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_AccountType>();
                var i = from p in ctx.DataContext.UP_AccountType.Where(exp)
                         select UP_AccountTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
