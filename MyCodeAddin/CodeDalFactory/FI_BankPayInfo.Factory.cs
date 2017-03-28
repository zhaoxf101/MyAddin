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
	public class FI_BankPayInfoFactory:Common.Business.FI_BankPayInfo
    {
        public static Common.Business.FI_BankPayInfo Fetch(FI_BankPayInfo data)
        {
            Common.Business.FI_BankPayInfo item = (Common.Business.FI_BankPayInfo)Activator.CreateInstance(typeof(Common.Business.FI_BankPayInfo));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ObjType = data.ObjType;
				                item.ItemId = data.ItemId;
				                item.RBankCode = data.RBankCode;
				                item.PayType = data.PayType;
				                item.PesonId = data.PesonId;
				                item.RemType = data.RemType;
				                item.RowId = data.RowId;
				                item.GovPayCode = data.GovPayCode;
				                item.PersonName = data.PersonName;
				                item.Amt = data.Amt;
				                item.IsProxy = data.IsProxy;
				                item.IsConfig = data.IsConfig;
				                item.PBankCode = data.PBankCode;
				                item.PBankId = data.PBankId;
				                item.PUnitedBankId = data.PUnitedBankId;
				                item.PAccCode = data.PAccCode;
				                item.BAccCode = data.BAccCode;
				                item.ProxyId = data.ProxyId;
				                item.ProxyCode = data.ProxyCode;
				                item.AUnitedBankId = data.AUnitedBankId;
				                item.RUnitedBankId = data.RUnitedBankId;
				                item.RBankName = data.RBankName;
				                item.IsPublic = data.IsPublic;
				                item.CanProxy = data.CanProxy;
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
				var exp = lambda.Resolve<FI_BankPayInfo>();
                var i = (from p in ctx.DataContext.FI_BankPayInfo.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ObjType = i.ObjType;
										this.ItemId = i.ItemId;
										this.RBankCode = i.RBankCode;
										this.PayType = i.PayType;
										this.PesonId = i.PesonId;
										this.RemType = i.RemType;
										this.RowId = i.RowId;
										this.GovPayCode = i.GovPayCode;
										this.PersonName = i.PersonName;
										this.Amt = i.Amt;
										this.IsProxy = i.IsProxy;
										this.IsConfig = i.IsConfig;
										this.PBankCode = i.PBankCode;
										this.PBankId = i.PBankId;
										this.PUnitedBankId = i.PUnitedBankId;
										this.PAccCode = i.PAccCode;
										this.BAccCode = i.BAccCode;
										this.ProxyId = i.ProxyId;
										this.ProxyCode = i.ProxyCode;
										this.AUnitedBankId = i.AUnitedBankId;
										this.RUnitedBankId = i.RUnitedBankId;
										this.RBankName = i.RBankName;
										this.IsPublic = i.IsPublic;
										this.CanProxy = i.CanProxy;
										this.IsOffCard = i.IsOffCard;
					}
            }
        }
	}

	public class FI_BankPayInfosFactory : Common.Business.FI_BankPayInfos
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BankPayInfo
                        select FI_BankPayInfoFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BankPayInfo
                        select FI_BankPayInfoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BankPayInfo>();
                var i = (from p in ctx.DataContext.FI_BankPayInfo.Where(exp)
                         select FI_BankPayInfoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BankPayInfo>();
                var i = from p in ctx.DataContext.FI_BankPayInfo.Where(exp)
                         select FI_BankPayInfoFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
