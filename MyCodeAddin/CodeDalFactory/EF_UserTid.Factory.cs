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
	public class EF_UserTidFactory:Common.Business.EF_UserTid
    {
        public static Common.Business.EF_UserTid Fetch(EF_UserTid data)
        {
            Common.Business.EF_UserTid item = (Common.Business.EF_UserTid)Activator.CreateInstance(typeof(Common.Business.EF_UserTid));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Tid = data.Tid;
				                item.Client = data.Client;
				                item.BName = data.BName;
				                item.UIType = data.UIType;
				                item.MachineId = data.MachineId;
				                item.IpAddress = data.IpAddress;
				                item.LoginDate = data.LoginDate;
				                item.LogoutDate = data.LogoutDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_UserTid>();
                var i = (from p in ctx.DataContext.EF_UserTid.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Tid = i.Tid;
										this.Client = i.Client;
										this.BName = i.BName;
										this.UIType = i.UIType;
										this.MachineId = i.MachineId;
										this.IpAddress = i.IpAddress;
										this.LoginDate = i.LoginDate;
										this.LogoutDate = i.LogoutDate;
					}
            }
        }
	}

	public class EF_UserTidsFactory : Common.Business.EF_UserTids
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_UserTid
                        select EF_UserTidFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_UserTid
                        select EF_UserTidFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_UserTid>();
                var i = (from p in ctx.DataContext.EF_UserTid.Where(exp)
                         select EF_UserTidFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_UserTid>();
                var i = from p in ctx.DataContext.EF_UserTid.Where(exp)
                         select EF_UserTidFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
