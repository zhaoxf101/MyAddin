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
	public class HR_EventEmpBillSubFactory:Common.Business.HR_EventEmpBillSub
    {
        public static Common.Business.HR_EventEmpBillSub Fetch(HR_EventEmpBillSub data)
        {
            Common.Business.HR_EventEmpBillSub item = (Common.Business.HR_EventEmpBillSub)Activator.CreateInstance(typeof(Common.Business.HR_EventEmpBillSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.BillNo = data.BillNo;
				                item.EmpCode = data.EmpCode;
				                item.RelationGroup = data.RelationGroup;
				                item.IsAppovel = data.IsAppovel;
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
				var exp = lambda.Resolve<HR_EventEmpBillSub>();
                var i = (from p in ctx.DataContext.HR_EventEmpBillSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.BillNo = i.BillNo;
										this.EmpCode = i.EmpCode;
										this.RelationGroup = i.RelationGroup;
										this.IsAppovel = i.IsAppovel;
										this.Sort = i.Sort;
					}
            }
        }
	}

	public class HR_EventEmpBillSubsFactory : Common.Business.HR_EventEmpBillSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EventEmpBillSub
                        select HR_EventEmpBillSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EventEmpBillSub
                        select HR_EventEmpBillSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EventEmpBillSub>();
                var i = (from p in ctx.DataContext.HR_EventEmpBillSub.Where(exp)
                         select HR_EventEmpBillSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EventEmpBillSub>();
                var i = from p in ctx.DataContext.HR_EventEmpBillSub.Where(exp)
                         select HR_EventEmpBillSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
