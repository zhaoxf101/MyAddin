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
	public class Sys_VendorFactory:Common.Business.Sys_Vendor
    {
        public static Common.Business.Sys_Vendor Fetch(Sys_Vendor data)
        {
            Common.Business.Sys_Vendor item = (Common.Business.Sys_Vendor)Activator.CreateInstance(typeof(Common.Business.Sys_Vendor));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.VendorCode = data.VendorCode;
				                item.VendorName = data.VendorName;
				                item.VendGrpCode = data.VendGrpCode;
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
				var exp = lambda.Resolve<Sys_Vendor>();
                var i = (from p in ctx.DataContext.Sys_Vendor.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.VendorCode = i.VendorCode;
										this.VendorName = i.VendorName;
										this.VendGrpCode = i.VendGrpCode;
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

	public class Sys_VendorsFactory : Common.Business.Sys_Vendors
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_Vendor
                        select Sys_VendorFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_Vendor
                        select Sys_VendorFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_Vendor>();
                var i = (from p in ctx.DataContext.Sys_Vendor.Where(exp)
                         select Sys_VendorFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_Vendor>();
                var i = from p in ctx.DataContext.Sys_Vendor.Where(exp)
                         select Sys_VendorFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
