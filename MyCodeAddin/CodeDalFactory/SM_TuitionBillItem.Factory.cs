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
	public class SM_TuitionBillItemFactory:Common.Business.SM_TuitionBillItem
    {
        public static Common.Business.SM_TuitionBillItem Fetch(SM_TuitionBillItem data)
        {
            Common.Business.SM_TuitionBillItem item = (Common.Business.SM_TuitionBillItem)Activator.CreateInstance(typeof(Common.Business.SM_TuitionBillItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.TuitionBillNo = data.TuitionBillNo;
				                item.ClassCode = data.ClassCode;
				                item.FeeItemCode = data.FeeItemCode;
				                item.PayWayCode = data.PayWayCode;
				                item.ProfitCtr = data.ProfitCtr;
				                item.IsExternal = data.IsExternal;
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
				var exp = lambda.Resolve<SM_TuitionBillItem>();
                var i = (from p in ctx.DataContext.SM_TuitionBillItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TuitionBillNo = i.TuitionBillNo;
										this.ClassCode = i.ClassCode;
										this.FeeItemCode = i.FeeItemCode;
										this.PayWayCode = i.PayWayCode;
										this.ProfitCtr = i.ProfitCtr;
										this.IsExternal = i.IsExternal;
										this.Amt = i.Amt;
					}
            }
        }
	}

	public class SM_TuitionBillItemsFactory : Common.Business.SM_TuitionBillItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_TuitionBillItem
                        select SM_TuitionBillItemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_TuitionBillItem
                        select SM_TuitionBillItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_TuitionBillItem>();
                var i = (from p in ctx.DataContext.SM_TuitionBillItem.Where(exp)
                         select SM_TuitionBillItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_TuitionBillItem>();
                var i = from p in ctx.DataContext.SM_TuitionBillItem.Where(exp)
                         select SM_TuitionBillItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
