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
	public class HR_EventInstanceFactory:Common.Business.HR_EventInstance
    {
        public static Common.Business.HR_EventInstance Fetch(HR_EventInstance data)
        {
            Common.Business.HR_EventInstance item = (Common.Business.HR_EventInstance)Activator.CreateInstance(typeof(Common.Business.HR_EventInstance));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.EmpCode = data.EmpCode;
				                item.EventCode = data.EventCode;
				                item.EventValue = data.EventValue;
				                item.Text = data.Text;
				                item.IsDelete = data.IsDelete;
				                item.Appovel = data.Appovel;
				                item.Cancel = data.Cancel;
				                item.CreateDate = data.CreateDate;
				                item.CreateUser = data.CreateUser;
				                item.ChangeDate = data.ChangeDate;
				                item.ChangeUser = data.ChangeUser;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EventInstance>();
                var i = (from p in ctx.DataContext.HR_EventInstance.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.EmpCode = i.EmpCode;
										this.EventCode = i.EventCode;
										this.EventValue = i.EventValue;
										this.Text = i.Text;
										this.IsDelete = i.IsDelete;
										this.Appovel = i.Appovel;
										this.Cancel = i.Cancel;
										this.CreateDate = i.CreateDate;
										this.CreateUser = i.CreateUser;
										this.ChangeDate = i.ChangeDate;
										this.ChangeUser = i.ChangeUser;
					}
            }
        }
	}

	public class HR_EventInstancesFactory : Common.Business.HR_EventInstances
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EventInstance
                        select HR_EventInstanceFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EventInstance
                        select HR_EventInstanceFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EventInstance>();
                var i = (from p in ctx.DataContext.HR_EventInstance.Where(exp)
                         select HR_EventInstanceFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EventInstance>();
                var i = from p in ctx.DataContext.HR_EventInstance.Where(exp)
                         select HR_EventInstanceFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
