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
	public class EF_UTypeFactory:Common.Business.EF_UType
    {
        public static Common.Business.EF_UType Fetch(EF_UType data)
        {
            Common.Business.EF_UType item = (Common.Business.EF_UType)Activator.CreateInstance(typeof(Common.Business.EF_UType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.UType = data.UType;
				                item.UTypeName = data.UTypeName;
				                item.IsInter = data.IsInter;
				                item.IsEmp = data.IsEmp;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_UType>();
                var i = (from p in ctx.DataContext.EF_UType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.UType = i.UType;
										this.UTypeName = i.UTypeName;
										this.IsInter = i.IsInter;
										this.IsEmp = i.IsEmp;
					}
            }
        }
	}

	public class EF_UTypesFactory : Common.Business.EF_UTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_UType
                        select EF_UTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_UType
                        select EF_UTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_UType>();
                var i = (from p in ctx.DataContext.EF_UType.Where(exp)
                         select EF_UTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_UType>();
                var i = from p in ctx.DataContext.EF_UType.Where(exp)
                         select EF_UTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
