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
	public class EF_DomainFactory:Common.Business.EF_Domain
    {
        public static Common.Business.EF_Domain Fetch(EF_Domain data)
        {
            Common.Business.EF_Domain item = (Common.Business.EF_Domain)Activator.CreateInstance(typeof(Common.Business.EF_Domain));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Domain = data.Domain;
				                item.RowStatus = data.RowStatus;
				                item.DText = data.DText;
				                item.DataType = data.DataType;
				                item.Leng = data.Leng;
				                item.Decimals = data.Decimals;
				                item.NegFlagX = data.NegFlagX;
				                item.UpperCaseX = data.UpperCaseX;
				                item.ValExiX = data.ValExiX;
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
				var exp = lambda.Resolve<EF_Domain>();
                var i = (from p in ctx.DataContext.EF_Domain.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Domain = i.Domain;
										this.RowStatus = i.RowStatus;
										this.DText = i.DText;
										this.DataType = i.DataType;
										this.Leng = i.Leng;
										this.Decimals = i.Decimals;
										this.NegFlagX = i.NegFlagX;
										this.UpperCaseX = i.UpperCaseX;
										this.ValExiX = i.ValExiX;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class EF_DomainsFactory : Common.Business.EF_Domains
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_Domain
                        select EF_DomainFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_Domain
                        select EF_DomainFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_Domain>();
                var i = (from p in ctx.DataContext.EF_Domain.Where(exp)
                         select EF_DomainFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_Domain>();
                var i = from p in ctx.DataContext.EF_Domain.Where(exp)
                         select EF_DomainFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
