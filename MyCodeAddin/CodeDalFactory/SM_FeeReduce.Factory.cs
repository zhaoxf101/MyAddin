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
	public class SM_FeeReduceFactory:Common.Business.SM_FeeReduce
    {
        public static Common.Business.SM_FeeReduce Fetch(SM_FeeReduce data)
        {
            Common.Business.SM_FeeReduce item = (Common.Business.SM_FeeReduce)Activator.CreateInstance(typeof(Common.Business.SM_FeeReduce));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ReduceCode = data.ReduceCode;
				                item.ReduceName = data.ReduceName;
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
				var exp = lambda.Resolve<SM_FeeReduce>();
                var i = (from p in ctx.DataContext.SM_FeeReduce.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ReduceCode = i.ReduceCode;
										this.ReduceName = i.ReduceName;
										this.Memo = i.Memo;
					}
            }
        }
	}

	public class SM_FeeReducesFactory : Common.Business.SM_FeeReduces
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_FeeReduce
                        select SM_FeeReduceFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_FeeReduce
                        select SM_FeeReduceFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_FeeReduce>();
                var i = (from p in ctx.DataContext.SM_FeeReduce.Where(exp)
                         select SM_FeeReduceFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_FeeReduce>();
                var i = from p in ctx.DataContext.SM_FeeReduce.Where(exp)
                         select SM_FeeReduceFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
