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
	public class EF_TableFieldFactory:Common.Business.EF_TableField
    {
        public static Common.Business.EF_TableField Fetch(EF_TableField data)
        {
            Common.Business.EF_TableField item = (Common.Business.EF_TableField)Activator.CreateInstance(typeof(Common.Business.EF_TableField));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TableName = data.TableName;
				                item.FieldName = data.FieldName;
				                item.Active = data.Active;
				                item.Position = data.Position;
				                item.KeyFlag = data.KeyFlag;
				                item.NotNull = data.NotNull;
				                item.DElement = data.DElement;
				                item.CheckTable = data.CheckTable;
				                item.RefTable = data.RefTable;
				                item.RefField = data.RefField;
				                item.DataType = data.DataType;
				                item.Leng = data.Leng;
				                item.Decimals = data.Decimals;
				                item.Domain = data.Domain;
				                item.SHlpOrigin = data.SHlpOrigin;
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
				var exp = lambda.Resolve<EF_TableField>();
                var i = (from p in ctx.DataContext.EF_TableField.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TableName = i.TableName;
										this.FieldName = i.FieldName;
										this.Active = i.Active;
										this.Position = i.Position;
										this.KeyFlag = i.KeyFlag;
										this.NotNull = i.NotNull;
										this.DElement = i.DElement;
										this.CheckTable = i.CheckTable;
										this.RefTable = i.RefTable;
										this.RefField = i.RefField;
										this.DataType = i.DataType;
										this.Leng = i.Leng;
										this.Decimals = i.Decimals;
										this.Domain = i.Domain;
										this.SHlpOrigin = i.SHlpOrigin;
										this.DText = i.DText;
					}
            }
        }
	}

	public class EF_TableFieldsFactory : Common.Business.EF_TableFields
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_TableField
                        select EF_TableFieldFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_TableField
                        select EF_TableFieldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_TableField>();
                var i = (from p in ctx.DataContext.EF_TableField.Where(exp)
                         select EF_TableFieldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_TableField>();
                var i = from p in ctx.DataContext.EF_TableField.Where(exp)
                         select EF_TableFieldFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
