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
	public class EF_SHlpFieldFactory:Common.Business.EF_SHlpField
    {
        public static Common.Business.EF_SHlpField Fetch(EF_SHlpField data)
        {
            Common.Business.EF_SHlpField item = (Common.Business.EF_SHlpField)Activator.CreateInstance(typeof(Common.Business.EF_SHlpField));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.SearchHelp = data.SearchHelp;
				                item.RowStatus = data.RowStatus;
				                item.FieldPos = data.FieldPos;
				                item.FieldName = data.FieldName;
				                item.InputX = data.InputX;
				                item.OutputX = data.OutputX;
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
				var exp = lambda.Resolve<EF_SHlpField>();
                var i = (from p in ctx.DataContext.EF_SHlpField.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.SearchHelp = i.SearchHelp;
										this.RowStatus = i.RowStatus;
										this.FieldPos = i.FieldPos;
										this.FieldName = i.FieldName;
										this.InputX = i.InputX;
										this.OutputX = i.OutputX;
										this.DText = i.DText;
					}
            }
        }
	}

	public class EF_SHlpFieldsFactory : Common.Business.EF_SHlpFields
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_SHlpField
                        select EF_SHlpFieldFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_SHlpField
                        select EF_SHlpFieldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_SHlpField>();
                var i = (from p in ctx.DataContext.EF_SHlpField.Where(exp)
                         select EF_SHlpFieldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_SHlpField>();
                var i = from p in ctx.DataContext.EF_SHlpField.Where(exp)
                         select EF_SHlpFieldFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
