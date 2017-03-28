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
	public class SM_AppStuClaSpeFactory:Common.Business.SM_AppStuClaSpe
    {
        public static Common.Business.SM_AppStuClaSpe Fetch(SM_AppStuClaSpe data)
        {
            Common.Business.SM_AppStuClaSpe item = (Common.Business.SM_AppStuClaSpe)Activator.CreateInstance(typeof(Common.Business.SM_AppStuClaSpe));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AppNo = data.AppNo;
				                item.StudentNo = data.StudentNo;
				                item.SDate = data.SDate;
				                item.EDate = data.EDate;
				                item.ClassCode = data.ClassCode;
				                item.SpecialityCode = data.SpecialityCode;
				                item.IsN = data.IsN;
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
				var exp = lambda.Resolve<SM_AppStuClaSpe>();
                var i = (from p in ctx.DataContext.SM_AppStuClaSpe.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AppNo = i.AppNo;
										this.StudentNo = i.StudentNo;
										this.SDate = i.SDate;
										this.EDate = i.EDate;
										this.ClassCode = i.ClassCode;
										this.SpecialityCode = i.SpecialityCode;
										this.IsN = i.IsN;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class SM_AppStuClaSpesFactory : Common.Business.SM_AppStuClaSpes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_AppStuClaSpe
                        select SM_AppStuClaSpeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_AppStuClaSpe
                        select SM_AppStuClaSpeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_AppStuClaSpe>();
                var i = (from p in ctx.DataContext.SM_AppStuClaSpe.Where(exp)
                         select SM_AppStuClaSpeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_AppStuClaSpe>();
                var i = from p in ctx.DataContext.SM_AppStuClaSpe.Where(exp)
                         select SM_AppStuClaSpeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
