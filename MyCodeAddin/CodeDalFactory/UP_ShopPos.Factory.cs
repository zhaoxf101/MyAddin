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
	public class UP_ShopPosFactory:Common.Business.UP_ShopPos
    {
        public static Common.Business.UP_ShopPos Fetch(UP_ShopPos data)
        {
            Common.Business.UP_ShopPos item = (Common.Business.UP_ShopPos)Activator.CreateInstance(typeof(Common.Business.UP_ShopPos));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.MerchantId = data.MerchantId;
				                item.ShopId = data.ShopId;
				                item.PosId = data.PosId;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.AccountGroupId = data.AccountGroupId;
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
				var exp = lambda.Resolve<UP_ShopPos>();
                var i = (from p in ctx.DataContext.UP_ShopPos.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.MerchantId = i.MerchantId;
										this.ShopId = i.ShopId;
										this.PosId = i.PosId;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.AccountGroupId = i.AccountGroupId;
										this.RowStatus = i.RowStatus;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
					}
            }
        }
	}

	public class UP_ShopPossFactory : Common.Business.UP_ShopPoss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_ShopPos
                        select UP_ShopPosFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_ShopPos
                        select UP_ShopPosFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_ShopPos>();
                var i = (from p in ctx.DataContext.UP_ShopPos.Where(exp)
                         select UP_ShopPosFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_ShopPos>();
                var i = from p in ctx.DataContext.UP_ShopPos.Where(exp)
                         select UP_ShopPosFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
