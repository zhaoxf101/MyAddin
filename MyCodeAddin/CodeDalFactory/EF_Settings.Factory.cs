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
	public class EF_SettingsFactory:Common.Business.EF_Settings
    {
        public static Common.Business.EF_Settings Fetch(EF_Settings data)
        {
            Common.Business.EF_Settings item = (Common.Business.EF_Settings)Activator.CreateInstance(typeof(Common.Business.EF_Settings));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ParaName = data.ParaName;
				                item.AGBlock = data.AGBlock;
				                item.ClientX = data.ClientX;
				                item.ParaType = data.ParaType;
				                item.DText = data.DText;
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
				var exp = lambda.Resolve<EF_Settings>();
                var i = (from p in ctx.DataContext.EF_Settings.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ParaName = i.ParaName;
										this.AGBlock = i.AGBlock;
										this.ClientX = i.ClientX;
										this.ParaType = i.ParaType;
										this.DText = i.DText;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class EF_SettingssFactory : Common.Business.EF_Settingss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_Settings
                        select EF_SettingsFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_Settings
                        select EF_SettingsFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_Settings>();
                var i = (from p in ctx.DataContext.EF_Settings.Where(exp)
                         select EF_SettingsFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_Settings>();
                var i = from p in ctx.DataContext.EF_Settings.Where(exp)
                         select EF_SettingsFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
