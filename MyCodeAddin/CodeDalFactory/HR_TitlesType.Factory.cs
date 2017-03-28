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
	public class HR_TitlesTypeFactory:Common.Business.HR_TitlesType
    {
        public static Common.Business.HR_TitlesType Fetch(HR_TitlesType data)
        {
            Common.Business.HR_TitlesType item = (Common.Business.HR_TitlesType)Activator.CreateInstance(typeof(Common.Business.HR_TitlesType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TitlesTypeCode = data.TitlesTypeCode;
				                item.TitlesTypeName = data.TitlesTypeName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_TitlesType>();
                var i = (from p in ctx.DataContext.HR_TitlesType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TitlesTypeCode = i.TitlesTypeCode;
										this.TitlesTypeName = i.TitlesTypeName;
					}
            }
        }
	}

	public class HR_TitlesTypesFactory : Common.Business.HR_TitlesTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_TitlesType
                        select HR_TitlesTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_TitlesType
                        select HR_TitlesTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_TitlesType>();
                var i = (from p in ctx.DataContext.HR_TitlesType.Where(exp)
                         select HR_TitlesTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_TitlesType>();
                var i = from p in ctx.DataContext.HR_TitlesType.Where(exp)
                         select HR_TitlesTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
