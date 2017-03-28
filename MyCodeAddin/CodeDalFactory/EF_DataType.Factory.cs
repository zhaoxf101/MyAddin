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
	public class EF_DataTypeFactory:Common.Business.EF_DataType
    {
        public static Common.Business.EF_DataType Fetch(EF_DataType data)
        {
            Common.Business.EF_DataType item = (Common.Business.EF_DataType)Activator.CreateInstance(typeof(Common.Business.EF_DataType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.DataType = data.DataType;
				                item.DText = data.DText;
				                item.SQLType = data.SQLType;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_DataType>();
                var i = (from p in ctx.DataContext.EF_DataType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.DataType = i.DataType;
										this.DText = i.DText;
										this.SQLType = i.SQLType;
					}
            }
        }
	}

	public class EF_DataTypesFactory : Common.Business.EF_DataTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_DataType
                        select EF_DataTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_DataType
                        select EF_DataTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_DataType>();
                var i = (from p in ctx.DataContext.EF_DataType.Where(exp)
                         select EF_DataTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_DataType>();
                var i = from p in ctx.DataContext.EF_DataType.Where(exp)
                         select EF_DataTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
