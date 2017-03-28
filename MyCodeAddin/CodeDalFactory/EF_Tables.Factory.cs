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
	public class EF_TablesFactory:Common.Business.EF_Tables
    {
        public static Common.Business.EF_Tables Fetch(EF_Tables data)
        {
            Common.Business.EF_Tables item = (Common.Business.EF_Tables)Activator.CreateInstance(typeof(Common.Business.EF_Tables));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TableName = data.TableName;
				                item.Active = data.Active;
				                item.DText = data.DText;
				                item.TabClass = data.TabClass;
				                item.MainFlag = data.MainFlag;
				                item.ConFlag = data.ConFlag;
				                item.LastUser = data.LastUser;
				                item.LastDate = data.LastDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_Tables>();
                var i = (from p in ctx.DataContext.EF_Tables.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TableName = i.TableName;
										this.Active = i.Active;
										this.DText = i.DText;
										this.TabClass = i.TabClass;
										this.MainFlag = i.MainFlag;
										this.ConFlag = i.ConFlag;
										this.LastUser = i.LastUser;
										this.LastDate = i.LastDate;
					}
            }
        }
	}

	public class EF_TablessFactory : Common.Business.EF_Tabless
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_Tables
                        select EF_TablesFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_Tables
                        select EF_TablesFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_Tables>();
                var i = (from p in ctx.DataContext.EF_Tables.Where(exp)
                         select EF_TablesFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_Tables>();
                var i = from p in ctx.DataContext.EF_Tables.Where(exp)
                         select EF_TablesFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
