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
	public class FI_PayBackFactory:Common.Business.FI_PayBack
    {
        public static Common.Business.FI_PayBack Fetch(FI_PayBack data)
        {
            Common.Business.FI_PayBack item = (Common.Business.FI_PayBack)Activator.CreateInstance(typeof(Common.Business.FI_PayBack));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.PayBackNo = data.PayBackNo;
				                item.PayBankText = data.PayBankText;
				                item.BusType = data.BusType;
				                item.AccType = data.AccType;
				                item.PayBackType = data.PayBackType;
				                item.GLMarK = data.GLMarK;
				                item.PartyCode = data.PartyCode;
				                item.Amt = data.Amt;
				                item.RelPartyX = data.RelPartyX;
				                item.IsSubmit = data.IsSubmit;
				                item.Approved = data.Approved;
				                item.AccDateTime = data.AccDateTime;
				                item.GenVouX = data.GenVouX;
				                item.OpenVouchNo = data.OpenVouchNo;
				                item.VouchText = data.VouchText;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.CheckUser = data.CheckUser;
				                item.CheckDate = data.CheckDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_PayBack>();
                var i = (from p in ctx.DataContext.FI_PayBack.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.PayBackNo = i.PayBackNo;
										this.PayBankText = i.PayBankText;
										this.BusType = i.BusType;
										this.AccType = i.AccType;
										this.PayBackType = i.PayBackType;
										this.GLMarK = i.GLMarK;
										this.PartyCode = i.PartyCode;
										this.Amt = i.Amt;
										this.RelPartyX = i.RelPartyX;
										this.IsSubmit = i.IsSubmit;
										this.Approved = i.Approved;
										this.AccDateTime = i.AccDateTime;
										this.GenVouX = i.GenVouX;
										this.OpenVouchNo = i.OpenVouchNo;
										this.VouchText = i.VouchText;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.CheckUser = i.CheckUser;
										this.CheckDate = i.CheckDate;
					}
            }
        }
	}

	public class FI_PayBacksFactory : Common.Business.FI_PayBacks
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PayBack
                        select FI_PayBackFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PayBack
                        select FI_PayBackFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PayBack>();
                var i = (from p in ctx.DataContext.FI_PayBack.Where(exp)
                         select FI_PayBackFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PayBack>();
                var i = from p in ctx.DataContext.FI_PayBack.Where(exp)
                         select FI_PayBackFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
