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
	public class FI_InvTypeFactory:Common.Business.FI_InvType
    {
        public static Common.Business.FI_InvType Fetch(FI_InvType data)
        {
            Common.Business.FI_InvType item = (Common.Business.FI_InvType)Activator.CreateInstance(typeof(Common.Business.FI_InvType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.InvTypCode = data.InvTypCode;
				                item.InvTypeName = data.InvTypeName;
				                item.TaxCode = data.TaxCode;
				                item.TaxType = data.TaxType;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_InvType>();
                var i = (from p in ctx.DataContext.FI_InvType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.InvTypCode = i.InvTypCode;
										this.InvTypeName = i.InvTypeName;
										this.TaxCode = i.TaxCode;
										this.TaxType = i.TaxType;
					}
            }
        }
	}

	public class FI_InvTypesFactory : Common.Business.FI_InvTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_InvType
                        select FI_InvTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_InvType
                        select FI_InvTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_InvType>();
                var i = (from p in ctx.DataContext.FI_InvType.Where(exp)
                         select FI_InvTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_InvType>();
                var i = from p in ctx.DataContext.FI_InvType.Where(exp)
                         select FI_InvTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
