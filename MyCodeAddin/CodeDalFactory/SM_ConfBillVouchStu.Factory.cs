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
	public class SM_ConfBillVouchStuFactory:Common.Business.SM_ConfBillVouchStu
    {
        public static Common.Business.SM_ConfBillVouchStu Fetch(SM_ConfBillVouchStu data)
        {
            Common.Business.SM_ConfBillVouchStu item = (Common.Business.SM_ConfBillVouchStu)Activator.CreateInstance(typeof(Common.Business.SM_ConfBillVouchStu));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ConfCode = data.ConfCode;
				                item.VouchNo = data.VouchNo;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.LineNR = data.LineNR;
				                item.StudentNo = data.StudentNo;
				                item.TransactionDate = data.TransactionDate;
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
				var exp = lambda.Resolve<SM_ConfBillVouchStu>();
                var i = (from p in ctx.DataContext.SM_ConfBillVouchStu.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ConfCode = i.ConfCode;
										this.VouchNo = i.VouchNo;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.LineNR = i.LineNR;
										this.StudentNo = i.StudentNo;
										this.TransactionDate = i.TransactionDate;
										this.Amt = i.Amt;
					}
            }
        }
	}

	public class SM_ConfBillVouchStusFactory : Common.Business.SM_ConfBillVouchStus
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_ConfBillVouchStu
                        select SM_ConfBillVouchStuFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_ConfBillVouchStu
                        select SM_ConfBillVouchStuFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_ConfBillVouchStu>();
                var i = (from p in ctx.DataContext.SM_ConfBillVouchStu.Where(exp)
                         select SM_ConfBillVouchStuFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_ConfBillVouchStu>();
                var i = from p in ctx.DataContext.SM_ConfBillVouchStu.Where(exp)
                         select SM_ConfBillVouchStuFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
