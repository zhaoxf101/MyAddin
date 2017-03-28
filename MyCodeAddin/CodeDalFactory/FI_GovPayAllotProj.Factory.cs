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
	public class FI_GovPayAllotProjFactory:Common.Business.FI_GovPayAllotProj
    {
        public static Common.Business.FI_GovPayAllotProj Fetch(FI_GovPayAllotProj data)
        {
            Common.Business.FI_GovPayAllotProj item = (Common.Business.FI_GovPayAllotProj)Activator.CreateInstance(typeof(Common.Business.FI_GovPayAllotProj));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.GovAllotNo = data.GovAllotNo;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.FundCode = data.FundCode;
				                item.ProfitCtr = data.ProfitCtr;
				                item.Description = data.Description;
				                item.Amt = data.Amt;
				                item.IsDis = data.IsDis;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_GovPayAllotProj>();
                var i = (from p in ctx.DataContext.FI_GovPayAllotProj.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.GovAllotNo = i.GovAllotNo;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.FundCode = i.FundCode;
										this.ProfitCtr = i.ProfitCtr;
										this.Description = i.Description;
										this.Amt = i.Amt;
										this.IsDis = i.IsDis;
					}
            }
        }
	}

	public class FI_GovPayAllotProjsFactory : Common.Business.FI_GovPayAllotProjs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_GovPayAllotProj
                        select FI_GovPayAllotProjFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_GovPayAllotProj
                        select FI_GovPayAllotProjFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_GovPayAllotProj>();
                var i = (from p in ctx.DataContext.FI_GovPayAllotProj.Where(exp)
                         select FI_GovPayAllotProjFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_GovPayAllotProj>();
                var i = from p in ctx.DataContext.FI_GovPayAllotProj.Where(exp)
                         select FI_GovPayAllotProjFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
