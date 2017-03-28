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
	public class CO_ProfitCtrFactory:Common.Business.CO_ProfitCtr
    {
        public static Common.Business.CO_ProfitCtr Fetch(CO_ProfitCtr data)
        {
            Common.Business.CO_ProfitCtr item = (Common.Business.CO_ProfitCtr)Activator.CreateInstance(typeof(Common.Business.CO_ProfitCtr));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.CostArea = data.CostArea;
				                item.ProfitCtr = data.ProfitCtr;
				                item.ProfitCtrGroup = data.ProfitCtrGroup;
				                item.SText = data.SText;
				                item.LText = data.LText;
				                item.Active = data.Active;
				                item.IsDel = data.IsDel;
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
				var exp = lambda.Resolve<CO_ProfitCtr>();
                var i = (from p in ctx.DataContext.CO_ProfitCtr.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.CostArea = i.CostArea;
										this.ProfitCtr = i.ProfitCtr;
										this.ProfitCtrGroup = i.ProfitCtrGroup;
										this.SText = i.SText;
										this.LText = i.LText;
										this.Active = i.Active;
										this.IsDel = i.IsDel;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class CO_ProfitCtrsFactory : Common.Business.CO_ProfitCtrs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CO_ProfitCtr
                        select CO_ProfitCtrFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CO_ProfitCtr
                        select CO_ProfitCtrFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CO_ProfitCtr>();
                var i = (from p in ctx.DataContext.CO_ProfitCtr.Where(exp)
                         select CO_ProfitCtrFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CO_ProfitCtr>();
                var i = from p in ctx.DataContext.CO_ProfitCtr.Where(exp)
                         select CO_ProfitCtrFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
