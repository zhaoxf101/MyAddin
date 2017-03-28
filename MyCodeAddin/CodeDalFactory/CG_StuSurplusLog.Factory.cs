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
	public class CG_StuSurplusLogFactory:Common.Business.CG_StuSurplusLog
    {
        public static Common.Business.CG_StuSurplusLog Fetch(CG_StuSurplusLog data)
        {
            Common.Business.CG_StuSurplusLog item = (Common.Business.CG_StuSurplusLog)Activator.CreateInstance(typeof(Common.Business.CG_StuSurplusLog));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.StudentNo = data.StudentNo;
				                item.PayWayCode = data.PayWayCode;
				                item.Amt = data.Amt;
				                item.TranOrderId = data.TranOrderId;
				                item.CreateUser = data.CreateUser;
				                item.CreateDate = data.CreateDate;
				                item.IsHandle = data.IsHandle;
				                item.HandleUser = data.HandleUser;
				                item.HandleDate = data.HandleDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CG_StuSurplusLog>();
                var i = (from p in ctx.DataContext.CG_StuSurplusLog.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.StudentNo = i.StudentNo;
										this.PayWayCode = i.PayWayCode;
										this.Amt = i.Amt;
										this.TranOrderId = i.TranOrderId;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.IsHandle = i.IsHandle;
										this.HandleUser = i.HandleUser;
										this.HandleDate = i.HandleDate;
					}
            }
        }
	}

	public class CG_StuSurplusLogsFactory : Common.Business.CG_StuSurplusLogs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CG_StuSurplusLog
                        select CG_StuSurplusLogFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CG_StuSurplusLog
                        select CG_StuSurplusLogFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CG_StuSurplusLog>();
                var i = (from p in ctx.DataContext.CG_StuSurplusLog.Where(exp)
                         select CG_StuSurplusLogFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CG_StuSurplusLog>();
                var i = from p in ctx.DataContext.CG_StuSurplusLog.Where(exp)
                         select CG_StuSurplusLogFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
