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
	public class SM_StuDormFactory:Common.Business.SM_StuDorm
    {
        public static Common.Business.SM_StuDorm Fetch(SM_StuDorm data)
        {
            Common.Business.SM_StuDorm item = (Common.Business.SM_StuDorm)Activator.CreateInstance(typeof(Common.Business.SM_StuDorm));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.StudentNo = data.StudentNo;
				                item.SDate = data.SDate;
				                item.EDate = data.EDate;
				                item.DormNo = data.DormNo;
				                item.RoomNo = data.RoomNo;
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
				var exp = lambda.Resolve<SM_StuDorm>();
                var i = (from p in ctx.DataContext.SM_StuDorm.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.StudentNo = i.StudentNo;
										this.SDate = i.SDate;
										this.EDate = i.EDate;
										this.DormNo = i.DormNo;
										this.RoomNo = i.RoomNo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class SM_StuDormsFactory : Common.Business.SM_StuDorms
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_StuDorm
                        select SM_StuDormFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_StuDorm
                        select SM_StuDormFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_StuDorm>();
                var i = (from p in ctx.DataContext.SM_StuDorm.Where(exp)
                         select SM_StuDormFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_StuDorm>();
                var i = from p in ctx.DataContext.SM_StuDorm.Where(exp)
                         select SM_StuDormFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
