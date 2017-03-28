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
	public class CO_VoucherTypeFactory:Common.Business.CO_VoucherType
    {
        public static Common.Business.CO_VoucherType Fetch(CO_VoucherType data)
        {
            Common.Business.CO_VoucherType item = (Common.Business.CO_VoucherType)Activator.CreateInstance(typeof(Common.Business.CO_VoucherType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.VouType = data.VouType;
				                item.PostRNR = data.PostRNR;
				                item.DText = data.DText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CO_VoucherType>();
                var i = (from p in ctx.DataContext.CO_VoucherType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.VouType = i.VouType;
										this.PostRNR = i.PostRNR;
										this.DText = i.DText;
					}
            }
        }
	}

	public class CO_VoucherTypesFactory : Common.Business.CO_VoucherTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CO_VoucherType
                        select CO_VoucherTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CO_VoucherType
                        select CO_VoucherTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CO_VoucherType>();
                var i = (from p in ctx.DataContext.CO_VoucherType.Where(exp)
                         select CO_VoucherTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CO_VoucherType>();
                var i = from p in ctx.DataContext.CO_VoucherType.Where(exp)
                         select CO_VoucherTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
