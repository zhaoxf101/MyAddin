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
	public class EF_StdBillFactory:Common.Business.EF_StdBill
    {
        public static Common.Business.EF_StdBill Fetch(EF_StdBill data)
        {
            Common.Business.EF_StdBill item = (Common.Business.EF_StdBill)Activator.CreateInstance(typeof(Common.Business.EF_StdBill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.SetStd = data.SetStd;
				                item.SetUnit = data.SetUnit;
				                item.SetVal = data.SetVal;
				                item.ParentId = data.ParentId;
				                item.IsLeaf = data.IsLeaf;
				                item.SeqNR = data.SeqNR;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_StdBill>();
                var i = (from p in ctx.DataContext.EF_StdBill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.SetStd = i.SetStd;
										this.SetUnit = i.SetUnit;
										this.SetVal = i.SetVal;
										this.ParentId = i.ParentId;
										this.IsLeaf = i.IsLeaf;
										this.SeqNR = i.SeqNR;
					}
            }
        }
	}

	public class EF_StdBillsFactory : Common.Business.EF_StdBills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_StdBill
                        select EF_StdBillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_StdBill
                        select EF_StdBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_StdBill>();
                var i = (from p in ctx.DataContext.EF_StdBill.Where(exp)
                         select EF_StdBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_StdBill>();
                var i = from p in ctx.DataContext.EF_StdBill.Where(exp)
                         select EF_StdBillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
