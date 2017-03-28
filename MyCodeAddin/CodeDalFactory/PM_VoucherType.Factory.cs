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
	public class PM_VoucherTypeFactory:Common.Business.PM_VoucherType
    {
        public static Common.Business.PM_VoucherType Fetch(PM_VoucherType data)
        {
            Common.Business.PM_VoucherType item = (Common.Business.PM_VoucherType)Activator.CreateInstance(typeof(Common.Business.PM_VoucherType));
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
				var exp = lambda.Resolve<PM_VoucherType>();
                var i = (from p in ctx.DataContext.PM_VoucherType.Where(exp)
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

	public class PM_VoucherTypesFactory : Common.Business.PM_VoucherTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_VoucherType
                        select PM_VoucherTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_VoucherType
                        select PM_VoucherTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_VoucherType>();
                var i = (from p in ctx.DataContext.PM_VoucherType.Where(exp)
                         select PM_VoucherTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_VoucherType>();
                var i = from p in ctx.DataContext.PM_VoucherType.Where(exp)
                         select PM_VoucherTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
