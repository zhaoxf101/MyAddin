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
	public class CG_StuFeeDetialFactory:Common.Business.CG_StuFeeDetial
    {
        public static Common.Business.CG_StuFeeDetial Fetch(CG_StuFeeDetial data)
        {
            Common.Business.CG_StuFeeDetial item = (Common.Business.CG_StuFeeDetial)Activator.CreateInstance(typeof(Common.Business.CG_StuFeeDetial));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.FeeItemCode = data.FeeItemCode;
				                item.IntervalCode = data.IntervalCode;
				                item.StudentNo = data.StudentNo;
				                item.Amt = data.Amt;
				                item.CAmt = data.CAmt;
				                item.AdjAmt = data.AdjAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CG_StuFeeDetial>();
                var i = (from p in ctx.DataContext.CG_StuFeeDetial.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.FeeItemCode = i.FeeItemCode;
										this.IntervalCode = i.IntervalCode;
										this.StudentNo = i.StudentNo;
										this.Amt = i.Amt;
										this.CAmt = i.CAmt;
										this.AdjAmt = i.AdjAmt;
					}
            }
        }
	}

	public class CG_StuFeeDetialsFactory : Common.Business.CG_StuFeeDetials
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CG_StuFeeDetial
                        select CG_StuFeeDetialFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CG_StuFeeDetial
                        select CG_StuFeeDetialFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CG_StuFeeDetial>();
                var i = (from p in ctx.DataContext.CG_StuFeeDetial.Where(exp)
                         select CG_StuFeeDetialFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CG_StuFeeDetial>();
                var i = from p in ctx.DataContext.CG_StuFeeDetial.Where(exp)
                         select CG_StuFeeDetialFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
