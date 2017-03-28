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
	public class CG_BillFactory:Common.Business.CG_Bill
    {
        public static Common.Business.CG_Bill Fetch(CG_Bill data)
        {
            Common.Business.CG_Bill item = (Common.Business.CG_Bill)Activator.CreateInstance(typeof(Common.Business.CG_Bill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.BillNo = data.BillNo;
				                item.IntervalCode = data.IntervalCode;
				                item.FeeItemCode = data.FeeItemCode;
				                item.BillTypeCode = data.BillTypeCode;
				                item.BillText = data.BillText;
				                item.SText = data.SText;
				                item.Memo = data.Memo;
				                item.UserGroup = data.UserGroup;
				                item.IsSubmit = data.IsSubmit;
				                item.WorkFlowId = data.WorkFlowId;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.IsSub = data.IsSub;
				                item.IsCancel = data.IsCancel;
				                item.IsAppovel = data.IsAppovel;
				                item.OrderNo = data.OrderNo;
				                item.AdjBillNo = data.AdjBillNo;
				                item.AdjOrdNo = data.AdjOrdNo;
				                item.IsAdd = data.IsAdd;
				                item.CreateUser = data.CreateUser;
				                item.CreateDate = data.CreateDate;
				                item.ChangeUser = data.ChangeUser;
				                item.ChangeDate = data.ChangeDate;
				                item.BillAmt = data.BillAmt;
				                item.IsSpecAmt = data.IsSpecAmt;
				                item.IsOnce = data.IsOnce;
				                item.IsAdj = data.IsAdj;
				                item.IsClose = data.IsClose;
				                item.DepCode = data.DepCode;
				                item.IsOut = data.IsOut;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CG_Bill>();
                var i = (from p in ctx.DataContext.CG_Bill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.BillNo = i.BillNo;
										this.IntervalCode = i.IntervalCode;
										this.FeeItemCode = i.FeeItemCode;
										this.BillTypeCode = i.BillTypeCode;
										this.BillText = i.BillText;
										this.SText = i.SText;
										this.Memo = i.Memo;
										this.UserGroup = i.UserGroup;
										this.IsSubmit = i.IsSubmit;
										this.WorkFlowId = i.WorkFlowId;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.IsSub = i.IsSub;
										this.IsCancel = i.IsCancel;
										this.IsAppovel = i.IsAppovel;
										this.OrderNo = i.OrderNo;
										this.AdjBillNo = i.AdjBillNo;
										this.AdjOrdNo = i.AdjOrdNo;
										this.IsAdd = i.IsAdd;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
										this.BillAmt = i.BillAmt;
										this.IsSpecAmt = i.IsSpecAmt;
										this.IsOnce = i.IsOnce;
										this.IsAdj = i.IsAdj;
										this.IsClose = i.IsClose;
										this.DepCode = i.DepCode;
										this.IsOut = i.IsOut;
					}
            }
        }
	}

	public class CG_BillsFactory : Common.Business.CG_Bills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CG_Bill
                        select CG_BillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CG_Bill
                        select CG_BillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CG_Bill>();
                var i = (from p in ctx.DataContext.CG_Bill.Where(exp)
                         select CG_BillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CG_Bill>();
                var i = from p in ctx.DataContext.CG_Bill.Where(exp)
                         select CG_BillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
