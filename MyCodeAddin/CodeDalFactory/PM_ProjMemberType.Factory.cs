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
	public class PM_ProjMemberTypeFactory:Common.Business.PM_ProjMemberType
    {
        public static Common.Business.PM_ProjMemberType Fetch(PM_ProjMemberType data)
        {
            Common.Business.PM_ProjMemberType item = (Common.Business.PM_ProjMemberType)Activator.CreateInstance(typeof(Common.Business.PM_ProjMemberType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ProjMemberTypeCode = data.ProjMemberTypeCode;
				                item.ProjMemberTypeName = data.ProjMemberTypeName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_ProjMemberType>();
                var i = (from p in ctx.DataContext.PM_ProjMemberType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ProjMemberTypeCode = i.ProjMemberTypeCode;
										this.ProjMemberTypeName = i.ProjMemberTypeName;
					}
            }
        }
	}

	public class PM_ProjMemberTypesFactory : Common.Business.PM_ProjMemberTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ProjMemberType
                        select PM_ProjMemberTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ProjMemberType
                        select PM_ProjMemberTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ProjMemberType>();
                var i = (from p in ctx.DataContext.PM_ProjMemberType.Where(exp)
                         select PM_ProjMemberTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ProjMemberType>();
                var i = from p in ctx.DataContext.PM_ProjMemberType.Where(exp)
                         select PM_ProjMemberTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
