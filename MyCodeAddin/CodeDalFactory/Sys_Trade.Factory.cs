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
	public class Sys_TradeFactory:Common.Business.Sys_Trade
    {
        public static Common.Business.Sys_Trade Fetch(Sys_Trade data)
        {
            Common.Business.Sys_Trade item = (Common.Business.Sys_Trade)Activator.CreateInstance(typeof(Common.Business.Sys_Trade));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TradeCode = data.TradeCode;
				                item.TradeName = data.TradeName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Sys_Trade>();
                var i = (from p in ctx.DataContext.Sys_Trade.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TradeCode = i.TradeCode;
										this.TradeName = i.TradeName;
					}
            }
        }
	}

	public class Sys_TradesFactory : Common.Business.Sys_Trades
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_Trade
                        select Sys_TradeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_Trade
                        select Sys_TradeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_Trade>();
                var i = (from p in ctx.DataContext.Sys_Trade.Where(exp)
                         select Sys_TradeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_Trade>();
                var i = from p in ctx.DataContext.Sys_Trade.Where(exp)
                         select Sys_TradeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
