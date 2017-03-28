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
	public class CG_CheckFactory:Common.Business.CG_Check
    {
        public static Common.Business.CG_Check Fetch(CG_Check data)
        {
            Common.Business.CG_Check item = (Common.Business.CG_Check)Activator.CreateInstance(typeof(Common.Business.CG_Check));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.DebitDate = data.DebitDate;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.TransactionFee = data.TransactionFee;
				                item.TransactionCount = data.TransactionCount;
				                item.IsCheck = data.IsCheck;
				                item.BillNo = data.BillNo;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CG_Check>();
                var i = (from p in ctx.DataContext.CG_Check.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.DebitDate = i.DebitDate;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.TransactionFee = i.TransactionFee;
										this.TransactionCount = i.TransactionCount;
										this.IsCheck = i.IsCheck;
										this.BillNo = i.BillNo;
					}
            }
        }
	}

	public class CG_ChecksFactory : Common.Business.CG_Checks
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CG_Check
                        select CG_CheckFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CG_Check
                        select CG_CheckFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CG_Check>();
                var i = (from p in ctx.DataContext.CG_Check.Where(exp)
                         select CG_CheckFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CG_Check>();
                var i = from p in ctx.DataContext.CG_Check.Where(exp)
                         select CG_CheckFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
