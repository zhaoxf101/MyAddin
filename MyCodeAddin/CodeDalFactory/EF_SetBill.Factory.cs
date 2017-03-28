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
	public class EF_SetBillFactory:Common.Business.EF_SetBill
    {
        public static Common.Business.EF_SetBill Fetch(EF_SetBill data)
        {
            Common.Business.EF_SetBill item = (Common.Business.EF_SetBill)Activator.CreateInstance(typeof(Common.Business.EF_SetBill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.SetClass = data.SetClass;
				                item.SetUnit = data.SetUnit;
				                item.SetCode = data.SetCode;
				                item.LineId = data.LineId;
				                item.SubVal = data.SubVal;
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
				var exp = lambda.Resolve<EF_SetBill>();
                var i = (from p in ctx.DataContext.EF_SetBill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.SetClass = i.SetClass;
										this.SetUnit = i.SetUnit;
										this.SetCode = i.SetCode;
										this.LineId = i.LineId;
										this.SubVal = i.SubVal;
										this.IsLeaf = i.IsLeaf;
										this.SeqNR = i.SeqNR;
					}
            }
        }
	}

	public class EF_SetBillsFactory : Common.Business.EF_SetBills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_SetBill
                        select EF_SetBillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_SetBill
                        select EF_SetBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_SetBill>();
                var i = (from p in ctx.DataContext.EF_SetBill.Where(exp)
                         select EF_SetBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_SetBill>();
                var i = from p in ctx.DataContext.EF_SetBill.Where(exp)
                         select EF_SetBillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
