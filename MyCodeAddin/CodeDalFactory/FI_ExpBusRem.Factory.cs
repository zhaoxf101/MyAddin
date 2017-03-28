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
	public class FI_ExpBusRemFactory:Common.Business.FI_ExpBusRem
    {
        public static Common.Business.FI_ExpBusRem Fetch(FI_ExpBusRem data)
        {
            Common.Business.FI_ExpBusRem item = (Common.Business.FI_ExpBusRem)Activator.CreateInstance(typeof(Common.Business.FI_ExpBusRem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ObjId = data.ObjId;
				                item.ItemCode = data.ItemCode;
				                item.RowId = data.RowId;
				                item.RemType = data.RemType;
				                item.BankCode = data.BankCode;
				                item.BankDep = data.BankDep;
				                item.AccCode = data.AccCode;
				                item.BAccCode = data.BAccCode;
				                item.Amt = data.Amt;
				                item.IsGovPayPlan = data.IsGovPayPlan;
				                item.GovPlayCode = data.GovPlayCode;
				                item.Year = data.Year;
				                item.TransactionNo = data.TransactionNo;
				                item.BankId = data.BankId;
				                item.VouchNo = data.VouchNo;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.LineNR = data.LineNR;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ExpBusRem>();
                var i = (from p in ctx.DataContext.FI_ExpBusRem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ObjId = i.ObjId;
										this.ItemCode = i.ItemCode;
										this.RowId = i.RowId;
										this.RemType = i.RemType;
										this.BankCode = i.BankCode;
										this.BankDep = i.BankDep;
										this.AccCode = i.AccCode;
										this.BAccCode = i.BAccCode;
										this.Amt = i.Amt;
										this.IsGovPayPlan = i.IsGovPayPlan;
										this.GovPlayCode = i.GovPlayCode;
										this.Year = i.Year;
										this.TransactionNo = i.TransactionNo;
										this.BankId = i.BankId;
										this.VouchNo = i.VouchNo;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.LineNR = i.LineNR;
					}
            }
        }
	}

	public class FI_ExpBusRemsFactory : Common.Business.FI_ExpBusRems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpBusRem
                        select FI_ExpBusRemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpBusRem
                        select FI_ExpBusRemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpBusRem>();
                var i = (from p in ctx.DataContext.FI_ExpBusRem.Where(exp)
                         select FI_ExpBusRemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpBusRem>();
                var i = from p in ctx.DataContext.FI_ExpBusRem.Where(exp)
                         select FI_ExpBusRemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
