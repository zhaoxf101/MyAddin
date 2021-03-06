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
	public class FI_AccGrpFactory:Common.Business.FI_AccGrp
    {
        public static Common.Business.FI_AccGrp Fetch(FI_AccGrp data)
        {
            Common.Business.FI_AccGrp item = (Common.Business.FI_AccGrp)Activator.CreateInstance(typeof(Common.Business.FI_AccGrp));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.AccChart = data.AccChart;
				                item.AccGrp = data.AccGrp;
				                item.StartAcc = data.StartAcc;
				                item.EndAcc = data.EndAcc;
				                item.Status = data.Status;
				                item.DText = data.DText;
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
				var exp = lambda.Resolve<FI_AccGrp>();
                var i = (from p in ctx.DataContext.FI_AccGrp.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.AccChart = i.AccChart;
										this.AccGrp = i.AccGrp;
										this.StartAcc = i.StartAcc;
										this.EndAcc = i.EndAcc;
										this.Status = i.Status;
										this.DText = i.DText;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_AccGrpsFactory : Common.Business.FI_AccGrps
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_AccGrp
                        select FI_AccGrpFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_AccGrp
                        select FI_AccGrpFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_AccGrp>();
                var i = (from p in ctx.DataContext.FI_AccGrp.Where(exp)
                         select FI_AccGrpFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_AccGrp>();
                var i = from p in ctx.DataContext.FI_AccGrp.Where(exp)
                         select FI_AccGrpFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
