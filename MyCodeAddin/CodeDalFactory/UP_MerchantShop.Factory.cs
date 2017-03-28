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
	public class UP_MerchantShopFactory:Common.Business.UP_MerchantShop
    {
        public static Common.Business.UP_MerchantShop Fetch(UP_MerchantShop data)
        {
            Common.Business.UP_MerchantShop item = (Common.Business.UP_MerchantShop)Activator.CreateInstance(typeof(Common.Business.UP_MerchantShop));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.ShopCode = data.ShopCode;
				                item.ShopName = data.ShopName;
				                item.Address = data.Address;
				                item.PhoneNo = data.PhoneNo;
				                item.ImageUrl = data.ImageUrl;
				                item.RDepCode = data.RDepCode;
				                item.Leader = data.Leader;
				                item.MerchantId = data.MerchantId;
				                item.ShopTypeId = data.ShopTypeId;
				                item.AreaId = data.AreaId;
				                item.Remark = data.Remark;
				                item.Longitude = data.Longitude;
				                item.Latitude = data.Latitude;
				                item.RowStatus = data.RowStatus;
				                item.CreateUser = data.CreateUser;
				                item.CreateDate = data.CreateDate;
				                item.ChangeUser = data.ChangeUser;
				                item.ChangeDate = data.ChangeDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<UP_MerchantShop>();
                var i = (from p in ctx.DataContext.UP_MerchantShop.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.ShopCode = i.ShopCode;
										this.ShopName = i.ShopName;
										this.Address = i.Address;
										this.PhoneNo = i.PhoneNo;
										this.ImageUrl = i.ImageUrl;
										this.RDepCode = i.RDepCode;
										this.Leader = i.Leader;
										this.MerchantId = i.MerchantId;
										this.ShopTypeId = i.ShopTypeId;
										this.AreaId = i.AreaId;
										this.Remark = i.Remark;
										this.Longitude = i.Longitude;
										this.Latitude = i.Latitude;
										this.RowStatus = i.RowStatus;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
					}
            }
        }
	}

	public class UP_MerchantShopsFactory : Common.Business.UP_MerchantShops
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_MerchantShop
                        select UP_MerchantShopFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_MerchantShop
                        select UP_MerchantShopFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_MerchantShop>();
                var i = (from p in ctx.DataContext.UP_MerchantShop.Where(exp)
                         select UP_MerchantShopFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_MerchantShop>();
                var i = from p in ctx.DataContext.UP_MerchantShop.Where(exp)
                         select UP_MerchantShopFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
