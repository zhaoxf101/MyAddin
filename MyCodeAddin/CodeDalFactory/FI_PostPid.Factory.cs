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
	public class FI_PostPidFactory:Common.Business.FI_PostPid
    {
        public static Common.Business.FI_PostPid Fetch(FI_PostPid data)
        {
            Common.Business.FI_PostPid item = (Common.Business.FI_PostPid)Activator.CreateInstance(typeof(Common.Business.FI_PostPid));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PostPidSet = data.PostPidSet;
				                item.AccType = data.AccType;
				                item.FYear1 = data.FYear1;
				                item.FPid1 = data.FPid1;
				                item.TYear1 = data.TYear1;
				                item.TPid1 = data.TPid1;
				                item.FYear2 = data.FYear2;
				                item.FPid2 = data.FPid2;
				                item.TYear2 = data.TYear2;
				                item.TPid2 = data.TPid2;
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
				var exp = lambda.Resolve<FI_PostPid>();
                var i = (from p in ctx.DataContext.FI_PostPid.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PostPidSet = i.PostPidSet;
										this.AccType = i.AccType;
										this.FYear1 = i.FYear1;
										this.FPid1 = i.FPid1;
										this.TYear1 = i.TYear1;
										this.TPid1 = i.TPid1;
										this.FYear2 = i.FYear2;
										this.FPid2 = i.FPid2;
										this.TYear2 = i.TYear2;
										this.TPid2 = i.TPid2;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_PostPidsFactory : Common.Business.FI_PostPids
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PostPid
                        select FI_PostPidFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PostPid
                        select FI_PostPidFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PostPid>();
                var i = (from p in ctx.DataContext.FI_PostPid.Where(exp)
                         select FI_PostPidFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PostPid>();
                var i = from p in ctx.DataContext.FI_PostPid.Where(exp)
                         select FI_PostPidFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
