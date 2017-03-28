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
	public class HR_EmpBusDepartFactory:Common.Business.HR_EmpBusDepart
    {
        public static Common.Business.HR_EmpBusDepart Fetch(HR_EmpBusDepart data)
        {
            Common.Business.HR_EmpBusDepart item = (Common.Business.HR_EmpBusDepart)Activator.CreateInstance(typeof(Common.Business.HR_EmpBusDepart));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Id = data.Id;
				                item.Client = data.Client;
				                item.EmpBusNo = data.EmpBusNo;
				                item.EmpCode = data.EmpCode;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.DepCode = data.DepCode;
				                item.PositionCode = data.PositionCode;
				                item.ActionType = data.ActionType;
				                item.OldId = data.OldId;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpBusDepart>();
                var i = (from p in ctx.DataContext.HR_EmpBusDepart.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Id = i.Id;
										this.Client = i.Client;
										this.EmpBusNo = i.EmpBusNo;
										this.EmpCode = i.EmpCode;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.DepCode = i.DepCode;
										this.PositionCode = i.PositionCode;
										this.ActionType = i.ActionType;
										this.OldId = i.OldId;
					}
            }
        }
	}

	public class HR_EmpBusDepartsFactory : Common.Business.HR_EmpBusDeparts
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpBusDepart
                        select HR_EmpBusDepartFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpBusDepart
                        select HR_EmpBusDepartFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpBusDepart>();
                var i = (from p in ctx.DataContext.HR_EmpBusDepart.Where(exp)
                         select HR_EmpBusDepartFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpBusDepart>();
                var i = from p in ctx.DataContext.HR_EmpBusDepart.Where(exp)
                         select HR_EmpBusDepartFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
