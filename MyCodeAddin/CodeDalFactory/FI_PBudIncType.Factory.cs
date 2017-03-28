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
	public class FI_PBudIncTypeFactory:Common.Business.FI_PBudIncType
    {
        public static Common.Business.FI_PBudIncType Fetch(FI_PBudIncType data)
        {
            Common.Business.FI_PBudIncType item = (Common.Business.FI_PBudIncType)Activator.CreateInstance(typeof(Common.Business.FI_PBudIncType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PBudIncTypeCode = data.PBudIncTypeCode;
				                item.PBudIncTypeName = data.PBudIncTypeName;
				                item.PCode = data.PCode;
				                item.IsGroup = data.IsGroup;
				                item.Active = data.Active;
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
				var exp = lambda.Resolve<FI_PBudIncType>();
                var i = (from p in ctx.DataContext.FI_PBudIncType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PBudIncTypeCode = i.PBudIncTypeCode;
										this.PBudIncTypeName = i.PBudIncTypeName;
										this.PCode = i.PCode;
										this.IsGroup = i.IsGroup;
										this.Active = i.Active;
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

	public class FI_PBudIncTypesFactory : Common.Business.FI_PBudIncTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PBudIncType
                        select FI_PBudIncTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PBudIncType
                        select FI_PBudIncTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PBudIncType>();
                var i = (from p in ctx.DataContext.FI_PBudIncType.Where(exp)
                         select FI_PBudIncTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PBudIncType>();
                var i = from p in ctx.DataContext.FI_PBudIncType.Where(exp)
                         select FI_PBudIncTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
