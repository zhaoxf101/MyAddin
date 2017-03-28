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
	public class EF_FKeyTableFactory:Common.Business.EF_FKeyTable
    {
        public static Common.Business.EF_FKeyTable Fetch(EF_FKeyTable data)
        {
            Common.Business.EF_FKeyTable item = (Common.Business.EF_FKeyTable)Activator.CreateInstance(typeof(Common.Business.EF_FKeyTable));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TableName = data.TableName;
				                item.TableField = data.TableField;
				                item.RowStatus = data.RowStatus;
				                item.CheckTable = data.CheckTable;
				                item.InputCheckX = data.InputCheckX;
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
				var exp = lambda.Resolve<EF_FKeyTable>();
                var i = (from p in ctx.DataContext.EF_FKeyTable.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TableName = i.TableName;
										this.TableField = i.TableField;
										this.RowStatus = i.RowStatus;
										this.CheckTable = i.CheckTable;
										this.InputCheckX = i.InputCheckX;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class EF_FKeyTablesFactory : Common.Business.EF_FKeyTables
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_FKeyTable
                        select EF_FKeyTableFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_FKeyTable
                        select EF_FKeyTableFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_FKeyTable>();
                var i = (from p in ctx.DataContext.EF_FKeyTable.Where(exp)
                         select EF_FKeyTableFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_FKeyTable>();
                var i = from p in ctx.DataContext.EF_FKeyTable.Where(exp)
                         select EF_FKeyTableFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
