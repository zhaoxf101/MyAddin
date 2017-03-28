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
	public class FI_ExpFundTypeFactory:Common.Business.FI_ExpFundType
    {
        public static Common.Business.FI_ExpFundType Fetch(FI_ExpFundType data)
        {
            Common.Business.FI_ExpFundType item = (Common.Business.FI_ExpFundType)Activator.CreateInstance(typeof(Common.Business.FI_ExpFundType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpFundTypeCode = data.ExpFundTypeCode;
				                item.ExpFundTypeName = data.ExpFundTypeName;
				                item.Active = data.Active;
				                item.IsGroup = data.IsGroup;
				                item.PConCode = data.PConCode;
				                item.IsSys = data.IsSys;
				                item.IsPub = data.IsPub;
				                item.IsRoot = data.IsRoot;
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
				var exp = lambda.Resolve<FI_ExpFundType>();
                var i = (from p in ctx.DataContext.FI_ExpFundType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpFundTypeCode = i.ExpFundTypeCode;
										this.ExpFundTypeName = i.ExpFundTypeName;
										this.Active = i.Active;
										this.IsGroup = i.IsGroup;
										this.PConCode = i.PConCode;
										this.IsSys = i.IsSys;
										this.IsPub = i.IsPub;
										this.IsRoot = i.IsRoot;
										this.Memo = i.Memo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_ExpFundTypesFactory : Common.Business.FI_ExpFundTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpFundType
                        select FI_ExpFundTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpFundType
                        select FI_ExpFundTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpFundType>();
                var i = (from p in ctx.DataContext.FI_ExpFundType.Where(exp)
                         select FI_ExpFundTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpFundType>();
                var i = from p in ctx.DataContext.FI_ExpFundType.Where(exp)
                         select FI_ExpFundTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
