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
	public class PM_InvProjTypeFactory:Common.Business.PM_InvProjType
    {
        public static Common.Business.PM_InvProjType Fetch(PM_InvProjType data)
        {
            Common.Business.PM_InvProjType item = (Common.Business.PM_InvProjType)Activator.CreateInstance(typeof(Common.Business.PM_InvProjType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.InvProjTypeCode = data.InvProjTypeCode;
				                item.InvProjTypeName = data.InvProjTypeName;
				                item.Active = data.Active;
				                item.Memo = data.Memo;
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
				var exp = lambda.Resolve<PM_InvProjType>();
                var i = (from p in ctx.DataContext.PM_InvProjType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.InvProjTypeCode = i.InvProjTypeCode;
										this.InvProjTypeName = i.InvProjTypeName;
										this.Active = i.Active;
										this.Memo = i.Memo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_InvProjTypesFactory : Common.Business.PM_InvProjTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_InvProjType
                        select PM_InvProjTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_InvProjType
                        select PM_InvProjTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_InvProjType>();
                var i = (from p in ctx.DataContext.PM_InvProjType.Where(exp)
                         select PM_InvProjTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_InvProjType>();
                var i = from p in ctx.DataContext.PM_InvProjType.Where(exp)
                         select PM_InvProjTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
