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
	public class UP_MerchantFactory:Common.Business.UP_Merchant
    {
        public static Common.Business.UP_Merchant Fetch(UP_Merchant data)
        {
            Common.Business.UP_Merchant item = (Common.Business.UP_Merchant)Activator.CreateInstance(typeof(Common.Business.UP_Merchant));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Id = data.Id;
				                item.MerchantNo = data.MerchantNo;
				                item.MerchantName = data.MerchantName;
				                item.BusinessNo = data.BusinessNo;
				                item.Address = data.Address;
				                item.PhoneNo = data.PhoneNo;
				                item.ImageUrl = data.ImageUrl;
				                item.BusinessPerson = data.BusinessPerson;
				                item.IsRecMsg = data.IsRecMsg;
				                item.Remark = data.Remark;
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
				var exp = lambda.Resolve<UP_Merchant>();
                var i = (from p in ctx.DataContext.UP_Merchant.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Id = i.Id;
										this.MerchantNo = i.MerchantNo;
										this.MerchantName = i.MerchantName;
										this.BusinessNo = i.BusinessNo;
										this.Address = i.Address;
										this.PhoneNo = i.PhoneNo;
										this.ImageUrl = i.ImageUrl;
										this.BusinessPerson = i.BusinessPerson;
										this.IsRecMsg = i.IsRecMsg;
										this.Remark = i.Remark;
										this.RowStatus = i.RowStatus;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
					}
            }
        }
	}

	public class UP_MerchantsFactory : Common.Business.UP_Merchants
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_Merchant
                        select UP_MerchantFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_Merchant
                        select UP_MerchantFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_Merchant>();
                var i = (from p in ctx.DataContext.UP_Merchant.Where(exp)
                         select UP_MerchantFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_Merchant>();
                var i = from p in ctx.DataContext.UP_Merchant.Where(exp)
                         select UP_MerchantFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
