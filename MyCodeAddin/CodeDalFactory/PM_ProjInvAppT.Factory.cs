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
	public class PM_ProjInvAppTFactory:Common.Business.PM_ProjInvAppT
    {
        public static Common.Business.PM_ProjInvAppT Fetch(PM_ProjInvAppT data)
        {
            Common.Business.PM_ProjInvAppT item = (Common.Business.PM_ProjInvAppT)Activator.CreateInstance(typeof(Common.Business.PM_ProjInvAppT));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ProjIncAppNo = data.ProjIncAppNo;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.FDAmt = data.FDAmt;
				                item.IncAppAmt = data.IncAppAmt;
				                item.DptCode = data.DptCode;
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
				var exp = lambda.Resolve<PM_ProjInvAppT>();
                var i = (from p in ctx.DataContext.PM_ProjInvAppT.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ProjIncAppNo = i.ProjIncAppNo;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.FDAmt = i.FDAmt;
										this.IncAppAmt = i.IncAppAmt;
										this.DptCode = i.DptCode;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_ProjInvAppTsFactory : Common.Business.PM_ProjInvAppTs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ProjInvAppT
                        select PM_ProjInvAppTFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ProjInvAppT
                        select PM_ProjInvAppTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ProjInvAppT>();
                var i = (from p in ctx.DataContext.PM_ProjInvAppT.Where(exp)
                         select PM_ProjInvAppTFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ProjInvAppT>();
                var i = from p in ctx.DataContext.PM_ProjInvAppT.Where(exp)
                         select PM_ProjInvAppTFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
