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
	public class zbumenFactory:Common.Business.zbumen
    {
        public static Common.Business.zbumen Fetch(zbumen data)
        {
            Common.Business.zbumen item = (Common.Business.zbumen)Activator.CreateInstance(typeof(Common.Business.zbumen));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.DepCode = data.DepCode;
				                item.DepName = data.DepName;
				                item.DepLeader = data.DepLeader;
				                item.DepTypeCode = data.DepTypeCode;
				                item.DepLevel = data.DepLevel;
				                item.CostCtr = data.CostCtr;
				                item.ProfitCtr = data.ProfitCtr;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<zbumen>();
                var i = (from p in ctx.DataContext.zbumen.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.DepCode = i.DepCode;
										this.DepName = i.DepName;
										this.DepLeader = i.DepLeader;
										this.DepTypeCode = i.DepTypeCode;
										this.DepLevel = i.DepLevel;
										this.CostCtr = i.CostCtr;
										this.ProfitCtr = i.ProfitCtr;
					}
            }
        }
	}

	public class zbumensFactory : Common.Business.zbumens
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.zbumen
                        select zbumenFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.zbumen
                        select zbumenFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<zbumen>();
                var i = (from p in ctx.DataContext.zbumen.Where(exp)
                         select zbumenFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<zbumen>();
                var i = from p in ctx.DataContext.zbumen.Where(exp)
                         select zbumenFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
