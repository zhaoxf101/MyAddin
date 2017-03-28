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
	public class FI_BankOrgIINFactory:Common.Business.FI_BankOrgIIN
    {
        public static Common.Business.FI_BankOrgIIN Fetch(FI_BankOrgIIN data)
        {
            Common.Business.FI_BankOrgIIN item = (Common.Business.FI_BankOrgIIN)Activator.CreateInstance(typeof(Common.Business.FI_BankOrgIIN));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.BankOrgCode = data.BankOrgCode;
				                item.BankIINCode = data.BankIINCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_BankOrgIIN>();
                var i = (from p in ctx.DataContext.FI_BankOrgIIN.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.BankOrgCode = i.BankOrgCode;
										this.BankIINCode = i.BankIINCode;
					}
            }
        }
	}

	public class FI_BankOrgIINsFactory : Common.Business.FI_BankOrgIINs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BankOrgIIN
                        select FI_BankOrgIINFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BankOrgIIN
                        select FI_BankOrgIINFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BankOrgIIN>();
                var i = (from p in ctx.DataContext.FI_BankOrgIIN.Where(exp)
                         select FI_BankOrgIINFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BankOrgIIN>();
                var i = from p in ctx.DataContext.FI_BankOrgIIN.Where(exp)
                         select FI_BankOrgIINFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
