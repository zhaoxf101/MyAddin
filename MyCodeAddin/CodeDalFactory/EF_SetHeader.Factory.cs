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
	public class EF_SetHeaderFactory:Common.Business.EF_SetHeader
    {
        public static Common.Business.EF_SetHeader Fetch(EF_SetHeader data)
        {
            Common.Business.EF_SetHeader item = (Common.Business.EF_SetHeader)Activator.CreateInstance(typeof(Common.Business.EF_SetHeader));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.SetClass = data.SetClass;
				                item.SetUnit = data.SetUnit;
				                item.SetCode = data.SetCode;
				                item.SetName = data.SetName;
				                item.Uniqe = data.Uniqe;
				                item.TableName = data.TableName;
				                item.FieldName = data.FieldName;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_SetHeader>();
                var i = (from p in ctx.DataContext.EF_SetHeader.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.SetClass = i.SetClass;
										this.SetUnit = i.SetUnit;
										this.SetCode = i.SetCode;
										this.SetName = i.SetName;
										this.Uniqe = i.Uniqe;
										this.TableName = i.TableName;
										this.FieldName = i.FieldName;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class EF_SetHeadersFactory : Common.Business.EF_SetHeaders
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_SetHeader
                        select EF_SetHeaderFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_SetHeader
                        select EF_SetHeaderFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_SetHeader>();
                var i = (from p in ctx.DataContext.EF_SetHeader.Where(exp)
                         select EF_SetHeaderFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_SetHeader>();
                var i = from p in ctx.DataContext.EF_SetHeader.Where(exp)
                         select EF_SetHeaderFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
