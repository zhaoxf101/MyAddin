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
	public class FI_VoucherResFactory:Common.Business.FI_VoucherRes
    {
        public static Common.Business.FI_VoucherRes Fetch(FI_VoucherRes data)
        {
            Common.Business.FI_VoucherRes item = (Common.Business.FI_VoucherRes)Activator.CreateInstance(typeof(Common.Business.FI_VoucherRes));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.VouchNo = data.VouchNo;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.LineNR = data.LineNR;
				                item.CostCtr = data.CostCtr;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemRow = data.ExpItemRow;
				                item.ExpItemCode = data.ExpItemCode;
				                item.ResouItemCode = data.ResouItemCode;
				                item.Qty = data.Qty;
				                item.LAmt = data.LAmt;
				                item.VAmt = data.VAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_VoucherRes>();
                var i = (from p in ctx.DataContext.FI_VoucherRes.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.VouchNo = i.VouchNo;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.LineNR = i.LineNR;
										this.CostCtr = i.CostCtr;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ExpItemRow = i.ExpItemRow;
										this.ExpItemCode = i.ExpItemCode;
										this.ResouItemCode = i.ResouItemCode;
										this.Qty = i.Qty;
										this.LAmt = i.LAmt;
										this.VAmt = i.VAmt;
					}
            }
        }
	}

	public class FI_VoucherRessFactory : Common.Business.FI_VoucherRess
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_VoucherRes
                        select FI_VoucherResFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_VoucherRes
                        select FI_VoucherResFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_VoucherRes>();
                var i = (from p in ctx.DataContext.FI_VoucherRes.Where(exp)
                         select FI_VoucherResFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_VoucherRes>();
                var i = from p in ctx.DataContext.FI_VoucherRes.Where(exp)
                         select FI_VoucherResFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
