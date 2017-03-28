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
	public class EQ_EquTypeFactory:Common.Business.EQ_EquType
    {
        public static Common.Business.EQ_EquType Fetch(EQ_EquType data)
        {
            Common.Business.EQ_EquType item = (Common.Business.EQ_EquType)Activator.CreateInstance(typeof(Common.Business.EQ_EquType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.EquTypeCode = data.EquTypeCode;
				                item.EquTypeName = data.EquTypeName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EQ_EquType>();
                var i = (from p in ctx.DataContext.EQ_EquType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.EquTypeCode = i.EquTypeCode;
										this.EquTypeName = i.EquTypeName;
					}
            }
        }
	}

	public class EQ_EquTypesFactory : Common.Business.EQ_EquTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EQ_EquType
                        select EQ_EquTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EQ_EquType
                        select EQ_EquTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EQ_EquType>();
                var i = (from p in ctx.DataContext.EQ_EquType.Where(exp)
                         select EQ_EquTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EQ_EquType>();
                var i = from p in ctx.DataContext.EQ_EquType.Where(exp)
                         select EQ_EquTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
