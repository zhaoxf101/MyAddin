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
	public class FE_FeeFactory:Common.Business.FE_Fee
    {
        public static Common.Business.FE_Fee Fetch(FE_Fee data)
        {
            Common.Business.FE_Fee item = (Common.Business.FE_Fee)Activator.CreateInstance(typeof(Common.Business.FE_Fee));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.FeeItemCode = data.FeeItemCode;
				                item.FeeItemName = data.FeeItemName;
				                item.FeeItemOrder = data.FeeItemOrder;
				                item.Remark = data.Remark;
				                item.AccType = data.AccType;
				                item.AccCode = data.AccCode;
				                item.GLMark = data.GLMark;
				                item.IsTimeCheck = data.IsTimeCheck;
				                item.IsFeeStd = data.IsFeeStd;
				                item.IsOuter = data.IsOuter;
				                item.UserGroup = data.UserGroup;
				                item.Active = data.Active;
				                item.FeeItemType = data.FeeItemType;
				                item.TCode = data.TCode;
				                item.SumType = data.SumType;
				                item.IsOpenItem = data.IsOpenItem;
				                item.IncDetCode = data.IncDetCode;
				                item.IsInc = data.IsInc;
				                item.ProfitCtrType = data.ProfitCtrType;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_Fee>();
                var i = (from p in ctx.DataContext.FE_Fee.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.FeeItemCode = i.FeeItemCode;
										this.FeeItemName = i.FeeItemName;
										this.FeeItemOrder = i.FeeItemOrder;
										this.Remark = i.Remark;
										this.AccType = i.AccType;
										this.AccCode = i.AccCode;
										this.GLMark = i.GLMark;
										this.IsTimeCheck = i.IsTimeCheck;
										this.IsFeeStd = i.IsFeeStd;
										this.IsOuter = i.IsOuter;
										this.UserGroup = i.UserGroup;
										this.Active = i.Active;
										this.FeeItemType = i.FeeItemType;
										this.TCode = i.TCode;
										this.SumType = i.SumType;
										this.IsOpenItem = i.IsOpenItem;
										this.IncDetCode = i.IncDetCode;
										this.IsInc = i.IsInc;
										this.ProfitCtrType = i.ProfitCtrType;
					}
            }
        }
	}

	public class FE_FeesFactory : Common.Business.FE_Fees
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_Fee
                        select FE_FeeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_Fee
                        select FE_FeeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_Fee>();
                var i = (from p in ctx.DataContext.FE_Fee.Where(exp)
                         select FE_FeeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_Fee>();
                var i = from p in ctx.DataContext.FE_Fee.Where(exp)
                         select FE_FeeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
