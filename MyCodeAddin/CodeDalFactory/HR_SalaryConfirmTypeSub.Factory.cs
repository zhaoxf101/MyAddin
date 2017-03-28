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
	public class HR_SalaryConfirmTypeSubFactory:Common.Business.HR_SalaryConfirmTypeSub
    {
        public static Common.Business.HR_SalaryConfirmTypeSub Fetch(HR_SalaryConfirmTypeSub data)
        {
            Common.Business.HR_SalaryConfirmTypeSub item = (Common.Business.HR_SalaryConfirmTypeSub)Activator.CreateInstance(typeof(Common.Business.HR_SalaryConfirmTypeSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SalaryConfirmType = data.SalaryConfirmType;
				                item.SalaryItemCode = data.SalaryItemCode;
				                item.Sort = data.Sort;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SalaryConfirmTypeSub>();
                var i = (from p in ctx.DataContext.HR_SalaryConfirmTypeSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SalaryConfirmType = i.SalaryConfirmType;
										this.SalaryItemCode = i.SalaryItemCode;
										this.Sort = i.Sort;
					}
            }
        }
	}

	public class HR_SalaryConfirmTypeSubsFactory : Common.Business.HR_SalaryConfirmTypeSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SalaryConfirmTypeSub
                        select HR_SalaryConfirmTypeSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SalaryConfirmTypeSub
                        select HR_SalaryConfirmTypeSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SalaryConfirmTypeSub>();
                var i = (from p in ctx.DataContext.HR_SalaryConfirmTypeSub.Where(exp)
                         select HR_SalaryConfirmTypeSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SalaryConfirmTypeSub>();
                var i = from p in ctx.DataContext.HR_SalaryConfirmTypeSub.Where(exp)
                         select HR_SalaryConfirmTypeSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
