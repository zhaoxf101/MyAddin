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
	public class FI_PayBackTypeFactory:Common.Business.FI_PayBackType
    {
        public static Common.Business.FI_PayBackType Fetch(FI_PayBackType data)
        {
            Common.Business.FI_PayBackType item = (Common.Business.FI_PayBackType)Activator.CreateInstance(typeof(Common.Business.FI_PayBackType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PayBackType = data.PayBackType;
				                item.DText = data.DText;
				                item.GLMark = data.GLMark;
				                item.AccType = data.AccType;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_PayBackType>();
                var i = (from p in ctx.DataContext.FI_PayBackType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PayBackType = i.PayBackType;
										this.DText = i.DText;
										this.GLMark = i.GLMark;
										this.AccType = i.AccType;
					}
            }
        }
	}

	public class FI_PayBackTypesFactory : Common.Business.FI_PayBackTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PayBackType
                        select FI_PayBackTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PayBackType
                        select FI_PayBackTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PayBackType>();
                var i = (from p in ctx.DataContext.FI_PayBackType.Where(exp)
                         select FI_PayBackTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PayBackType>();
                var i = from p in ctx.DataContext.FI_PayBackType.Where(exp)
                         select FI_PayBackTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
