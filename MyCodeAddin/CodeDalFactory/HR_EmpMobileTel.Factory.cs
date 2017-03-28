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
	public class HR_EmpMobileTelFactory:Common.Business.HR_EmpMobileTel
    {
        public static Common.Business.HR_EmpMobileTel Fetch(HR_EmpMobileTel data)
        {
            Common.Business.HR_EmpMobileTel item = (Common.Business.HR_EmpMobileTel)Activator.CreateInstance(typeof(Common.Business.HR_EmpMobileTel));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.EmpCode = data.EmpCode;
				                item.MobileTel = data.MobileTel;
				                item.Flag = data.Flag;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpMobileTel>();
                var i = (from p in ctx.DataContext.HR_EmpMobileTel.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.EmpCode = i.EmpCode;
										this.MobileTel = i.MobileTel;
										this.Flag = i.Flag;
					}
            }
        }
	}

	public class HR_EmpMobileTelsFactory : Common.Business.HR_EmpMobileTels
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpMobileTel
                        select HR_EmpMobileTelFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpMobileTel
                        select HR_EmpMobileTelFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpMobileTel>();
                var i = (from p in ctx.DataContext.HR_EmpMobileTel.Where(exp)
                         select HR_EmpMobileTelFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpMobileTel>();
                var i = from p in ctx.DataContext.HR_EmpMobileTel.Where(exp)
                         select HR_EmpMobileTelFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
