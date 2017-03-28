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
	public class FI_PayListFactory:Common.Business.FI_PayList
    {
        public static Common.Business.FI_PayList Fetch(FI_PayList data)
        {
            Common.Business.FI_PayList item = (Common.Business.FI_PayList)Activator.CreateInstance(typeof(Common.Business.FI_PayList));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.VouchNo = data.VouchNo;
				                item.LineNR = data.LineNR;
				                item.PersonId = data.PersonId;
				                item.PayType = data.PayType;
				                item.PAccCode = data.PAccCode;
				                item.PAccount = data.PAccount;
				                item.PBankId = data.PBankId;
				                item.RAccount = data.RAccount;
				                item.RBankId = data.RBankId;
				                item.IsProxy = data.IsProxy;
				                item.ProxyId = data.ProxyId;
				                item.AAccount = data.AAccount;
				                item.ABankId = data.ABankId;
				                item.Amt = data.Amt;
				                item.IsSucc1 = data.IsSucc1;
				                item.IsSucc2 = data.IsSucc2;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_PayList>();
                var i = (from p in ctx.DataContext.FI_PayList.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.VouchNo = i.VouchNo;
										this.LineNR = i.LineNR;
										this.PersonId = i.PersonId;
										this.PayType = i.PayType;
										this.PAccCode = i.PAccCode;
										this.PAccount = i.PAccount;
										this.PBankId = i.PBankId;
										this.RAccount = i.RAccount;
										this.RBankId = i.RBankId;
										this.IsProxy = i.IsProxy;
										this.ProxyId = i.ProxyId;
										this.AAccount = i.AAccount;
										this.ABankId = i.ABankId;
										this.Amt = i.Amt;
										this.IsSucc1 = i.IsSucc1;
										this.IsSucc2 = i.IsSucc2;
					}
            }
        }
	}

	public class FI_PayListsFactory : Common.Business.FI_PayLists
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PayList
                        select FI_PayListFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PayList
                        select FI_PayListFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PayList>();
                var i = (from p in ctx.DataContext.FI_PayList.Where(exp)
                         select FI_PayListFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PayList>();
                var i = from p in ctx.DataContext.FI_PayList.Where(exp)
                         select FI_PayListFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
