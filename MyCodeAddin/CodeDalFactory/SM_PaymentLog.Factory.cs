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
	public class SM_PaymentLogFactory:Common.Business.SM_PaymentLog
    {
        public static Common.Business.SM_PaymentLog Fetch(SM_PaymentLog data)
        {
            Common.Business.SM_PaymentLog item = (Common.Business.SM_PaymentLog)Activator.CreateInstance(typeof(Common.Business.SM_PaymentLog));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.DealNo = data.DealNo;
				                item.PayWayCode = data.PayWayCode;
				                item.PayDateTime = data.PayDateTime;
				                item.Amount = data.Amount;
				                item.Description = data.Description;
				                item.StudentNo = data.StudentNo;
				                item.IsConf = data.IsConf;
				                item.IsExternal = data.IsExternal;
				                item.BillNo = data.BillNo;
				                item.IsDelete = data.IsDelete;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<SM_PaymentLog>();
                var i = (from p in ctx.DataContext.SM_PaymentLog.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.DealNo = i.DealNo;
										this.PayWayCode = i.PayWayCode;
										this.PayDateTime = i.PayDateTime;
										this.Amount = i.Amount;
										this.Description = i.Description;
										this.StudentNo = i.StudentNo;
										this.IsConf = i.IsConf;
										this.IsExternal = i.IsExternal;
										this.BillNo = i.BillNo;
										this.IsDelete = i.IsDelete;
					}
            }
        }
	}

	public class SM_PaymentLogsFactory : Common.Business.SM_PaymentLogs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_PaymentLog
                        select SM_PaymentLogFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_PaymentLog
                        select SM_PaymentLogFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_PaymentLog>();
                var i = (from p in ctx.DataContext.SM_PaymentLog.Where(exp)
                         select SM_PaymentLogFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_PaymentLog>();
                var i = from p in ctx.DataContext.SM_PaymentLog.Where(exp)
                         select SM_PaymentLogFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
