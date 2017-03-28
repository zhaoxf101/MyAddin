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
	public class HR_EmpEventSubFactory:Common.Business.HR_EmpEventSub
    {
        public static Common.Business.HR_EmpEventSub Fetch(HR_EmpEventSub data)
        {
            Common.Business.HR_EmpEventSub item = (Common.Business.HR_EmpEventSub)Activator.CreateInstance(typeof(Common.Business.HR_EmpEventSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.EmpEvent = data.EmpEvent;
				                item.InfoType = data.InfoType;
				                item.Sequence = data.Sequence;
				                item.IsValidate = data.IsValidate;
				                item.IsDefaut = data.IsDefaut;
				                item.IsShow = data.IsShow;
				                item.DefautPara = data.DefautPara;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpEventSub>();
                var i = (from p in ctx.DataContext.HR_EmpEventSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.EmpEvent = i.EmpEvent;
										this.InfoType = i.InfoType;
										this.Sequence = i.Sequence;
										this.IsValidate = i.IsValidate;
										this.IsDefaut = i.IsDefaut;
										this.IsShow = i.IsShow;
										this.DefautPara = i.DefautPara;
					}
            }
        }
	}

	public class HR_EmpEventSubsFactory : Common.Business.HR_EmpEventSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpEventSub
                        select HR_EmpEventSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpEventSub
                        select HR_EmpEventSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpEventSub>();
                var i = (from p in ctx.DataContext.HR_EmpEventSub.Where(exp)
                         select HR_EmpEventSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpEventSub>();
                var i = from p in ctx.DataContext.HR_EmpEventSub.Where(exp)
                         select HR_EmpEventSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
