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
	public class Sys_RelatedPartyFactory:Common.Business.Sys_RelatedParty
    {
        public static Common.Business.Sys_RelatedParty Fetch(Sys_RelatedParty data)
        {
            Common.Business.Sys_RelatedParty item = (Common.Business.Sys_RelatedParty)Activator.CreateInstance(typeof(Common.Business.Sys_RelatedParty));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.RelPartyCode = data.RelPartyCode;
				                item.RelPartyName = data.RelPartyName;
				                item.RelPartyGrpCode = data.RelPartyGrpCode;
				                item.OneTimeX = data.OneTimeX;
				                item.Title = data.Title;
				                item.IndexKey = data.IndexKey;
				                item.IDCode = data.IDCode;
				                item.City = data.City;
				                item.Address = data.Address;
				                item.Telphone = data.Telphone;
				                item.Email = data.Email;
				                item.IsDelete = data.IsDelete;
				                item.Memo = data.Memo;
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
				var exp = lambda.Resolve<Sys_RelatedParty>();
                var i = (from p in ctx.DataContext.Sys_RelatedParty.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.RelPartyCode = i.RelPartyCode;
										this.RelPartyName = i.RelPartyName;
										this.RelPartyGrpCode = i.RelPartyGrpCode;
										this.OneTimeX = i.OneTimeX;
										this.Title = i.Title;
										this.IndexKey = i.IndexKey;
										this.IDCode = i.IDCode;
										this.City = i.City;
										this.Address = i.Address;
										this.Telphone = i.Telphone;
										this.Email = i.Email;
										this.IsDelete = i.IsDelete;
										this.Memo = i.Memo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class Sys_RelatedPartysFactory : Common.Business.Sys_RelatedPartys
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_RelatedParty
                        select Sys_RelatedPartyFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_RelatedParty
                        select Sys_RelatedPartyFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_RelatedParty>();
                var i = (from p in ctx.DataContext.Sys_RelatedParty.Where(exp)
                         select Sys_RelatedPartyFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_RelatedParty>();
                var i = from p in ctx.DataContext.Sys_RelatedParty.Where(exp)
                         select Sys_RelatedPartyFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
