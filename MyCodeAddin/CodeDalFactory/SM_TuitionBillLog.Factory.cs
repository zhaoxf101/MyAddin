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
	public class SM_TuitionBillLogFactory:Common.Business.SM_TuitionBillLog
    {
        public static Common.Business.SM_TuitionBillLog Fetch(SM_TuitionBillLog data)
        {
            Common.Business.SM_TuitionBillLog item = (Common.Business.SM_TuitionBillLog)Activator.CreateInstance(typeof(Common.Business.SM_TuitionBillLog));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.TuitionBillNo = data.TuitionBillNo;
				                item.DealNo = data.DealNo;
				                item.PayWayCode = data.PayWayCode;
				                item.PayDateTime = data.PayDateTime;
				                item.Description = data.Description;
				                item.StudentNo = data.StudentNo;
				                item.Amt = data.Amt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<SM_TuitionBillLog>();
                var i = (from p in ctx.DataContext.SM_TuitionBillLog.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TuitionBillNo = i.TuitionBillNo;
										this.DealNo = i.DealNo;
										this.PayWayCode = i.PayWayCode;
										this.PayDateTime = i.PayDateTime;
										this.Description = i.Description;
										this.StudentNo = i.StudentNo;
										this.Amt = i.Amt;
					}
            }
        }
	}

	public class SM_TuitionBillLogsFactory : Common.Business.SM_TuitionBillLogs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_TuitionBillLog
                        select SM_TuitionBillLogFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_TuitionBillLog
                        select SM_TuitionBillLogFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_TuitionBillLog>();
                var i = (from p in ctx.DataContext.SM_TuitionBillLog.Where(exp)
                         select SM_TuitionBillLogFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_TuitionBillLog>();
                var i = from p in ctx.DataContext.SM_TuitionBillLog.Where(exp)
                         select SM_TuitionBillLogFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
