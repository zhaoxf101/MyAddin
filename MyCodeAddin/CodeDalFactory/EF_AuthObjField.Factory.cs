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
	public class EF_AuthObjFieldFactory:Common.Business.EF_AuthObjField
    {
        public static Common.Business.EF_AuthObjField Fetch(EF_AuthObjField data)
        {
            Common.Business.EF_AuthObjField item = (Common.Business.EF_AuthObjField)Activator.CreateInstance(typeof(Common.Business.EF_AuthObjField));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.AObject = data.AObject;
				                item.FieldName = data.FieldName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_AuthObjField>();
                var i = (from p in ctx.DataContext.EF_AuthObjField.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.AObject = i.AObject;
										this.FieldName = i.FieldName;
					}
            }
        }
	}

	public class EF_AuthObjFieldsFactory : Common.Business.EF_AuthObjFields
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_AuthObjField
                        select EF_AuthObjFieldFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_AuthObjField
                        select EF_AuthObjFieldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_AuthObjField>();
                var i = (from p in ctx.DataContext.EF_AuthObjField.Where(exp)
                         select EF_AuthObjFieldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_AuthObjField>();
                var i = from p in ctx.DataContext.EF_AuthObjField.Where(exp)
                         select EF_AuthObjFieldFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
