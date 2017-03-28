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
	public class SM_StudentStatusTypeFactory:Common.Business.SM_StudentStatusType
    {
        public static Common.Business.SM_StudentStatusType Fetch(SM_StudentStatusType data)
        {
            Common.Business.SM_StudentStatusType item = (Common.Business.SM_StudentStatusType)Activator.CreateInstance(typeof(Common.Business.SM_StudentStatusType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.StudentStatusTypeCode = data.StudentStatusTypeCode;
				                item.StudentStatusTypeName = data.StudentStatusTypeName;
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
				var exp = lambda.Resolve<SM_StudentStatusType>();
                var i = (from p in ctx.DataContext.SM_StudentStatusType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.StudentStatusTypeCode = i.StudentStatusTypeCode;
										this.StudentStatusTypeName = i.StudentStatusTypeName;
										this.Memo = i.Memo;
					}
            }
        }
	}

	public class SM_StudentStatusTypesFactory : Common.Business.SM_StudentStatusTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_StudentStatusType
                        select SM_StudentStatusTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_StudentStatusType
                        select SM_StudentStatusTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_StudentStatusType>();
                var i = (from p in ctx.DataContext.SM_StudentStatusType.Where(exp)
                         select SM_StudentStatusTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_StudentStatusType>();
                var i = from p in ctx.DataContext.SM_StudentStatusType.Where(exp)
                         select SM_StudentStatusTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
