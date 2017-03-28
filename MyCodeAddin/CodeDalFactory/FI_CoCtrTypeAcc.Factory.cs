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
	public class FI_CoCtrTypeAccFactory:Common.Business.FI_CoCtrTypeAcc
    {
        public static Common.Business.FI_CoCtrTypeAcc Fetch(FI_CoCtrTypeAcc data)
        {
            Common.Business.FI_CoCtrTypeAcc item = (Common.Business.FI_CoCtrTypeAcc)Activator.CreateInstance(typeof(Common.Business.FI_CoCtrTypeAcc));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.CostCtrType = data.CostCtrType;
				                item.AccCode = data.AccCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_CoCtrTypeAcc>();
                var i = (from p in ctx.DataContext.FI_CoCtrTypeAcc.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.CostCtrType = i.CostCtrType;
										this.AccCode = i.AccCode;
					}
            }
        }
	}

	public class FI_CoCtrTypeAccsFactory : Common.Business.FI_CoCtrTypeAccs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_CoCtrTypeAcc
                        select FI_CoCtrTypeAccFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_CoCtrTypeAcc
                        select FI_CoCtrTypeAccFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_CoCtrTypeAcc>();
                var i = (from p in ctx.DataContext.FI_CoCtrTypeAcc.Where(exp)
                         select FI_CoCtrTypeAccFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_CoCtrTypeAcc>();
                var i = from p in ctx.DataContext.FI_CoCtrTypeAcc.Where(exp)
                         select FI_CoCtrTypeAccFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
