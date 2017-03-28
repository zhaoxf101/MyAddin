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
	public class FI_PayBackSubFactory:Common.Business.FI_PayBackSub
    {
        public static Common.Business.FI_PayBackSub Fetch(FI_PayBackSub data)
        {
            Common.Business.FI_PayBackSub item = (Common.Business.FI_PayBackSub)Activator.CreateInstance(typeof(Common.Business.FI_PayBackSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.PayBackNo = data.PayBackNo;
				                item.ItemId = data.ItemId;
				                item.AccType = data.AccType;
				                item.PayBackType = data.PayBackType;
				                item.GLMarK = data.GLMarK;
				                item.PartyCode = data.PartyCode;
				                item.VouchNo = data.VouchNo;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.LineNR = data.LineNR;
				                item.ItemText = data.ItemText;
				                item.PersonId = data.PersonId;
				                item.Amt = data.Amt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_PayBackSub>();
                var i = (from p in ctx.DataContext.FI_PayBackSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.PayBackNo = i.PayBackNo;
										this.ItemId = i.ItemId;
										this.AccType = i.AccType;
										this.PayBackType = i.PayBackType;
										this.GLMarK = i.GLMarK;
										this.PartyCode = i.PartyCode;
										this.VouchNo = i.VouchNo;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.LineNR = i.LineNR;
										this.ItemText = i.ItemText;
										this.PersonId = i.PersonId;
										this.Amt = i.Amt;
					}
            }
        }
	}

	public class FI_PayBackSubsFactory : Common.Business.FI_PayBackSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PayBackSub
                        select FI_PayBackSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PayBackSub
                        select FI_PayBackSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PayBackSub>();
                var i = (from p in ctx.DataContext.FI_PayBackSub.Where(exp)
                         select FI_PayBackSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PayBackSub>();
                var i = from p in ctx.DataContext.FI_PayBackSub.Where(exp)
                         select FI_PayBackSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
