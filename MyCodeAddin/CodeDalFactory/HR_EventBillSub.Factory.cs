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
	public class HR_EventBillSubFactory:Common.Business.HR_EventBillSub
    {
        public static Common.Business.HR_EventBillSub Fetch(HR_EventBillSub data)
        {
            Common.Business.HR_EventBillSub item = (Common.Business.HR_EventBillSub)Activator.CreateInstance(typeof(Common.Business.HR_EventBillSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.BillNo = data.BillNo;
				                item.EventCode = data.EventCode;
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
				var exp = lambda.Resolve<HR_EventBillSub>();
                var i = (from p in ctx.DataContext.HR_EventBillSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.BillNo = i.BillNo;
										this.EventCode = i.EventCode;
										this.RelationGroup = i.RelationGroup;
										this.IsAppovel = i.IsAppovel;
										this.Sort = i.Sort;
					}
            }
        }
	}

	public class HR_EventBillSubsFactory : Common.Business.HR_EventBillSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EventBillSub
                        select HR_EventBillSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EventBillSub
                        select HR_EventBillSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EventBillSub>();
                var i = (from p in ctx.DataContext.HR_EventBillSub.Where(exp)
                         select HR_EventBillSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EventBillSub>();
                var i = from p in ctx.DataContext.HR_EventBillSub.Where(exp)
                         select HR_EventBillSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
