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
	public class FI_BudUnitFactory:Common.Business.FI_BudUnit
    {
        public static Common.Business.FI_BudUnit Fetch(FI_BudUnit data)
        {
            Common.Business.FI_BudUnit item = (Common.Business.FI_BudUnit)Activator.CreateInstance(typeof(Common.Business.FI_BudUnit));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.BudUnitCode = data.BudUnitCode;
				                item.BudUnitName = data.BudUnitName;
				                item.FirYear = data.FirYear;
				                item.EndYear = data.EndYear;
				                item.BudYear = data.BudYear;
				                item.AccYear = data.AccYear;
				                item.IsOpen = data.IsOpen;
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
				var exp = lambda.Resolve<FI_BudUnit>();
                var i = (from p in ctx.DataContext.FI_BudUnit.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.BudUnitCode = i.BudUnitCode;
										this.BudUnitName = i.BudUnitName;
										this.FirYear = i.FirYear;
										this.EndYear = i.EndYear;
										this.BudYear = i.BudYear;
										this.AccYear = i.AccYear;
										this.IsOpen = i.IsOpen;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_BudUnitsFactory : Common.Business.FI_BudUnits
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_BudUnit
                        select FI_BudUnitFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_BudUnit
                        select FI_BudUnitFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_BudUnit>();
                var i = (from p in ctx.DataContext.FI_BudUnit.Where(exp)
                         select FI_BudUnitFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_BudUnit>();
                var i = from p in ctx.DataContext.FI_BudUnit.Where(exp)
                         select FI_BudUnitFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
