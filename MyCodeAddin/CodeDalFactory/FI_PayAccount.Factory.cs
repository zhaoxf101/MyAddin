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
	public class FI_PayAccountFactory:Common.Business.FI_PayAccount
    {
        public static Common.Business.FI_PayAccount Fetch(FI_PayAccount data)
        {
            Common.Business.FI_PayAccount item = (Common.Business.FI_PayAccount)Activator.CreateInstance(typeof(Common.Business.FI_PayAccount));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.VouchNo = data.VouchNo;
				                item.LineNR = data.LineNR;
				                item.PersonId = data.PersonId;
				                item.RAccount = data.RAccount;
				                item.RAccName = data.RAccName;
				                item.RBankName = data.RBankName;
				                item.RBankId = data.RBankId;
				                item.RUnitedBankId = data.RUnitedBankId;
				                item.IsPublic = data.IsPublic;
				                item.IsOffCard = data.IsOffCard;
				                item.Amt = data.Amt;
				                item.UseText = data.UseText;
				                item.ReqText = data.ReqText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_PayAccount>();
                var i = (from p in ctx.DataContext.FI_PayAccount.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.VouchNo = i.VouchNo;
										this.LineNR = i.LineNR;
										this.PersonId = i.PersonId;
										this.RAccount = i.RAccount;
										this.RAccName = i.RAccName;
										this.RBankName = i.RBankName;
										this.RBankId = i.RBankId;
										this.RUnitedBankId = i.RUnitedBankId;
										this.IsPublic = i.IsPublic;
										this.IsOffCard = i.IsOffCard;
										this.Amt = i.Amt;
										this.UseText = i.UseText;
										this.ReqText = i.ReqText;
					}
            }
        }
	}

	public class FI_PayAccountsFactory : Common.Business.FI_PayAccounts
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PayAccount
                        select FI_PayAccountFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PayAccount
                        select FI_PayAccountFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PayAccount>();
                var i = (from p in ctx.DataContext.FI_PayAccount.Where(exp)
                         select FI_PayAccountFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PayAccount>();
                var i = from p in ctx.DataContext.FI_PayAccount.Where(exp)
                         select FI_PayAccountFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
