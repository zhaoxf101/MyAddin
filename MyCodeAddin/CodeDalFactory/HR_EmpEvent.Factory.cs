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
	public class HR_EmpEventFactory:Common.Business.HR_EmpEvent
    {
        public static Common.Business.HR_EmpEvent Fetch(HR_EmpEvent data)
        {
            Common.Business.HR_EmpEvent item = (Common.Business.HR_EmpEvent)Activator.CreateInstance(typeof(Common.Business.HR_EmpEvent));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.EmpEvent = data.EmpEvent;
				                item.DText = data.DText;
				                item.IsInfo = data.IsInfo;
				                item.WebObject = data.WebObject;
				                item.WinObject = data.WinObject;
				                item.WorkFlowId = data.WorkFlowId;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpEvent>();
                var i = (from p in ctx.DataContext.HR_EmpEvent.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.EmpEvent = i.EmpEvent;
										this.DText = i.DText;
										this.IsInfo = i.IsInfo;
										this.WebObject = i.WebObject;
										this.WinObject = i.WinObject;
										this.WorkFlowId = i.WorkFlowId;
					}
            }
        }
	}

	public class HR_EmpEventsFactory : Common.Business.HR_EmpEvents
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpEvent
                        select HR_EmpEventFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpEvent
                        select HR_EmpEventFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpEvent>();
                var i = (from p in ctx.DataContext.HR_EmpEvent.Where(exp)
                         select HR_EmpEventFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpEvent>();
                var i = from p in ctx.DataContext.HR_EmpEvent.Where(exp)
                         select HR_EmpEventFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
