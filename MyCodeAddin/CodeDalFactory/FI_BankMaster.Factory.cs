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
	public class FI_BankMasterFactory:Common.Business.FI_BankMaster
    {
        public static Common.Business.FI_BankMaster Fetch(FI_BankMaster data)
        {
            Common.Business.FI_BankMaster item = (Common.Business.FI_BankMaster)Activator.CreateInstance(typeof(Common.Business.FI_BankMaster));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.BankId = data.BankId;
				                item.BankName = data.BankName;
				                item.UnitedBankId = data.UnitedBankId;
				                item.Sort = data.Sort;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_BankMaster>();
                var i = (from p in ctx.DataContext.FI_BankMaster.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.BankId = i.BankId;
										this.BankName = i.BankName;
										this.UnitedBankId = i.UnitedBankId;
										this.Sort = i.Sort;
					}
            }
        }
	}

	public class FI_BankMastersFactory : Common.Business.FI_BankMasters
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BankMaster
                        select FI_BankMasterFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BankMaster
                        select FI_BankMasterFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BankMaster>();
                var i = (from p in ctx.DataContext.FI_BankMaster.Where(exp)
                         select FI_BankMasterFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BankMaster>();
                var i = from p in ctx.DataContext.FI_BankMaster.Where(exp)
                         select FI_BankMasterFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
