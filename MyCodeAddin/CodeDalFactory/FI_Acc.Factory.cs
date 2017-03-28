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
	public class FI_AccFactory:Common.Business.FI_Acc
    {
        public static Common.Business.FI_Acc Fetch(FI_Acc data)
        {
            Common.Business.FI_Acc item = (Common.Business.FI_Acc)Activator.CreateInstance(typeof(Common.Business.FI_Acc));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.AccChart = data.AccChart;
				                item.AccCode = data.AccCode;
				                item.AccCls = data.AccCls;
				                item.IsBalance = data.IsBalance;
				                item.GAccCode = data.GAccCode;
				                item.AccGrp = data.AccGrp;
				                item.WDelX = data.WDelX;
				                item.SText = data.SText;
				                item.LText = data.LText;
				                item.FuncArea = data.FuncArea;
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
				var exp = lambda.Resolve<FI_Acc>();
                var i = (from p in ctx.DataContext.FI_Acc.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.AccChart = i.AccChart;
										this.AccCode = i.AccCode;
										this.AccCls = i.AccCls;
										this.IsBalance = i.IsBalance;
										this.GAccCode = i.GAccCode;
										this.AccGrp = i.AccGrp;
										this.WDelX = i.WDelX;
										this.SText = i.SText;
										this.LText = i.LText;
										this.FuncArea = i.FuncArea;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_AccsFactory : Common.Business.FI_Accs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_Acc
                        select FI_AccFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_Acc
                        select FI_AccFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_Acc>();
                var i = (from p in ctx.DataContext.FI_Acc.Where(exp)
                         select FI_AccFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_Acc>();
                var i = from p in ctx.DataContext.FI_Acc.Where(exp)
                         select FI_AccFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
