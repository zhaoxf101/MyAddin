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
	public class EF_StdHeaderFactory:Common.Business.EF_StdHeader
    {
        public static Common.Business.EF_StdHeader Fetch(EF_StdHeader data)
        {
            Common.Business.EF_StdHeader item = (Common.Business.EF_StdHeader)Activator.CreateInstance(typeof(Common.Business.EF_StdHeader));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.SetStd = data.SetStd;
				                item.SetUnit = data.SetUnit;
				                item.SetCode = data.SetCode;
				                item.SetName = data.SetName;
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
				var exp = lambda.Resolve<EF_StdHeader>();
                var i = (from p in ctx.DataContext.EF_StdHeader.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.SetStd = i.SetStd;
										this.SetUnit = i.SetUnit;
										this.SetCode = i.SetCode;
										this.SetName = i.SetName;
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

	public class EF_StdHeadersFactory : Common.Business.EF_StdHeaders
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_StdHeader
                        select EF_StdHeaderFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_StdHeader
                        select EF_StdHeaderFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_StdHeader>();
                var i = (from p in ctx.DataContext.EF_StdHeader.Where(exp)
                         select EF_StdHeaderFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_StdHeader>();
                var i = from p in ctx.DataContext.EF_StdHeader.Where(exp)
                         select EF_StdHeaderFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
