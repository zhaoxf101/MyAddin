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
	public class Sys_CustomerFactory:Common.Business.Sys_Customer
    {
        public static Common.Business.Sys_Customer Fetch(Sys_Customer data)
        {
            Common.Business.Sys_Customer item = (Common.Business.Sys_Customer)Activator.CreateInstance(typeof(Common.Business.Sys_Customer));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.CustCode = data.CustCode;
				                item.CustName = data.CustName;
				                item.CustGrpCode = data.CustGrpCode;
				                item.OneTimeX = data.OneTimeX;
				                item.RelPartyX = data.RelPartyX;
				                item.IsDelete = data.IsDelete;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Sys_Customer>();
                var i = (from p in ctx.DataContext.Sys_Customer.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.CustCode = i.CustCode;
										this.CustName = i.CustName;
										this.CustGrpCode = i.CustGrpCode;
										this.OneTimeX = i.OneTimeX;
										this.RelPartyX = i.RelPartyX;
										this.IsDelete = i.IsDelete;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class Sys_CustomersFactory : Common.Business.Sys_Customers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_Customer
                        select Sys_CustomerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_Customer
                        select Sys_CustomerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_Customer>();
                var i = (from p in ctx.DataContext.Sys_Customer.Where(exp)
                         select Sys_CustomerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_Customer>();
                var i = from p in ctx.DataContext.Sys_Customer.Where(exp)
                         select Sys_CustomerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
