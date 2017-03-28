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
	public class TM_SpecialityFactory:Common.Business.TM_Speciality
    {
        public static Common.Business.TM_Speciality Fetch(TM_Speciality data)
        {
            Common.Business.TM_Speciality item = (Common.Business.TM_Speciality)Activator.CreateInstance(typeof(Common.Business.TM_Speciality));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.SpecialityCode = data.SpecialityCode;
				                item.SpecialityName = data.SpecialityName;
				                item.SpecialityTypeCode = data.SpecialityTypeCode;
				                item.DegreeCode = data.DegreeCode;
				                item.PeriodLength = data.PeriodLength;
				                item.FeeTypeCode = data.FeeTypeCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<TM_Speciality>();
                var i = (from p in ctx.DataContext.TM_Speciality.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.SpecialityCode = i.SpecialityCode;
										this.SpecialityName = i.SpecialityName;
										this.SpecialityTypeCode = i.SpecialityTypeCode;
										this.DegreeCode = i.DegreeCode;
										this.PeriodLength = i.PeriodLength;
										this.FeeTypeCode = i.FeeTypeCode;
					}
            }
        }
	}

	public class TM_SpecialitysFactory : Common.Business.TM_Specialitys
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.TM_Speciality
                        select TM_SpecialityFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.TM_Speciality
                        select TM_SpecialityFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<TM_Speciality>();
                var i = (from p in ctx.DataContext.TM_Speciality.Where(exp)
                         select TM_SpecialityFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<TM_Speciality>();
                var i = from p in ctx.DataContext.TM_Speciality.Where(exp)
                         select TM_SpecialityFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
