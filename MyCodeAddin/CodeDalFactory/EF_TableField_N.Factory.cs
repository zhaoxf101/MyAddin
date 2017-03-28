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
	public class EF_TableField_NFactory:Common.Business.EF_TableField_N
    {
        public static Common.Business.EF_TableField_N Fetch(EF_TableField_N data)
        {
            Common.Business.EF_TableField_N item = (Common.Business.EF_TableField_N)Activator.CreateInstance(typeof(Common.Business.EF_TableField_N));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TableName = data.TableName;
				                item.FieldName = data.FieldName;
				                item.RowStatus = data.RowStatus;
				                item.FieldId = data.FieldId;
				                item.Position = data.Position;
				                item.PKeyX = data.PKeyX;
				                item.DataElement = data.DataElement;
				                item.Domain = data.Domain;
				                item.DataType = data.DataType;
				                item.Leng = data.Leng;
				                item.Decimals = data.Decimals;
				                item.DText = data.DText;
				                item.RefTableName = data.RefTableName;
				                item.RefField = data.RefField;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_TableField_N>();
                var i = (from p in ctx.DataContext.EF_TableField_N.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TableName = i.TableName;
										this.FieldName = i.FieldName;
										this.RowStatus = i.RowStatus;
										this.FieldId = i.FieldId;
										this.Position = i.Position;
										this.PKeyX = i.PKeyX;
										this.DataElement = i.DataElement;
										this.Domain = i.Domain;
										this.DataType = i.DataType;
										this.Leng = i.Leng;
										this.Decimals = i.Decimals;
										this.DText = i.DText;
										this.RefTableName = i.RefTableName;
										this.RefField = i.RefField;
					}
            }
        }
	}

	public class EF_TableField_NsFactory : Common.Business.EF_TableField_Ns
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_TableField_N
                        select EF_TableField_NFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_TableField_N
                        select EF_TableField_NFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_TableField_N>();
                var i = (from p in ctx.DataContext.EF_TableField_N.Where(exp)
                         select EF_TableField_NFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_TableField_N>();
                var i = from p in ctx.DataContext.EF_TableField_N.Where(exp)
                         select EF_TableField_NFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
