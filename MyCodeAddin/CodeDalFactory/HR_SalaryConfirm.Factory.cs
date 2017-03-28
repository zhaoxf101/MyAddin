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
	public class HR_SalaryConfirmFactory:Common.Business.HR_SalaryConfirm
    {
        public static Common.Business.HR_SalaryConfirm Fetch(HR_SalaryConfirm data)
        {
            Common.Business.HR_SalaryConfirm item = (Common.Business.HR_SalaryConfirm)Activator.CreateInstance(typeof(Common.Business.HR_SalaryConfirm));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SalaryPeriod = data.SalaryPeriod;
				                item.SalaryConfirmType = data.SalaryConfirmType;
				                item.SalaryRanageCode = data.SalaryRanageCode;
				                item.SText = data.SText;
				                item.IsSubmt = data.IsSubmt;
				                item.IsAppoved = data.IsAppoved;
				                item.RowStatus = data.RowStatus;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SalaryConfirm>();
                var i = (from p in ctx.DataContext.HR_SalaryConfirm.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SalaryPeriod = i.SalaryPeriod;
										this.SalaryConfirmType = i.SalaryConfirmType;
										this.SalaryRanageCode = i.SalaryRanageCode;
										this.SText = i.SText;
										this.IsSubmt = i.IsSubmt;
										this.IsAppoved = i.IsAppoved;
										this.RowStatus = i.RowStatus;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class HR_SalaryConfirmsFactory : Common.Business.HR_SalaryConfirms
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SalaryConfirm
                        select HR_SalaryConfirmFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SalaryConfirm
                        select HR_SalaryConfirmFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SalaryConfirm>();
                var i = (from p in ctx.DataContext.HR_SalaryConfirm.Where(exp)
                         select HR_SalaryConfirmFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SalaryConfirm>();
                var i = from p in ctx.DataContext.HR_SalaryConfirm.Where(exp)
                         select HR_SalaryConfirmFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
