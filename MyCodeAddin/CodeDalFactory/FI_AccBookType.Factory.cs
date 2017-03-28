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
	public class FI_AccBookTypeFactory:Common.Business.FI_AccBookType
    {
        public static Common.Business.FI_AccBookType Fetch(FI_AccBookType data)
        {
            Common.Business.FI_AccBookType item = (Common.Business.FI_AccBookType)Activator.CreateInstance(typeof(Common.Business.FI_AccBookType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.BookType = data.BookType;
				                item.BookName = data.BookName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_AccBookType>();
                var i = (from p in ctx.DataContext.FI_AccBookType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.BookType = i.BookType;
										this.BookName = i.BookName;
					}
            }
        }
	}

	public class FI_AccBookTypesFactory : Common.Business.FI_AccBookTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_AccBookType
                        select FI_AccBookTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_AccBookType
                        select FI_AccBookTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_AccBookType>();
                var i = (from p in ctx.DataContext.FI_AccBookType.Where(exp)
                         select FI_AccBookTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_AccBookType>();
                var i = from p in ctx.DataContext.FI_AccBookType.Where(exp)
                         select FI_AccBookTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
