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
	public class FI_ProjCoCtrTypeAccFactory:Common.Business.FI_ProjCoCtrTypeAcc
    {
        public static Common.Business.FI_ProjCoCtrTypeAcc Fetch(FI_ProjCoCtrTypeAcc data)
        {
            Common.Business.FI_ProjCoCtrTypeAcc item = (Common.Business.FI_ProjCoCtrTypeAcc)Activator.CreateInstance(typeof(Common.Business.FI_ProjCoCtrTypeAcc));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.CostCtrType = data.CostCtrType;
				                item.AccCode = data.AccCode;
				                item.BAccCode = data.BAccCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ProjCoCtrTypeAcc>();
                var i = (from p in ctx.DataContext.FI_ProjCoCtrTypeAcc.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.CostCtrType = i.CostCtrType;
										this.AccCode = i.AccCode;
										this.BAccCode = i.BAccCode;
					}
            }
        }
	}

	public class FI_ProjCoCtrTypeAccsFactory : Common.Business.FI_ProjCoCtrTypeAccs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ProjCoCtrTypeAcc
                        select FI_ProjCoCtrTypeAccFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ProjCoCtrTypeAcc
                        select FI_ProjCoCtrTypeAccFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ProjCoCtrTypeAcc>();
                var i = (from p in ctx.DataContext.FI_ProjCoCtrTypeAcc.Where(exp)
                         select FI_ProjCoCtrTypeAccFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ProjCoCtrTypeAcc>();
                var i = from p in ctx.DataContext.FI_ProjCoCtrTypeAcc.Where(exp)
                         select FI_ProjCoCtrTypeAccFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
