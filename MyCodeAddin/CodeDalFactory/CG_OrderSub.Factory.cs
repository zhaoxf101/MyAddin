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
	public class CG_OrderSubFactory:Common.Business.CG_OrderSub
    {
        public static Common.Business.CG_OrderSub Fetch(CG_OrderSub data)
        {
            Common.Business.CG_OrderSub item = (Common.Business.CG_OrderSub)Activator.CreateInstance(typeof(Common.Business.CG_OrderSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.OrderNo = data.OrderNo;
				                item.OrderAmt = data.OrderAmt;
				                item.AdjAmt = data.AdjAmt;
				                item.CAmt = data.CAmt;
				                item.PersonId = data.PersonId;
				                item.Memo = data.Memo;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CG_OrderSub>();
                var i = (from p in ctx.DataContext.CG_OrderSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.OrderNo = i.OrderNo;
										this.OrderAmt = i.OrderAmt;
										this.AdjAmt = i.AdjAmt;
										this.CAmt = i.CAmt;
										this.PersonId = i.PersonId;
										this.Memo = i.Memo;
					}
            }
        }
	}

	public class CG_OrderSubsFactory : Common.Business.CG_OrderSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CG_OrderSub
                        select CG_OrderSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CG_OrderSub
                        select CG_OrderSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CG_OrderSub>();
                var i = (from p in ctx.DataContext.CG_OrderSub.Where(exp)
                         select CG_OrderSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CG_OrderSub>();
                var i = from p in ctx.DataContext.CG_OrderSub.Where(exp)
                         select CG_OrderSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
