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
	public class HR_SalaryConfirmDetailFactory:Common.Business.HR_SalaryConfirmDetail
    {
        public static Common.Business.HR_SalaryConfirmDetail Fetch(HR_SalaryConfirmDetail data)
        {
            Common.Business.HR_SalaryConfirmDetail item = (Common.Business.HR_SalaryConfirmDetail)Activator.CreateInstance(typeof(Common.Business.HR_SalaryConfirmDetail));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.SalaryPeriod = data.SalaryPeriod;
				                item.SalaryRanage = data.SalaryRanage;
				                item.EmpCode = data.EmpCode;
				                item.SalaryItemCode = data.SalaryItemCode;
				                item.SalaryConfirmType = data.SalaryConfirmType;
				                item.Amt = data.Amt;
				                item.Memo = data.Memo;
				                item.BillNo = data.BillNo;
				                item.IsConfirm = data.IsConfirm;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SalaryConfirmDetail>();
                var i = (from p in ctx.DataContext.HR_SalaryConfirmDetail.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.SalaryPeriod = i.SalaryPeriod;
										this.SalaryRanage = i.SalaryRanage;
										this.EmpCode = i.EmpCode;
										this.SalaryItemCode = i.SalaryItemCode;
										this.SalaryConfirmType = i.SalaryConfirmType;
										this.Amt = i.Amt;
										this.Memo = i.Memo;
										this.BillNo = i.BillNo;
										this.IsConfirm = i.IsConfirm;
					}
            }
        }
	}

	public class HR_SalaryConfirmDetailsFactory : Common.Business.HR_SalaryConfirmDetails
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SalaryConfirmDetail
                        select HR_SalaryConfirmDetailFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SalaryConfirmDetail
                        select HR_SalaryConfirmDetailFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SalaryConfirmDetail>();
                var i = (from p in ctx.DataContext.HR_SalaryConfirmDetail.Where(exp)
                         select HR_SalaryConfirmDetailFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SalaryConfirmDetail>();
                var i = from p in ctx.DataContext.HR_SalaryConfirmDetail.Where(exp)
                         select HR_SalaryConfirmDetailFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
