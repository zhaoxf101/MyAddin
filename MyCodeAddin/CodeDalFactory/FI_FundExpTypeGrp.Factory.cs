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
	public class FI_FundExpTypeGrpFactory:Common.Business.FI_FundExpTypeGrp
    {
        public static Common.Business.FI_FundExpTypeGrp Fetch(FI_FundExpTypeGrp data)
        {
            Common.Business.FI_FundExpTypeGrp item = (Common.Business.FI_FundExpTypeGrp)Activator.CreateInstance(typeof(Common.Business.FI_FundExpTypeGrp));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.FundExpTypeGrpCode = data.FundExpTypeGrpCode;
				                item.FundExpTypeGrpName = data.FundExpTypeGrpName;
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
				var exp = lambda.Resolve<FI_FundExpTypeGrp>();
                var i = (from p in ctx.DataContext.FI_FundExpTypeGrp.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.FundExpTypeGrpCode = i.FundExpTypeGrpCode;
										this.FundExpTypeGrpName = i.FundExpTypeGrpName;
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

	public class FI_FundExpTypeGrpsFactory : Common.Business.FI_FundExpTypeGrps
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_FundExpTypeGrp
                        select FI_FundExpTypeGrpFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_FundExpTypeGrp
                        select FI_FundExpTypeGrpFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_FundExpTypeGrp>();
                var i = (from p in ctx.DataContext.FI_FundExpTypeGrp.Where(exp)
                         select FI_FundExpTypeGrpFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_FundExpTypeGrp>();
                var i = from p in ctx.DataContext.FI_FundExpTypeGrp.Where(exp)
                         select FI_FundExpTypeGrpFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
