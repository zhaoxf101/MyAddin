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
	public class FI_ExpBusContPayTermFactory:Common.Business.FI_ExpBusContPayTerm
    {
        public static Common.Business.FI_ExpBusContPayTerm Fetch(FI_ExpBusContPayTerm data)
        {
            Common.Business.FI_ExpBusContPayTerm item = (Common.Business.FI_ExpBusContPayTerm)Activator.CreateInstance(typeof(Common.Business.FI_ExpBusContPayTerm));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpBusCode = data.ExpBusCode;
				                item.ContractId = data.ContractId;
				                item.PayItemCode = data.PayItemCode;
				                item.PayNo = data.PayNo;
				                item.Amt = data.Amt;
				                item.IsExp = data.IsExp;
				                item.IsOther = data.IsOther;
				                item.ActAmt = data.ActAmt;
				                item.OrdAmt = data.OrdAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ExpBusContPayTerm>();
                var i = (from p in ctx.DataContext.FI_ExpBusContPayTerm.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpBusCode = i.ExpBusCode;
										this.ContractId = i.ContractId;
										this.PayItemCode = i.PayItemCode;
										this.PayNo = i.PayNo;
										this.Amt = i.Amt;
										this.IsExp = i.IsExp;
										this.IsOther = i.IsOther;
										this.ActAmt = i.ActAmt;
										this.OrdAmt = i.OrdAmt;
					}
            }
        }
	}

	public class FI_ExpBusContPayTermsFactory : Common.Business.FI_ExpBusContPayTerms
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpBusContPayTerm
                        select FI_ExpBusContPayTermFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpBusContPayTerm
                        select FI_ExpBusContPayTermFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpBusContPayTerm>();
                var i = (from p in ctx.DataContext.FI_ExpBusContPayTerm.Where(exp)
                         select FI_ExpBusContPayTermFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpBusContPayTerm>();
                var i = from p in ctx.DataContext.FI_ExpBusContPayTerm.Where(exp)
                         select FI_ExpBusContPayTermFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
