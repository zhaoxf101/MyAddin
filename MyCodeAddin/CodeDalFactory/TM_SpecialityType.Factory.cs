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
	public class TM_SpecialityTypeFactory:Common.Business.TM_SpecialityType
    {
        public static Common.Business.TM_SpecialityType Fetch(TM_SpecialityType data)
        {
            Common.Business.TM_SpecialityType item = (Common.Business.TM_SpecialityType)Activator.CreateInstance(typeof(Common.Business.TM_SpecialityType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.SpecialityTypeCode = data.SpecialityTypeCode;
				                item.SpecialityTypeName = data.SpecialityTypeName;
				                item.DegreeCode = data.DegreeCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<TM_SpecialityType>();
                var i = (from p in ctx.DataContext.TM_SpecialityType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.SpecialityTypeCode = i.SpecialityTypeCode;
										this.SpecialityTypeName = i.SpecialityTypeName;
										this.DegreeCode = i.DegreeCode;
					}
            }
        }
	}

	public class TM_SpecialityTypesFactory : Common.Business.TM_SpecialityTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.TM_SpecialityType
                        select TM_SpecialityTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.TM_SpecialityType
                        select TM_SpecialityTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<TM_SpecialityType>();
                var i = (from p in ctx.DataContext.TM_SpecialityType.Where(exp)
                         select TM_SpecialityTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<TM_SpecialityType>();
                var i = from p in ctx.DataContext.TM_SpecialityType.Where(exp)
                         select TM_SpecialityTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
