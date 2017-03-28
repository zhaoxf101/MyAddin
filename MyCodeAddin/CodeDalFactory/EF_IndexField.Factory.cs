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
	public class EF_IndexFieldFactory:Common.Business.EF_IndexField
    {
        public static Common.Business.EF_IndexField Fetch(EF_IndexField data)
        {
            Common.Business.EF_IndexField item = (Common.Business.EF_IndexField)Activator.CreateInstance(typeof(Common.Business.EF_IndexField));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TableName = data.TableName;
				                item.IndexName = data.IndexName;
				                item.RowStatus = data.RowStatus;
				                item.FieldName = data.FieldName;
				                item.Position = data.Position;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_IndexField>();
                var i = (from p in ctx.DataContext.EF_IndexField.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TableName = i.TableName;
										this.IndexName = i.IndexName;
										this.RowStatus = i.RowStatus;
										this.FieldName = i.FieldName;
										this.Position = i.Position;
					}
            }
        }
	}

	public class EF_IndexFieldsFactory : Common.Business.EF_IndexFields
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_IndexField
                        select EF_IndexFieldFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_IndexField
                        select EF_IndexFieldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_IndexField>();
                var i = (from p in ctx.DataContext.EF_IndexField.Where(exp)
                         select EF_IndexFieldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_IndexField>();
                var i = from p in ctx.DataContext.EF_IndexField.Where(exp)
                         select EF_IndexFieldFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
