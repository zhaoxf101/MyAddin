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
	public class EF_FKeyFieldFactory:Common.Business.EF_FKeyField
    {
        public static Common.Business.EF_FKeyField Fetch(EF_FKeyField data)
        {
            Common.Business.EF_FKeyField item = (Common.Business.EF_FKeyField)Activator.CreateInstance(typeof(Common.Business.EF_FKeyField));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Id = data.Id;
				                item.TableName = data.TableName;
				                item.RowStatus = data.RowStatus;
				                item.FKeyTable = data.FKeyTable;
				                item.FKeyField = data.FKeyField;
				                item.TableField = data.TableField;
				                item.ConstX = data.ConstX;
				                item.ForVal = data.ForVal;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_FKeyField>();
                var i = (from p in ctx.DataContext.EF_FKeyField.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Id = i.Id;
										this.TableName = i.TableName;
										this.RowStatus = i.RowStatus;
										this.FKeyTable = i.FKeyTable;
										this.FKeyField = i.FKeyField;
										this.TableField = i.TableField;
										this.ConstX = i.ConstX;
										this.ForVal = i.ForVal;
					}
            }
        }
	}

	public class EF_FKeyFieldsFactory : Common.Business.EF_FKeyFields
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_FKeyField
                        select EF_FKeyFieldFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_FKeyField
                        select EF_FKeyFieldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_FKeyField>();
                var i = (from p in ctx.DataContext.EF_FKeyField.Where(exp)
                         select EF_FKeyFieldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_FKeyField>();
                var i = from p in ctx.DataContext.EF_FKeyField.Where(exp)
                         select EF_FKeyFieldFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
