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
	public class SM_AppStuFactory:Common.Business.SM_AppStu
    {
        public static Common.Business.SM_AppStu Fetch(SM_AppStu data)
        {
            Common.Business.SM_AppStu item = (Common.Business.SM_AppStu)Activator.CreateInstance(typeof(Common.Business.SM_AppStu));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AppNo = data.AppNo;
				                item.AppBusCode = data.AppBusCode;
				                item.Memo = data.Memo;
				                item.IsAppr = data.IsAppr;
				                item.YSWF = data.YSWF;
				                item.Cancelled = data.Cancelled;
				                item.Approved = data.Approved;
				                item.ObjectId = data.ObjectId;
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
				var exp = lambda.Resolve<SM_AppStu>();
                var i = (from p in ctx.DataContext.SM_AppStu.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AppNo = i.AppNo;
										this.AppBusCode = i.AppBusCode;
										this.Memo = i.Memo;
										this.IsAppr = i.IsAppr;
										this.YSWF = i.YSWF;
										this.Cancelled = i.Cancelled;
										this.Approved = i.Approved;
										this.ObjectId = i.ObjectId;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class SM_AppStusFactory : Common.Business.SM_AppStus
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_AppStu
                        select SM_AppStuFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_AppStu
                        select SM_AppStuFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_AppStu>();
                var i = (from p in ctx.DataContext.SM_AppStu.Where(exp)
                         select SM_AppStuFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_AppStu>();
                var i = from p in ctx.DataContext.SM_AppStu.Where(exp)
                         select SM_AppStuFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
