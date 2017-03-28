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
	public class HR_SalaryModeFactory:Common.Business.HR_SalaryMode
    {
        public static Common.Business.HR_SalaryMode Fetch(HR_SalaryMode data)
        {
            Common.Business.HR_SalaryMode item = (Common.Business.HR_SalaryMode)Activator.CreateInstance(typeof(Common.Business.HR_SalaryMode));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ModeCode = data.ModeCode;
				                item.ModeText = data.ModeText;
				                item.StatusCode = data.StatusCode;
				                item.StaffTypeCode = data.StaffTypeCode;
				                item.IsListPer = data.IsListPer;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SalaryMode>();
                var i = (from p in ctx.DataContext.HR_SalaryMode.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ModeCode = i.ModeCode;
										this.ModeText = i.ModeText;
										this.StatusCode = i.StatusCode;
										this.StaffTypeCode = i.StaffTypeCode;
										this.IsListPer = i.IsListPer;
					}
            }
        }
	}

	public class HR_SalaryModesFactory : Common.Business.HR_SalaryModes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SalaryMode
                        select HR_SalaryModeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SalaryMode
                        select HR_SalaryModeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SalaryMode>();
                var i = (from p in ctx.DataContext.HR_SalaryMode.Where(exp)
                         select HR_SalaryModeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SalaryMode>();
                var i = from p in ctx.DataContext.HR_SalaryMode.Where(exp)
                         select HR_SalaryModeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
