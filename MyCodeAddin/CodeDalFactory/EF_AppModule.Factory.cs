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
	public class EF_AppModuleFactory:Common.Business.EF_AppModule
    {
        public static Common.Business.EF_AppModule Fetch(EF_AppModule data)
        {
            Common.Business.EF_AppModule item = (Common.Business.EF_AppModule)Activator.CreateInstance(typeof(Common.Business.EF_AppModule));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.AppName = data.AppName;
				                item.UIType = data.UIType;
				                item.AGBlock = data.AGBlock;
				                item.DText = data.DText;
				                item.PgmName = data.PgmName;
				                item.CallParams = data.CallParams;
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
				var exp = lambda.Resolve<EF_AppModule>();
                var i = (from p in ctx.DataContext.EF_AppModule.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.AppName = i.AppName;
										this.UIType = i.UIType;
										this.AGBlock = i.AGBlock;
										this.DText = i.DText;
										this.PgmName = i.PgmName;
										this.CallParams = i.CallParams;
										this.Memo = i.Memo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class EF_AppModulesFactory : Common.Business.EF_AppModules
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_AppModule
                        select EF_AppModuleFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_AppModule
                        select EF_AppModuleFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_AppModule>();
                var i = (from p in ctx.DataContext.EF_AppModule.Where(exp)
                         select EF_AppModuleFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_AppModule>();
                var i = from p in ctx.DataContext.EF_AppModule.Where(exp)
                         select EF_AppModuleFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
