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
	public class FI_BKACTFactory:Common.Business.FI_BKACT
    {
        public static Common.Business.FI_BKACT Fetch(FI_BKACT data)
        {
            Common.Business.FI_BKACT item = (Common.Business.FI_BKACT)Activator.CreateInstance(typeof(Common.Business.FI_BKACT));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Bank = data.Bank;
				                item.BAID = data.BAID;
				                item.BkSim = data.BkSim;
				                item.BAccount = data.BAccount;
				                item.BankOrg = data.BankOrg;
				                item.Curr = data.Curr;
				                item.BKACTypeCode = data.BKACTypeCode;
				                item.AccCode = data.AccCode;
				                item.BAccCode = data.BAccCode;
				                item.Purpose = data.Purpose;
				                item.LText = data.LText;
				                item.Active = data.Active;
				                item.IsZero = data.IsZero;
				                item.DisplayOrder = data.DisplayOrder;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.UserType = data.UserType;
				                item.Sort = data.Sort;
				                item.CheckAmt = data.CheckAmt;
				                item.IsMainBank = data.IsMainBank;
				                item.BKCode = data.BKCode;
				                item.SynDate = data.SynDate;
				                item.LastUser = data.LastUser;
				                item.LastDate = data.LastDate;
				                item.UnitedBankId = data.UnitedBankId;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_BKACT>();
                var i = (from p in ctx.DataContext.FI_BKACT.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Bank = i.Bank;
										this.BAID = i.BAID;
										this.BkSim = i.BkSim;
										this.BAccount = i.BAccount;
										this.BankOrg = i.BankOrg;
										this.Curr = i.Curr;
										this.BKACTypeCode = i.BKACTypeCode;
										this.AccCode = i.AccCode;
										this.BAccCode = i.BAccCode;
										this.Purpose = i.Purpose;
										this.LText = i.LText;
										this.Active = i.Active;
										this.IsZero = i.IsZero;
										this.DisplayOrder = i.DisplayOrder;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.UserType = i.UserType;
										this.Sort = i.Sort;
										this.CheckAmt = i.CheckAmt;
										this.IsMainBank = i.IsMainBank;
										this.BKCode = i.BKCode;
										this.SynDate = i.SynDate;
										this.LastUser = i.LastUser;
										this.LastDate = i.LastDate;
										this.UnitedBankId = i.UnitedBankId;
					}
            }
        }
	}

	public class FI_BKACTsFactory : Common.Business.FI_BKACTs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BKACT
                        select FI_BKACTFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BKACT
                        select FI_BKACTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BKACT>();
                var i = (from p in ctx.DataContext.FI_BKACT.Where(exp)
                         select FI_BKACTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BKACT>();
                var i = from p in ctx.DataContext.FI_BKACT.Where(exp)
                         select FI_BKACTFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
