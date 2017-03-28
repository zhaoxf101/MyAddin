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
	public class PM_WoffProjFactory:Common.Business.PM_WoffProj
    {
        public static Common.Business.PM_WoffProj Fetch(PM_WoffProj data)
        {
            Common.Business.PM_WoffProj item = (Common.Business.PM_WoffProj)Activator.CreateInstance(typeof(Common.Business.PM_WoffProj));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.WoffCode = data.WoffCode;
				                item.LoanCode = data.LoanCode;
				                item.WoffName = data.WoffName;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.WoffAmt = data.WoffAmt;
				                item.Description = data.Description;
				                item.TimeStamp = data.TimeStamp;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_WoffProj>();
                var i = (from p in ctx.DataContext.PM_WoffProj.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.WoffCode = i.WoffCode;
										this.LoanCode = i.LoanCode;
										this.WoffName = i.WoffName;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.WoffAmt = i.WoffAmt;
										this.Description = i.Description;
										this.TimeStamp = i.TimeStamp;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_WoffProjsFactory : Common.Business.PM_WoffProjs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_WoffProj
                        select PM_WoffProjFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_WoffProj
                        select PM_WoffProjFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_WoffProj>();
                var i = (from p in ctx.DataContext.PM_WoffProj.Where(exp)
                         select PM_WoffProjFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_WoffProj>();
                var i = from p in ctx.DataContext.PM_WoffProj.Where(exp)
                         select PM_WoffProjFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
