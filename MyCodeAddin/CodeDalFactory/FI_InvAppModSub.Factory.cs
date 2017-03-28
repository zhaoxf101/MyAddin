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
	public class FI_InvAppModSubFactory:Common.Business.FI_InvAppModSub
    {
        public static Common.Business.FI_InvAppModSub Fetch(FI_InvAppModSub data)
        {
            Common.Business.FI_InvAppModSub item = (Common.Business.FI_InvAppModSub)Activator.CreateInstance(typeof(Common.Business.FI_InvAppModSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.InvAppModCode = data.InvAppModCode;
				                item.InvItemCode = data.InvItemCode;
				                item.CAccCode = data.CAccCode;
				                item.DAccCode = data.DAccCode;
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
				var exp = lambda.Resolve<FI_InvAppModSub>();
                var i = (from p in ctx.DataContext.FI_InvAppModSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.InvAppModCode = i.InvAppModCode;
										this.InvItemCode = i.InvItemCode;
										this.CAccCode = i.CAccCode;
										this.DAccCode = i.DAccCode;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_InvAppModSubsFactory : Common.Business.FI_InvAppModSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_InvAppModSub
                        select FI_InvAppModSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_InvAppModSub
                        select FI_InvAppModSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_InvAppModSub>();
                var i = (from p in ctx.DataContext.FI_InvAppModSub.Where(exp)
                         select FI_InvAppModSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_InvAppModSub>();
                var i = from p in ctx.DataContext.FI_InvAppModSub.Where(exp)
                         select FI_InvAppModSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
