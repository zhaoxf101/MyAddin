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
	public class FI_PBudExpEcoFactory:Common.Business.FI_PBudExpEco
    {
        public static Common.Business.FI_PBudExpEco Fetch(FI_PBudExpEco data)
        {
            Common.Business.FI_PBudExpEco item = (Common.Business.FI_PBudExpEco)Activator.CreateInstance(typeof(Common.Business.FI_PBudExpEco));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.PBudExpEcoName = data.PBudExpEcoName;
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
				var exp = lambda.Resolve<FI_PBudExpEco>();
                var i = (from p in ctx.DataContext.FI_PBudExpEco.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.PBudExpEcoName = i.PBudExpEcoName;
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

	public class FI_PBudExpEcosFactory : Common.Business.FI_PBudExpEcos
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PBudExpEco
                        select FI_PBudExpEcoFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PBudExpEco
                        select FI_PBudExpEcoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PBudExpEco>();
                var i = (from p in ctx.DataContext.FI_PBudExpEco.Where(exp)
                         select FI_PBudExpEcoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PBudExpEco>();
                var i = from p in ctx.DataContext.FI_PBudExpEco.Where(exp)
                         select FI_PBudExpEcoFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
