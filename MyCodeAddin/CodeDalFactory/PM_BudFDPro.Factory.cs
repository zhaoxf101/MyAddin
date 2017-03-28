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
	public class PM_BudFDProFactory:Common.Business.PM_BudFDPro
    {
        public static Common.Business.PM_BudFDPro Fetch(PM_BudFDPro data)
        {
            Common.Business.PM_BudFDPro item = (Common.Business.PM_BudFDPro)Activator.CreateInstance(typeof(Common.Business.PM_BudFDPro));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AppNo = data.AppNo;
				                item.BudBusCode = data.BudBusCode;
				                item.Year = data.Year;
				                item.ProjCode = data.ProjCode;
				                item.IsProjBud = data.IsProjBud;
				                item.FDAmt = data.FDAmt;
				                item.BudAmt = data.BudAmt;
				                item.IsCheck = data.IsCheck;
				                item.IsAdd = data.IsAdd;
				                item.IsAppr = data.IsAppr;
				                item.CanEdit = data.CanEdit;
				                item.IsVBudProj = data.IsVBudProj;
				                item.BudProjCode = data.BudProjCode;
				                item.Memo = data.Memo;
				                item.YSWF = data.YSWF;
				                item.Cancelled = data.Cancelled;
				                item.Approved = data.Approved;
				                item.ObjectId = data.ObjectId;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_BudFDPro>();
                var i = (from p in ctx.DataContext.PM_BudFDPro.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AppNo = i.AppNo;
										this.BudBusCode = i.BudBusCode;
										this.Year = i.Year;
										this.ProjCode = i.ProjCode;
										this.IsProjBud = i.IsProjBud;
										this.FDAmt = i.FDAmt;
										this.BudAmt = i.BudAmt;
										this.IsCheck = i.IsCheck;
										this.IsAdd = i.IsAdd;
										this.IsAppr = i.IsAppr;
										this.CanEdit = i.CanEdit;
										this.IsVBudProj = i.IsVBudProj;
										this.BudProjCode = i.BudProjCode;
										this.Memo = i.Memo;
										this.YSWF = i.YSWF;
										this.Cancelled = i.Cancelled;
										this.Approved = i.Approved;
										this.ObjectId = i.ObjectId;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_BudFDProsFactory : Common.Business.PM_BudFDPros
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_BudFDPro
                        select PM_BudFDProFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_BudFDPro
                        select PM_BudFDProFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_BudFDPro>();
                var i = (from p in ctx.DataContext.PM_BudFDPro.Where(exp)
                         select PM_BudFDProFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_BudFDPro>();
                var i = from p in ctx.DataContext.PM_BudFDPro.Where(exp)
                         select PM_BudFDProFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
