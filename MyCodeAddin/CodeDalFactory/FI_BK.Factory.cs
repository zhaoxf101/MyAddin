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
	public class FI_BKFactory:Common.Business.FI_BK
    {
        public static Common.Business.FI_BK Fetch(FI_BK data)
        {
            Common.Business.FI_BK item = (Common.Business.FI_BK)Activator.CreateInstance(typeof(Common.Business.FI_BK));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.BKCode = data.BKCode;
				                item.BKName = data.BKName;
				                item.BKSim = data.BKSim;
				                item.IsBankTran = data.IsBankTran;
				                item.CanChk = data.CanChk;
				                item.Active = data.Active;
				                item.IsPassCode = data.IsPassCode;
				                item.Customer = data.Customer;
				                item.BankUserId = data.BankUserId;
				                item.CIS = data.CIS;
				                item.BankParentId = data.BankParentId;
				                item.BankType = data.BankType;
				                item.Version = data.Version;
				                item.GroupCIS = data.GroupCIS;
				                item.IP = data.IP;
				                item.Port = data.Port;
				                item.URL = data.URL;
				                item.URL1 = data.URL1;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.BillCode = data.BillCode;
				                item.BillProName = data.BillProName;
				                item.UseCode = data.UseCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_BK>();
                var i = (from p in ctx.DataContext.FI_BK.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.BKCode = i.BKCode;
										this.BKName = i.BKName;
										this.BKSim = i.BKSim;
										this.IsBankTran = i.IsBankTran;
										this.CanChk = i.CanChk;
										this.Active = i.Active;
										this.IsPassCode = i.IsPassCode;
										this.Customer = i.Customer;
										this.BankUserId = i.BankUserId;
										this.CIS = i.CIS;
										this.BankParentId = i.BankParentId;
										this.BankType = i.BankType;
										this.Version = i.Version;
										this.GroupCIS = i.GroupCIS;
										this.IP = i.IP;
										this.Port = i.Port;
										this.URL = i.URL;
										this.URL1 = i.URL1;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.BillCode = i.BillCode;
										this.BillProName = i.BillProName;
										this.UseCode = i.UseCode;
					}
            }
        }
	}

	public class FI_BKsFactory : Common.Business.FI_BKs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BK
                        select FI_BKFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BK
                        select FI_BKFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BK>();
                var i = (from p in ctx.DataContext.FI_BK.Where(exp)
                         select FI_BKFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BK>();
                var i = from p in ctx.DataContext.FI_BK.Where(exp)
                         select FI_BKFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
