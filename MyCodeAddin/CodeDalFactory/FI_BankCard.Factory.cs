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
	public class FI_BankCardFactory:Common.Business.FI_BankCard
    {
        public static Common.Business.FI_BankCard Fetch(FI_BankCard data)
        {
            Common.Business.FI_BankCard item = (Common.Business.FI_BankCard)Activator.CreateInstance(typeof(Common.Business.FI_BankCard));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Position = data.Position;
				                item.CardUserCode = data.CardUserCode;
				                item.CardUserType = data.CardUserType;
				                item.UnitedBankId1 = data.UnitedBankId1;
				                item.IsToPub = data.IsToPub;
				                item.BankCardNo = data.BankCardNo;
				                item.BankCardTypeCode = data.BankCardTypeCode;
				                item.BankName = data.BankName;
				                item.IsExpBus = data.IsExpBus;
				                item.IsSubsidy = data.IsSubsidy;
				                item.IsOriginal = data.IsOriginal;
				                item.OriginalBankCardNo = data.OriginalBankCardNo;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.UnitedBankId = data.UnitedBankId;
				                item.IsPublic = data.IsPublic;
				                item.IsOffCard = data.IsOffCard;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_BankCard>();
                var i = (from p in ctx.DataContext.FI_BankCard.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Position = i.Position;
										this.CardUserCode = i.CardUserCode;
										this.CardUserType = i.CardUserType;
										this.UnitedBankId1 = i.UnitedBankId1;
										this.IsToPub = i.IsToPub;
										this.BankCardNo = i.BankCardNo;
										this.BankCardTypeCode = i.BankCardTypeCode;
										this.BankName = i.BankName;
										this.IsExpBus = i.IsExpBus;
										this.IsSubsidy = i.IsSubsidy;
										this.IsOriginal = i.IsOriginal;
										this.OriginalBankCardNo = i.OriginalBankCardNo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.UnitedBankId = i.UnitedBankId;
										this.IsPublic = i.IsPublic;
										this.IsOffCard = i.IsOffCard;
					}
            }
        }
	}

	public class FI_BankCardsFactory : Common.Business.FI_BankCards
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BankCard
                        select FI_BankCardFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BankCard
                        select FI_BankCardFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BankCard>();
                var i = (from p in ctx.DataContext.FI_BankCard.Where(exp)
                         select FI_BankCardFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BankCard>();
                var i = from p in ctx.DataContext.FI_BankCard.Where(exp)
                         select FI_BankCardFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
