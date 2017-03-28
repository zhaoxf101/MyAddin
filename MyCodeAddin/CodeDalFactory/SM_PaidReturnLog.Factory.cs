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
	public class SM_PaidReturnLogFactory:Common.Business.SM_PaidReturnLog
    {
        public static Common.Business.SM_PaidReturnLog Fetch(SM_PaidReturnLog data)
        {
            Common.Business.SM_PaidReturnLog item = (Common.Business.SM_PaidReturnLog)Activator.CreateInstance(typeof(Common.Business.SM_PaidReturnLog));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.id = data.id;
				                item.vStudentNo = data.vStudentNo;
				                item.vLot = data.vLot;
				                item.vPayWayCode = data.vPayWayCode;
				                item.nReturn = data.nReturn;
				                item.dDateInput = data.dDateInput;
				                item.bReturn = data.bReturn;
				                item.iDealNo = data.iDealNo;
				                item.vReturnLot = data.vReturnLot;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<SM_PaidReturnLog>();
                var i = (from p in ctx.DataContext.SM_PaidReturnLog.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.id = i.id;
										this.vStudentNo = i.vStudentNo;
										this.vLot = i.vLot;
										this.vPayWayCode = i.vPayWayCode;
										this.nReturn = i.nReturn;
										this.dDateInput = i.dDateInput;
										this.bReturn = i.bReturn;
										this.iDealNo = i.iDealNo;
										this.vReturnLot = i.vReturnLot;
					}
            }
        }
	}

	public class SM_PaidReturnLogsFactory : Common.Business.SM_PaidReturnLogs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_PaidReturnLog
                        select SM_PaidReturnLogFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_PaidReturnLog
                        select SM_PaidReturnLogFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_PaidReturnLog>();
                var i = (from p in ctx.DataContext.SM_PaidReturnLog.Where(exp)
                         select SM_PaidReturnLogFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_PaidReturnLog>();
                var i = from p in ctx.DataContext.SM_PaidReturnLog.Where(exp)
                         select SM_PaidReturnLogFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
