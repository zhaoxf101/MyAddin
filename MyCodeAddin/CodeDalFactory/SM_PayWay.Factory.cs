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
	public class SM_PayWayFactory:Common.Business.SM_PayWay
    {
        public static Common.Business.SM_PayWay Fetch(SM_PayWay data)
        {
            Common.Business.SM_PayWay item = (Common.Business.SM_PayWay)Activator.CreateInstance(typeof(Common.Business.SM_PayWay));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.PayWayCode = data.PayWayCode;
				                item.PayWayName = data.PayWayName;
				                item.IsReturn = data.IsReturn;
				                item.AccCode = data.AccCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<SM_PayWay>();
                var i = (from p in ctx.DataContext.SM_PayWay.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.PayWayCode = i.PayWayCode;
										this.PayWayName = i.PayWayName;
										this.IsReturn = i.IsReturn;
										this.AccCode = i.AccCode;
					}
            }
        }
	}

	public class SM_PayWaysFactory : Common.Business.SM_PayWays
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_PayWay
                        select SM_PayWayFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_PayWay
                        select SM_PayWayFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_PayWay>();
                var i = (from p in ctx.DataContext.SM_PayWay.Where(exp)
                         select SM_PayWayFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_PayWay>();
                var i = from p in ctx.DataContext.SM_PayWay.Where(exp)
                         select SM_PayWayFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
