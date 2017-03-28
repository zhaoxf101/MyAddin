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
	public class HR_IDCardTypeFactory:Common.Business.HR_IDCardType
    {
        public static Common.Business.HR_IDCardType Fetch(HR_IDCardType data)
        {
            Common.Business.HR_IDCardType item = (Common.Business.HR_IDCardType)Activator.CreateInstance(typeof(Common.Business.HR_IDCardType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.IDCardTypeCode = data.IDCardTypeCode;
				                item.IDCardTypeName = data.IDCardTypeName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_IDCardType>();
                var i = (from p in ctx.DataContext.HR_IDCardType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.IDCardTypeCode = i.IDCardTypeCode;
										this.IDCardTypeName = i.IDCardTypeName;
					}
            }
        }
	}

	public class HR_IDCardTypesFactory : Common.Business.HR_IDCardTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_IDCardType
                        select HR_IDCardTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_IDCardType
                        select HR_IDCardTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_IDCardType>();
                var i = (from p in ctx.DataContext.HR_IDCardType.Where(exp)
                         select HR_IDCardTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_IDCardType>();
                var i = from p in ctx.DataContext.HR_IDCardType.Where(exp)
                         select HR_IDCardTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
