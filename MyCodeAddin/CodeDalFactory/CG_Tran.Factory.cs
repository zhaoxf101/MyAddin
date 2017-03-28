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
	public class CG_TranFactory:Common.Business.CG_Tran
    {
        public static Common.Business.CG_Tran Fetch(CG_Tran data)
        {
            Common.Business.CG_Tran item = (Common.Business.CG_Tran)Activator.CreateInstance(typeof(Common.Business.CG_Tran));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.TranNo = data.TranNo;
				                item.PayWayCode = data.PayWayCode;
				                item.TranText = data.TranText;
				                item.TranMemo = data.TranMemo;
				                item.TranDate = data.TranDate;
				                item.TranDateTime = data.TranDateTime;
				                item.PersonId = data.PersonId;
				                item.ClientIP = data.ClientIP;
				                item.ClientNo = data.ClientNo;
				                item.OutTranNo = data.OutTranNo;
				                item.OutDate = data.OutDate;
				                item.OutSign = data.OutSign;
				                item.FeeType = data.FeeType;
				                item.UnitedBankId = data.UnitedBankId;
				                item.TranOrderId = data.TranOrderId;
				                item.TranOrderNo = data.TranOrderNo;
				                item.TranOrderDate = data.TranOrderDate;
				                item.FeeOrderId = data.FeeOrderId;
				                item.FeeOrderNo = data.FeeOrderNo;
				                item.TranAmt = data.TranAmt;
				                item.CreateUser = data.CreateUser;
				                item.CreateDate = data.CreateDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CG_Tran>();
                var i = (from p in ctx.DataContext.CG_Tran.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.TranNo = i.TranNo;
										this.PayWayCode = i.PayWayCode;
										this.TranText = i.TranText;
										this.TranMemo = i.TranMemo;
										this.TranDate = i.TranDate;
										this.TranDateTime = i.TranDateTime;
										this.PersonId = i.PersonId;
										this.ClientIP = i.ClientIP;
										this.ClientNo = i.ClientNo;
										this.OutTranNo = i.OutTranNo;
										this.OutDate = i.OutDate;
										this.OutSign = i.OutSign;
										this.FeeType = i.FeeType;
										this.UnitedBankId = i.UnitedBankId;
										this.TranOrderId = i.TranOrderId;
										this.TranOrderNo = i.TranOrderNo;
										this.TranOrderDate = i.TranOrderDate;
										this.FeeOrderId = i.FeeOrderId;
										this.FeeOrderNo = i.FeeOrderNo;
										this.TranAmt = i.TranAmt;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
					}
            }
        }
	}

	public class CG_TransFactory : Common.Business.CG_Trans
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CG_Tran
                        select CG_TranFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CG_Tran
                        select CG_TranFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CG_Tran>();
                var i = (from p in ctx.DataContext.CG_Tran.Where(exp)
                         select CG_TranFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CG_Tran>();
                var i = from p in ctx.DataContext.CG_Tran.Where(exp)
                         select CG_TranFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
