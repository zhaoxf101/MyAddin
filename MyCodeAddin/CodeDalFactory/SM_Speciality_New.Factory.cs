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
	public class SM_Speciality_NewFactory:Common.Business.SM_Speciality_New
    {
        public static Common.Business.SM_Speciality_New Fetch(SM_Speciality_New data)
        {
            Common.Business.SM_Speciality_New item = (Common.Business.SM_Speciality_New)Activator.CreateInstance(typeof(Common.Business.SM_Speciality_New));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SpecialityId = data.SpecialityId;
				                item.SpecialityCode = data.SpecialityCode;
				                item.SpecialityName = data.SpecialityName;
				                item.SpecialityTypeCode = data.SpecialityTypeCode;
				                item.DegreeCode = data.DegreeCode;
				                item.EduYear = data.EduYear;
				                item.DepCode = data.DepCode;
				                item.CreateUser = data.CreateUser;
				                item.CreateDate = data.CreateDate;
				                item.ChangeUser = data.ChangeUser;
				                item.ChangeDate = data.ChangeDate;
				                item.Status = data.Status;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<SM_Speciality_New>();
                var i = (from p in ctx.DataContext.SM_Speciality_New.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SpecialityId = i.SpecialityId;
										this.SpecialityCode = i.SpecialityCode;
										this.SpecialityName = i.SpecialityName;
										this.SpecialityTypeCode = i.SpecialityTypeCode;
										this.DegreeCode = i.DegreeCode;
										this.EduYear = i.EduYear;
										this.DepCode = i.DepCode;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
										this.Status = i.Status;
					}
            }
        }
	}

	public class SM_Speciality_NewsFactory : Common.Business.SM_Speciality_News
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_Speciality_New
                        select SM_Speciality_NewFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_Speciality_New
                        select SM_Speciality_NewFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_Speciality_New>();
                var i = (from p in ctx.DataContext.SM_Speciality_New.Where(exp)
                         select SM_Speciality_NewFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_Speciality_New>();
                var i = from p in ctx.DataContext.SM_Speciality_New.Where(exp)
                         select SM_Speciality_NewFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
