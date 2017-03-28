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
	public class UP_ChargeWayFactory:Common.Business.UP_ChargeWay
    {
        public static Common.Business.UP_ChargeWay Fetch(UP_ChargeWay data)
        {
            Common.Business.UP_ChargeWay item = (Common.Business.UP_ChargeWay)Activator.CreateInstance(typeof(Common.Business.UP_ChargeWay));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ChargeWayCode = data.ChargeWayCode;
				                item.ChargeWayName = data.ChargeWayName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<UP_ChargeWay>();
                var i = (from p in ctx.DataContext.UP_ChargeWay.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ChargeWayCode = i.ChargeWayCode;
										this.ChargeWayName = i.ChargeWayName;
					}
            }
        }
	}

	public class UP_ChargeWaysFactory : Common.Business.UP_ChargeWays
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.UP_ChargeWay
                        select UP_ChargeWayFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.UP_ChargeWay
                        select UP_ChargeWayFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<UP_ChargeWay>();
                var i = (from p in ctx.DataContext.UP_ChargeWay.Where(exp)
                         select UP_ChargeWayFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<UP_ChargeWay>();
                var i = from p in ctx.DataContext.UP_ChargeWay.Where(exp)
                         select UP_ChargeWayFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
