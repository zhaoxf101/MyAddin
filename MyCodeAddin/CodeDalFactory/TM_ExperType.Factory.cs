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
	public class TM_ExperTypeFactory:Common.Business.TM_ExperType
    {
        public static Common.Business.TM_ExperType Fetch(TM_ExperType data)
        {
            Common.Business.TM_ExperType item = (Common.Business.TM_ExperType)Activator.CreateInstance(typeof(Common.Business.TM_ExperType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ExperTypeCode = data.ExperTypeCode;
				                item.ExperTypeName = data.ExperTypeName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<TM_ExperType>();
                var i = (from p in ctx.DataContext.TM_ExperType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ExperTypeCode = i.ExperTypeCode;
										this.ExperTypeName = i.ExperTypeName;
					}
            }
        }
	}

	public class TM_ExperTypesFactory : Common.Business.TM_ExperTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.TM_ExperType
                        select TM_ExperTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.TM_ExperType
                        select TM_ExperTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<TM_ExperType>();
                var i = (from p in ctx.DataContext.TM_ExperType.Where(exp)
                         select TM_ExperTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<TM_ExperType>();
                var i = from p in ctx.DataContext.TM_ExperType.Where(exp)
                         select TM_ExperTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
