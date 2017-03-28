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
	public class UP_AppVersionFactory:Common.Business.UP_AppVersion
    {
        public static Common.Business.UP_AppVersion Fetch(UP_AppVersion data)
        {
            Common.Business.UP_AppVersion item = (Common.Business.UP_AppVersion)Activator.CreateInstance(typeof(Common.Business.UP_AppVersion));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Id = data.Id;
				                item.AppCode = data.AppCode;
				                item.AppName = data.AppName;
				                item.AppType = data.AppType;
				                item.AppVer = data.AppVer;
				                item.AppPath = data.AppPath;
				                item.UpgradeContent = data.UpgradeContent;
				                item.IsForce = data.IsForce;
				                item.RowStatus = data.RowStatus;
				                item.CreateUser = data.CreateUser;
				                item.CreateDate = data.CreateDate;
				                item.ChangeUser = data.ChangeUser;
				                item.ChangeDate = data.ChangeDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<UP_AppVersion>();
                var i = (from p in ctx.DataContext.UP_AppVersion.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Id = i.Id;
										this.AppCode = i.AppCode;
										this.AppName = i.AppName;
										this.AppType = i.AppType;
										this.AppVer = i.AppVer;
										this.AppPath = i.AppPath;
										this.UpgradeContent = i.UpgradeContent;
										this.IsForce = i.IsForce;
										this.RowStatus = i.RowStatus;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
					}
            }
        }
	}

	public class UP_AppVersionsFactory : Common.Business.UP_AppVersions
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_AppVersion
                        select UP_AppVersionFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_AppVersion
                        select UP_AppVersionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_AppVersion>();
                var i = (from p in ctx.DataContext.UP_AppVersion.Where(exp)
                         select UP_AppVersionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_AppVersion>();
                var i = from p in ctx.DataContext.UP_AppVersion.Where(exp)
                         select UP_AppVersionFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
