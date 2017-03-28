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
	public class TU_StuTuitionSubFactory:Common.Business.TU_StuTuitionSub
    {
        public static Common.Business.TU_StuTuitionSub Fetch(TU_StuTuitionSub data)
        {
            Common.Business.TU_StuTuitionSub item = (Common.Business.TU_StuTuitionSub)Activator.CreateInstance(typeof(Common.Business.TU_StuTuitionSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.VoucherNo = data.VoucherNo;
				                item.TuitionFee = data.TuitionFee;
				                item.RentFee = data.RentFee;
				                item.BookFee = data.BookFee;
				                item.MedicareFee = data.MedicareFee;
				                item.HealthCheckFee = data.HealthCheckFee;
				                item.PracticeClothFee = data.PracticeClothFee;
				                item.TrainClothFee = data.TrainClothFee;
				                item.DailyUseFee = data.DailyUseFee;
				                item.EngHeadphonesFee = data.EngHeadphonesFee;
				                item.Fee0 = data.Fee0;
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
				var exp = lambda.Resolve<TU_StuTuitionSub>();
                var i = (from p in ctx.DataContext.TU_StuTuitionSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.VoucherNo = i.VoucherNo;
										this.TuitionFee = i.TuitionFee;
										this.RentFee = i.RentFee;
										this.BookFee = i.BookFee;
										this.MedicareFee = i.MedicareFee;
										this.HealthCheckFee = i.HealthCheckFee;
										this.PracticeClothFee = i.PracticeClothFee;
										this.TrainClothFee = i.TrainClothFee;
										this.DailyUseFee = i.DailyUseFee;
										this.EngHeadphonesFee = i.EngHeadphonesFee;
										this.Fee0 = i.Fee0;
										this.TotalAmt = i.TotalAmt;
					}
            }
        }
	}

	public class TU_StuTuitionSubsFactory : Common.Business.TU_StuTuitionSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.TU_StuTuitionSub
                        select TU_StuTuitionSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.TU_StuTuitionSub
                        select TU_StuTuitionSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<TU_StuTuitionSub>();
                var i = (from p in ctx.DataContext.TU_StuTuitionSub.Where(exp)
                         select TU_StuTuitionSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<TU_StuTuitionSub>();
                var i = from p in ctx.DataContext.TU_StuTuitionSub.Where(exp)
                         select TU_StuTuitionSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
