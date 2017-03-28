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
	public class HR_SalaryModeSubFactory:Common.Business.HR_SalaryModeSub
    {
        public static Common.Business.HR_SalaryModeSub Fetch(HR_SalaryModeSub data)
        {
            Common.Business.HR_SalaryModeSub item = (Common.Business.HR_SalaryModeSub)Activator.CreateInstance(typeof(Common.Business.HR_SalaryModeSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ModeCode = data.ModeCode;
				                item.SalaryItemCode = data.SalaryItemCode;
				                item.Sort = data.Sort;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemRow = data.ExpItemRow;
				                item.ExpItemCode = data.ExpItemCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SalaryModeSub>();
                var i = (from p in ctx.DataContext.HR_SalaryModeSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ModeCode = i.ModeCode;
										this.SalaryItemCode = i.SalaryItemCode;
										this.Sort = i.Sort;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ExpItemRow = i.ExpItemRow;
										this.ExpItemCode = i.ExpItemCode;
					}
            }
        }
	}

	public class HR_SalaryModeSubsFactory : Common.Business.HR_SalaryModeSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SalaryModeSub
                        select HR_SalaryModeSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SalaryModeSub
                        select HR_SalaryModeSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SalaryModeSub>();
                var i = (from p in ctx.DataContext.HR_SalaryModeSub.Where(exp)
                         select HR_SalaryModeSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SalaryModeSub>();
                var i = from p in ctx.DataContext.HR_SalaryModeSub.Where(exp)
                         select HR_SalaryModeSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
