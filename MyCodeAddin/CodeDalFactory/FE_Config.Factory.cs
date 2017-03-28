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
	public class FE_ConfigFactory:Common.Business.FE_Config
    {
        public static Common.Business.FE_Config Fetch(FE_Config data)
        {
            Common.Business.FE_Config item = (Common.Business.FE_Config)Activator.CreateInstance(typeof(Common.Business.FE_Config));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ConfigGroupCode = data.ConfigGroupCode;
				                item.ConfigCode = data.ConfigCode;
				                item.ConfigValue = data.ConfigValue;
				                item.ConfigName = data.ConfigName;
				                item.IsActive = data.IsActive;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_Config>();
                var i = (from p in ctx.DataContext.FE_Config.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ConfigGroupCode = i.ConfigGroupCode;
										this.ConfigCode = i.ConfigCode;
										this.ConfigValue = i.ConfigValue;
										this.ConfigName = i.ConfigName;
										this.IsActive = i.IsActive;
					}
            }
        }
	}

	public class FE_ConfigsFactory : Common.Business.FE_Configs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_Config
                        select FE_ConfigFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_Config
                        select FE_ConfigFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_Config>();
                var i = (from p in ctx.DataContext.FE_Config.Where(exp)
                         select FE_ConfigFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_Config>();
                var i = from p in ctx.DataContext.FE_Config.Where(exp)
                         select FE_ConfigFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
