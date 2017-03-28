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
	public class SM_TuitionByClassFactory:Common.Business.SM_TuitionByClass
    {
        public static Common.Business.SM_TuitionByClass Fetch(SM_TuitionByClass data)
        {
            Common.Business.SM_TuitionByClass item = (Common.Business.SM_TuitionByClass)Activator.CreateInstance(typeof(Common.Business.SM_TuitionByClass));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Year = data.Year;
				                item.ClassCode = data.ClassCode;
				                item.FeeItemCode = data.FeeItemCode;
				                item.LAmt = data.LAmt;
				                item.CAmt = data.CAmt;
				                item.OAmt = data.OAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<SM_TuitionByClass>();
                var i = (from p in ctx.DataContext.SM_TuitionByClass.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Year = i.Year;
										this.ClassCode = i.ClassCode;
										this.FeeItemCode = i.FeeItemCode;
										this.LAmt = i.LAmt;
										this.CAmt = i.CAmt;
										this.OAmt = i.OAmt;
					}
            }
        }
	}

	public class SM_TuitionByClasssFactory : Common.Business.SM_TuitionByClasss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_TuitionByClass
                        select SM_TuitionByClassFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_TuitionByClass
                        select SM_TuitionByClassFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_TuitionByClass>();
                var i = (from p in ctx.DataContext.SM_TuitionByClass.Where(exp)
                         select SM_TuitionByClassFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_TuitionByClass>();
                var i = from p in ctx.DataContext.SM_TuitionByClass.Where(exp)
                         select SM_TuitionByClassFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
