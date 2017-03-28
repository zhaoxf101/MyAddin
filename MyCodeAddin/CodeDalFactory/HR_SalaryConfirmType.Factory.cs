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
	public class HR_SalaryConfirmTypeFactory:Common.Business.HR_SalaryConfirmType
    {
        public static Common.Business.HR_SalaryConfirmType Fetch(HR_SalaryConfirmType data)
        {
            Common.Business.HR_SalaryConfirmType item = (Common.Business.HR_SalaryConfirmType)Activator.CreateInstance(typeof(Common.Business.HR_SalaryConfirmType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SalaryConfirmType = data.SalaryConfirmType;
				                item.DText = data.DText;
				                item.SalaryRanageCode = data.SalaryRanageCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SalaryConfirmType>();
                var i = (from p in ctx.DataContext.HR_SalaryConfirmType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SalaryConfirmType = i.SalaryConfirmType;
										this.DText = i.DText;
										this.SalaryRanageCode = i.SalaryRanageCode;
					}
            }
        }
	}

	public class HR_SalaryConfirmTypesFactory : Common.Business.HR_SalaryConfirmTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SalaryConfirmType
                        select HR_SalaryConfirmTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SalaryConfirmType
                        select HR_SalaryConfirmTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SalaryConfirmType>();
                var i = (from p in ctx.DataContext.HR_SalaryConfirmType.Where(exp)
                         select HR_SalaryConfirmTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SalaryConfirmType>();
                var i = from p in ctx.DataContext.HR_SalaryConfirmType.Where(exp)
                         select HR_SalaryConfirmTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
