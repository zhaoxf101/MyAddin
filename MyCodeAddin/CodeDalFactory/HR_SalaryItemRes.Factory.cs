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
	public class HR_SalaryItemResFactory:Common.Business.HR_SalaryItemRes
    {
        public static Common.Business.HR_SalaryItemRes Fetch(HR_SalaryItemRes data)
        {
            Common.Business.HR_SalaryItemRes item = (Common.Business.HR_SalaryItemRes)Activator.CreateInstance(typeof(Common.Business.HR_SalaryItemRes));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ResouItemCode = data.ResouItemCode;
				                item.SumGroup = data.SumGroup;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SalaryItemRes>();
                var i = (from p in ctx.DataContext.HR_SalaryItemRes.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ResouItemCode = i.ResouItemCode;
										this.SumGroup = i.SumGroup;
					}
            }
        }
	}

	public class HR_SalaryItemRessFactory : Common.Business.HR_SalaryItemRess
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SalaryItemRes
                        select HR_SalaryItemResFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SalaryItemRes
                        select HR_SalaryItemResFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SalaryItemRes>();
                var i = (from p in ctx.DataContext.HR_SalaryItemRes.Where(exp)
                         select HR_SalaryItemResFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SalaryItemRes>();
                var i = from p in ctx.DataContext.HR_SalaryItemRes.Where(exp)
                         select HR_SalaryItemResFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
