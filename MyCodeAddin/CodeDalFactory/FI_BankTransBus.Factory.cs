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
	public class FI_BankTransBusFactory:Common.Business.FI_BankTransBus
    {
        public static Common.Business.FI_BankTransBus Fetch(FI_BankTransBus data)
        {
            Common.Business.FI_BankTransBus item = (Common.Business.FI_BankTransBus)Activator.CreateInstance(typeof(Common.Business.FI_BankTransBus));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.TransactionNo = data.TransactionNo;
				                item.BankId = data.BankId;
				                item.BusType = data.BusType;
				                item.ItemId = data.ItemId;
				                item.ItemText = data.ItemText;
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
				var exp = lambda.Resolve<FI_BankTransBus>();
                var i = (from p in ctx.DataContext.FI_BankTransBus.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TransactionNo = i.TransactionNo;
										this.BankId = i.BankId;
										this.BusType = i.BusType;
										this.ItemId = i.ItemId;
										this.ItemText = i.ItemText;
										this.Amt = i.Amt;
					}
            }
        }
	}

	public class FI_BankTransBussFactory : Common.Business.FI_BankTransBuss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BankTransBus
                        select FI_BankTransBusFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BankTransBus
                        select FI_BankTransBusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BankTransBus>();
                var i = (from p in ctx.DataContext.FI_BankTransBus.Where(exp)
                         select FI_BankTransBusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BankTransBus>();
                var i = from p in ctx.DataContext.FI_BankTransBus.Where(exp)
                         select FI_BankTransBusFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
