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
	public class UP_UserCardFactory:Common.Business.UP_UserCard
    {
        public static Common.Business.UP_UserCard Fetch(UP_UserCard data)
        {
            Common.Business.UP_UserCard item = (Common.Business.UP_UserCard)Activator.CreateInstance(typeof(Common.Business.UP_UserCard));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.UserCode = data.UserCode;
				                item.AccountId = data.AccountId;
				                item.CardId = data.CardId;
				                item.LossTime = data.LossTime;
				                item.StartTime = data.StartTime;
				                item.EndTime = data.EndTime;
				                item.Status = data.Status;
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
				var exp = lambda.Resolve<UP_UserCard>();
                var i = (from p in ctx.DataContext.UP_UserCard.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.UserCode = i.UserCode;
										this.AccountId = i.AccountId;
										this.CardId = i.CardId;
										this.LossTime = i.LossTime;
										this.StartTime = i.StartTime;
										this.EndTime = i.EndTime;
										this.Status = i.Status;
										this.RowStatus = i.RowStatus;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
					}
            }
        }
	}

	public class UP_UserCardsFactory : Common.Business.UP_UserCards
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_UserCard
                        select UP_UserCardFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_UserCard
                        select UP_UserCardFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_UserCard>();
                var i = (from p in ctx.DataContext.UP_UserCard.Where(exp)
                         select UP_UserCardFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_UserCard>();
                var i = from p in ctx.DataContext.UP_UserCard.Where(exp)
                         select UP_UserCardFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
