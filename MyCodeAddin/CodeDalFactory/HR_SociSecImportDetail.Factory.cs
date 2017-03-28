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
	public class HR_SociSecImportDetailFactory:Common.Business.HR_SociSecImportDetail
    {
        public static Common.Business.HR_SociSecImportDetail Fetch(HR_SociSecImportDetail data)
        {
            Common.Business.HR_SociSecImportDetail item = (Common.Business.HR_SociSecImportDetail)Activator.CreateInstance(typeof(Common.Business.HR_SociSecImportDetail));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SociSecCode = data.SociSecCode;
				                item.PersonId = data.PersonId;
				                item.SociSecItemCode = data.SociSecItemCode;
				                item.SociSecItemName = data.SociSecItemName;
				                item.SociSecAmt = data.SociSecAmt;
				                item.ResouItemCode = data.ResouItemCode;
				                item.IsIncrease = data.IsIncrease;
				                item.Sort = data.Sort;
				                item.TaxPeriod = data.TaxPeriod;
				                item.CostCtr = data.CostCtr;
				                item.Staff = data.Staff;
				                item.UType = data.UType;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ExpItemId = data.ExpItemId;
				                item.Description = data.Description;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SociSecImportDetail>();
                var i = (from p in ctx.DataContext.HR_SociSecImportDetail.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SociSecCode = i.SociSecCode;
										this.PersonId = i.PersonId;
										this.SociSecItemCode = i.SociSecItemCode;
										this.SociSecItemName = i.SociSecItemName;
										this.SociSecAmt = i.SociSecAmt;
										this.ResouItemCode = i.ResouItemCode;
										this.IsIncrease = i.IsIncrease;
										this.Sort = i.Sort;
										this.TaxPeriod = i.TaxPeriod;
										this.CostCtr = i.CostCtr;
										this.Staff = i.Staff;
										this.UType = i.UType;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ExpItemId = i.ExpItemId;
										this.Description = i.Description;
					}
            }
        }
	}

	public class HR_SociSecImportDetailsFactory : Common.Business.HR_SociSecImportDetails
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SociSecImportDetail
                        select HR_SociSecImportDetailFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SociSecImportDetail
                        select HR_SociSecImportDetailFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SociSecImportDetail>();
                var i = (from p in ctx.DataContext.HR_SociSecImportDetail.Where(exp)
                         select HR_SociSecImportDetailFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SociSecImportDetail>();
                var i = from p in ctx.DataContext.HR_SociSecImportDetail.Where(exp)
                         select HR_SociSecImportDetailFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
