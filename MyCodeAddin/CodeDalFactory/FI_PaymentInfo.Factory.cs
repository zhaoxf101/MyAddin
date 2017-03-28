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
	public class FI_PaymentInfoFactory:Common.Business.FI_PaymentInfo
    {
        public static Common.Business.FI_PaymentInfo Fetch(FI_PaymentInfo data)
        {
            Common.Business.FI_PaymentInfo item = (Common.Business.FI_PaymentInfo)Activator.CreateInstance(typeof(Common.Business.FI_PaymentInfo));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ObjType = data.ObjType;
				                item.ItemId = data.ItemId;
				                item.BankCode = data.BankCode;
				                item.PayType = data.PayType;
				                item.PesonId = data.PesonId;
				                item.IsExpBus = data.IsExpBus;
				                item.UserName = data.UserName;
				                item.BankName = data.BankName;
				                item.UnitedBankId = data.UnitedBankId;
				                item.Amt = data.Amt;
				                item.ActAmt = data.ActAmt;
				                item.ActTaxAmt = data.ActTaxAmt;
				                item.PayText = data.PayText;
				                item.RowId = data.RowId;
				                item.PaymentAmt = data.PaymentAmt;
				                item.IsPublic = data.IsPublic;
				                item.IsOffCard = data.IsOffCard;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_PaymentInfo>();
                var i = (from p in ctx.DataContext.FI_PaymentInfo.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ObjType = i.ObjType;
										this.ItemId = i.ItemId;
										this.BankCode = i.BankCode;
										this.PayType = i.PayType;
										this.PesonId = i.PesonId;
										this.IsExpBus = i.IsExpBus;
										this.UserName = i.UserName;
										this.BankName = i.BankName;
										this.UnitedBankId = i.UnitedBankId;
										this.Amt = i.Amt;
										this.ActAmt = i.ActAmt;
										this.ActTaxAmt = i.ActTaxAmt;
										this.PayText = i.PayText;
										this.RowId = i.RowId;
										this.PaymentAmt = i.PaymentAmt;
										this.IsPublic = i.IsPublic;
										this.IsOffCard = i.IsOffCard;
					}
            }
        }
	}

	public class FI_PaymentInfosFactory : Common.Business.FI_PaymentInfos
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PaymentInfo
                        select FI_PaymentInfoFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PaymentInfo
                        select FI_PaymentInfoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PaymentInfo>();
                var i = (from p in ctx.DataContext.FI_PaymentInfo.Where(exp)
                         select FI_PaymentInfoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PaymentInfo>();
                var i = from p in ctx.DataContext.FI_PaymentInfo.Where(exp)
                         select FI_PaymentInfoFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
