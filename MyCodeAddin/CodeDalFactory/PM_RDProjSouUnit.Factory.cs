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
	public class PM_RDProjSouUnitFactory:Common.Business.PM_RDProjSouUnit
    {
        public static Common.Business.PM_RDProjSouUnit Fetch(PM_RDProjSouUnit data)
        {
            Common.Business.PM_RDProjSouUnit item = (Common.Business.PM_RDProjSouUnit)Activator.CreateInstance(typeof(Common.Business.PM_RDProjSouUnit));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.RDProjSouUnitCode = data.RDProjSouUnitCode;
				                item.RDProjSouUnitName = data.RDProjSouUnitName;
				                item.PCode = data.PCode;
				                item.Active = data.Active;
				                item.Memo = data.Memo;
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
				var exp = lambda.Resolve<PM_RDProjSouUnit>();
                var i = (from p in ctx.DataContext.PM_RDProjSouUnit.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.RDProjSouUnitCode = i.RDProjSouUnitCode;
										this.RDProjSouUnitName = i.RDProjSouUnitName;
										this.PCode = i.PCode;
										this.Active = i.Active;
										this.Memo = i.Memo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_RDProjSouUnitsFactory : Common.Business.PM_RDProjSouUnits
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_RDProjSouUnit
                        select PM_RDProjSouUnitFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_RDProjSouUnit
                        select PM_RDProjSouUnitFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_RDProjSouUnit>();
                var i = (from p in ctx.DataContext.PM_RDProjSouUnit.Where(exp)
                         select PM_RDProjSouUnitFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_RDProjSouUnit>();
                var i = from p in ctx.DataContext.PM_RDProjSouUnit.Where(exp)
                         select PM_RDProjSouUnitFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
