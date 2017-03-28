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
	public class FI_PBudExpFunFactory:Common.Business.FI_PBudExpFun
    {
        public static Common.Business.FI_PBudExpFun Fetch(FI_PBudExpFun data)
        {
            Common.Business.FI_PBudExpFun item = (Common.Business.FI_PBudExpFun)Activator.CreateInstance(typeof(Common.Business.FI_PBudExpFun));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PBudExpFunCode = data.PBudExpFunCode;
				                item.PBudExpFunName = data.PBudExpFunName;
				                item.PCode = data.PCode;
				                item.IsGroup = data.IsGroup;
				                item.IsSys = data.IsSys;
				                item.IsPub = data.IsPub;
				                item.IsRoot = data.IsRoot;
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
				var exp = lambda.Resolve<FI_PBudExpFun>();
                var i = (from p in ctx.DataContext.FI_PBudExpFun.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PBudExpFunCode = i.PBudExpFunCode;
										this.PBudExpFunName = i.PBudExpFunName;
										this.PCode = i.PCode;
										this.IsGroup = i.IsGroup;
										this.IsSys = i.IsSys;
										this.IsPub = i.IsPub;
										this.IsRoot = i.IsRoot;
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

	public class FI_PBudExpFunsFactory : Common.Business.FI_PBudExpFuns
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PBudExpFun
                        select FI_PBudExpFunFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PBudExpFun
                        select FI_PBudExpFunFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PBudExpFun>();
                var i = (from p in ctx.DataContext.FI_PBudExpFun.Where(exp)
                         select FI_PBudExpFunFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PBudExpFun>();
                var i = from p in ctx.DataContext.FI_PBudExpFun.Where(exp)
                         select FI_PBudExpFunFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
