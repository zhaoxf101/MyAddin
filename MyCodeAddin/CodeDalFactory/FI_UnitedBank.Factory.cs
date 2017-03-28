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
	public class FI_UnitedBankFactory:Common.Business.FI_UnitedBank
    {
        public static Common.Business.FI_UnitedBank Fetch(FI_UnitedBank data)
        {
            Common.Business.FI_UnitedBank item = (Common.Business.FI_UnitedBank)Activator.CreateInstance(typeof(Common.Business.FI_UnitedBank));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.UnitedBankId = data.UnitedBankId;
				                item.BankName = data.BankName;
				                item.Memo = data.Memo;
				                item.BankId = data.BankId;
				                item.BankPName = data.BankPName;
				                item.AreaCode = data.AreaCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_UnitedBank>();
                var i = (from p in ctx.DataContext.FI_UnitedBank.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.UnitedBankId = i.UnitedBankId;
										this.BankName = i.BankName;
										this.Memo = i.Memo;
										this.BankId = i.BankId;
										this.BankPName = i.BankPName;
										this.AreaCode = i.AreaCode;
					}
            }
        }
	}

	public class FI_UnitedBanksFactory : Common.Business.FI_UnitedBanks
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_UnitedBank
                        select FI_UnitedBankFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_UnitedBank
                        select FI_UnitedBankFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_UnitedBank>();
                var i = (from p in ctx.DataContext.FI_UnitedBank.Where(exp)
                         select FI_UnitedBankFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_UnitedBank>();
                var i = from p in ctx.DataContext.FI_UnitedBank.Where(exp)
                         select FI_UnitedBankFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
