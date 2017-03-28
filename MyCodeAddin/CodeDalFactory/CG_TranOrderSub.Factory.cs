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
	public class CG_TranOrderSubFactory:Common.Business.CG_TranOrderSub
    {
        public static Common.Business.CG_TranOrderSub Fetch(CG_TranOrderSub data)
        {
            Common.Business.CG_TranOrderSub item = (Common.Business.CG_TranOrderSub)Activator.CreateInstance(typeof(Common.Business.CG_TranOrderSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.TranOrderId = data.TranOrderId;
				                item.TranOrderNo = data.TranOrderNo;
				                item.OrderId = data.OrderId;
				                item.OrderNo = data.OrderNo;
				                item.FeeItemCode = data.FeeItemCode;
				                item.IntervalCode = data.IntervalCode;
				                item.PersonId = data.PersonId;
				                item.Amt = data.Amt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CG_TranOrderSub>();
                var i = (from p in ctx.DataContext.CG_TranOrderSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.TranOrderId = i.TranOrderId;
										this.TranOrderNo = i.TranOrderNo;
										this.OrderId = i.OrderId;
										this.OrderNo = i.OrderNo;
										this.FeeItemCode = i.FeeItemCode;
										this.IntervalCode = i.IntervalCode;
										this.PersonId = i.PersonId;
										this.Amt = i.Amt;
					}
            }
        }
	}

	public class CG_TranOrderSubsFactory : Common.Business.CG_TranOrderSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CG_TranOrderSub
                        select CG_TranOrderSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CG_TranOrderSub
                        select CG_TranOrderSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CG_TranOrderSub>();
                var i = (from p in ctx.DataContext.CG_TranOrderSub.Where(exp)
                         select CG_TranOrderSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CG_TranOrderSub>();
                var i = from p in ctx.DataContext.CG_TranOrderSub.Where(exp)
                         select CG_TranOrderSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
