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
	public class FI_SBudExpFunFactory:Common.Business.FI_SBudExpFun
    {
        public static Common.Business.FI_SBudExpFun Fetch(FI_SBudExpFun data)
        {
            Common.Business.FI_SBudExpFun item = (Common.Business.FI_SBudExpFun)Activator.CreateInstance(typeof(Common.Business.FI_SBudExpFun));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SBudExpFunCode = data.SBudExpFunCode;
				                item.SBudExpFunName = data.SBudExpFunName;
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
				var exp = lambda.Resolve<FI_SBudExpFun>();
                var i = (from p in ctx.DataContext.FI_SBudExpFun.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SBudExpFunCode = i.SBudExpFunCode;
										this.SBudExpFunName = i.SBudExpFunName;
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

	public class FI_SBudExpFunsFactory : Common.Business.FI_SBudExpFuns
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_SBudExpFun
                        select FI_SBudExpFunFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_SBudExpFun
                        select FI_SBudExpFunFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_SBudExpFun>();
                var i = (from p in ctx.DataContext.FI_SBudExpFun.Where(exp)
                         select FI_SBudExpFunFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_SBudExpFun>();
                var i = from p in ctx.DataContext.FI_SBudExpFun.Where(exp)
                         select FI_SBudExpFunFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
