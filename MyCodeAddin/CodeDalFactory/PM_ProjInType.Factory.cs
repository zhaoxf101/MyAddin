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
	public class PM_ProjInTypeFactory:Common.Business.PM_ProjInType
    {
        public static Common.Business.PM_ProjInType Fetch(PM_ProjInType data)
        {
            Common.Business.PM_ProjInType item = (Common.Business.PM_ProjInType)Activator.CreateInstance(typeof(Common.Business.PM_ProjInType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ProjInTypeCode = data.ProjInTypeCode;
				                item.ProjInTypeName = data.ProjInTypeName;
				                item.Memo = data.Memo;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_ProjInType>();
                var i = (from p in ctx.DataContext.PM_ProjInType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ProjInTypeCode = i.ProjInTypeCode;
										this.ProjInTypeName = i.ProjInTypeName;
										this.Memo = i.Memo;
					}
            }
        }
	}

	public class PM_ProjInTypesFactory : Common.Business.PM_ProjInTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ProjInType
                        select PM_ProjInTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ProjInType
                        select PM_ProjInTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ProjInType>();
                var i = (from p in ctx.DataContext.PM_ProjInType.Where(exp)
                         select PM_ProjInTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ProjInType>();
                var i = from p in ctx.DataContext.PM_ProjInType.Where(exp)
                         select PM_ProjInTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
