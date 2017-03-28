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
	public class TU_StuTuitionFactory:Common.Business.TU_StuTuition
    {
        public static Common.Business.TU_StuTuition Fetch(TU_StuTuition data)
        {
            Common.Business.TU_StuTuition item = (Common.Business.TU_StuTuition)Activator.CreateInstance(typeof(Common.Business.TU_StuTuition));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.StudentNo = data.StudentNo;
				                item.VoucherNo = data.VoucherNo;
				                item.ReceiptNo = data.ReceiptNo;
				                item.RecTypeCode = data.RecTypeCode;
				                item.Operator = data.Operator;
				                item.ChargeDate = data.ChargeDate;
				                item.Maker = data.Maker;
				                item.MakeDate = data.MakeDate;
				                item.IsPrint = data.IsPrint;
				                item.TotalAmt = data.TotalAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<TU_StuTuition>();
                var i = (from p in ctx.DataContext.TU_StuTuition.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.StudentNo = i.StudentNo;
										this.VoucherNo = i.VoucherNo;
										this.ReceiptNo = i.ReceiptNo;
										this.RecTypeCode = i.RecTypeCode;
										this.Operator = i.Operator;
										this.ChargeDate = i.ChargeDate;
										this.Maker = i.Maker;
										this.MakeDate = i.MakeDate;
										this.IsPrint = i.IsPrint;
										this.TotalAmt = i.TotalAmt;
					}
            }
        }
	}

	public class TU_StuTuitionsFactory : Common.Business.TU_StuTuitions
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.TU_StuTuition
                        select TU_StuTuitionFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.TU_StuTuition
                        select TU_StuTuitionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<TU_StuTuition>();
                var i = (from p in ctx.DataContext.TU_StuTuition.Where(exp)
                         select TU_StuTuitionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<TU_StuTuition>();
                var i = from p in ctx.DataContext.TU_StuTuition.Where(exp)
                         select TU_StuTuitionFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
