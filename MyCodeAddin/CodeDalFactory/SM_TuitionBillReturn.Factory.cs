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
	public class SM_TuitionBillReturnFactory:Common.Business.SM_TuitionBillReturn
    {
        public static Common.Business.SM_TuitionBillReturn Fetch(SM_TuitionBillReturn data)
        {
            Common.Business.SM_TuitionBillReturn item = (Common.Business.SM_TuitionBillReturn)Activator.CreateInstance(typeof(Common.Business.SM_TuitionBillReturn));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.TuitionBillNo = data.TuitionBillNo;
				                item.DealNo = data.DealNo;
				                item.StuentNo = data.StuentNo;
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
				var exp = lambda.Resolve<SM_TuitionBillReturn>();
                var i = (from p in ctx.DataContext.SM_TuitionBillReturn.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TuitionBillNo = i.TuitionBillNo;
										this.DealNo = i.DealNo;
										this.StuentNo = i.StuentNo;
										this.IsExternal = i.IsExternal;
										this.Amt = i.Amt;
					}
            }
        }
	}

	public class SM_TuitionBillReturnsFactory : Common.Business.SM_TuitionBillReturns
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_TuitionBillReturn
                        select SM_TuitionBillReturnFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_TuitionBillReturn
                        select SM_TuitionBillReturnFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_TuitionBillReturn>();
                var i = (from p in ctx.DataContext.SM_TuitionBillReturn.Where(exp)
                         select SM_TuitionBillReturnFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_TuitionBillReturn>();
                var i = from p in ctx.DataContext.SM_TuitionBillReturn.Where(exp)
                         select SM_TuitionBillReturnFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
