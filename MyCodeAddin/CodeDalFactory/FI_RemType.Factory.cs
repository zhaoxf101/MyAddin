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
	public class FI_RemTypeFactory:Common.Business.FI_RemType
    {
        public static Common.Business.FI_RemType Fetch(FI_RemType data)
        {
            Common.Business.FI_RemType item = (Common.Business.FI_RemType)Activator.CreateInstance(typeof(Common.Business.FI_RemType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.RemTypeCode = data.RemTypeCode;
				                item.RemTypeName = data.RemTypeName;
				                item.IsBank = data.IsBank;
				                item.Account = data.Account;
				                item.SortOrder = data.SortOrder;
				                item.IsIn = data.IsIn;
				                item.IsZero = data.IsZero;
				                item.IsBankAcc = data.IsBankAcc;
				                item.IsFundAcc = data.IsFundAcc;
				                item.IsIncAcc = data.IsIncAcc;
				                item.PayType = data.PayType;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_RemType>();
                var i = (from p in ctx.DataContext.FI_RemType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.RemTypeCode = i.RemTypeCode;
										this.RemTypeName = i.RemTypeName;
										this.IsBank = i.IsBank;
										this.Account = i.Account;
										this.SortOrder = i.SortOrder;
										this.IsIn = i.IsIn;
										this.IsZero = i.IsZero;
										this.IsBankAcc = i.IsBankAcc;
										this.IsFundAcc = i.IsFundAcc;
										this.IsIncAcc = i.IsIncAcc;
										this.PayType = i.PayType;
					}
            }
        }
	}

	public class FI_RemTypesFactory : Common.Business.FI_RemTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_RemType
                        select FI_RemTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_RemType
                        select FI_RemTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_RemType>();
                var i = (from p in ctx.DataContext.FI_RemType.Where(exp)
                         select FI_RemTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_RemType>();
                var i = from p in ctx.DataContext.FI_RemType.Where(exp)
                         select FI_RemTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
