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
	public class FI_AccCLTFactory:Common.Business.FI_AccCLT
    {
        public static Common.Business.FI_AccCLT Fetch(FI_AccCLT data)
        {
            Common.Business.FI_AccCLT item = (Common.Business.FI_AccCLT)Activator.CreateInstance(typeof(Common.Business.FI_AccCLT));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AccCode = data.AccCode;
				                item.AuthGrp = data.AuthGrp;
				                item.FieldGrp = data.FieldGrp;
				                item.RateDiffCode = data.RateDiffCode;
				                item.AccType = data.AccType;
				                item.TaxType = data.TaxType;
				                item.CurrCode = data.CurrCode;
				                item.CashFlowX = data.CashFlowX;
				                item.CashType = data.CashType;
				                item.OpenItemX = data.OpenItemX;
				                item.FundRelX = data.FundRelX;
				                item.AutoPostX = data.AutoPostX;
				                item.NoTaxPostX = data.NoTaxPostX;
				                item.FrozenX = data.FrozenX;
				                item.WDelX = data.WDelX;
				                item.BookType = data.BookType;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_AccCLT>();
                var i = (from p in ctx.DataContext.FI_AccCLT.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AccCode = i.AccCode;
										this.AuthGrp = i.AuthGrp;
										this.FieldGrp = i.FieldGrp;
										this.RateDiffCode = i.RateDiffCode;
										this.AccType = i.AccType;
										this.TaxType = i.TaxType;
										this.CurrCode = i.CurrCode;
										this.CashFlowX = i.CashFlowX;
										this.CashType = i.CashType;
										this.OpenItemX = i.OpenItemX;
										this.FundRelX = i.FundRelX;
										this.AutoPostX = i.AutoPostX;
										this.NoTaxPostX = i.NoTaxPostX;
										this.FrozenX = i.FrozenX;
										this.WDelX = i.WDelX;
										this.BookType = i.BookType;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_AccCLTsFactory : Common.Business.FI_AccCLTs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_AccCLT
                        select FI_AccCLTFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_AccCLT
                        select FI_AccCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_AccCLT>();
                var i = (from p in ctx.DataContext.FI_AccCLT.Where(exp)
                         select FI_AccCLTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_AccCLT>();
                var i = from p in ctx.DataContext.FI_AccCLT.Where(exp)
                         select FI_AccCLTFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
