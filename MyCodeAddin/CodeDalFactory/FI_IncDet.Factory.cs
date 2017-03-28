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
	public class FI_IncDetFactory:Common.Business.FI_IncDet
    {
        public static Common.Business.FI_IncDet Fetch(FI_IncDet data)
        {
            Common.Business.FI_IncDet item = (Common.Business.FI_IncDet)Activator.CreateInstance(typeof(Common.Business.FI_IncDet));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.IncDetCode = data.IncDetCode;
				                item.IncDetName = data.IncDetName;
				                item.IncDetTypeCode = data.IncDetTypeCode;
				                item.SIncItemCode = data.SIncItemCode;
				                item.FundBudAreaCode = data.FundBudAreaCode;
				                item.AllotBusTypeCode = data.AllotBusTypeCode;
				                item.IsInternal = data.IsInternal;
				                item.AccCode = data.AccCode;
				                item.BAccCode = data.BAccCode;
				                item.Active = data.Active;
				                item.IsDel = data.IsDel;
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
				var exp = lambda.Resolve<FI_IncDet>();
                var i = (from p in ctx.DataContext.FI_IncDet.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.IncDetCode = i.IncDetCode;
										this.IncDetName = i.IncDetName;
										this.IncDetTypeCode = i.IncDetTypeCode;
										this.SIncItemCode = i.SIncItemCode;
										this.FundBudAreaCode = i.FundBudAreaCode;
										this.AllotBusTypeCode = i.AllotBusTypeCode;
										this.IsInternal = i.IsInternal;
										this.AccCode = i.AccCode;
										this.BAccCode = i.BAccCode;
										this.Active = i.Active;
										this.IsDel = i.IsDel;
										this.Memo = i.Memo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_IncDetsFactory : Common.Business.FI_IncDets
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_IncDet
                        select FI_IncDetFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_IncDet
                        select FI_IncDetFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_IncDet>();
                var i = (from p in ctx.DataContext.FI_IncDet.Where(exp)
                         select FI_IncDetFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_IncDet>();
                var i = from p in ctx.DataContext.FI_IncDet.Where(exp)
                         select FI_IncDetFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
