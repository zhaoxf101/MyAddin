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
	public class Sys_RelParyGrpFactory:Common.Business.Sys_RelParyGrp
    {
        public static Common.Business.Sys_RelParyGrp Fetch(Sys_RelParyGrp data)
        {
            Common.Business.Sys_RelParyGrp item = (Common.Business.Sys_RelParyGrp)Activator.CreateInstance(typeof(Common.Business.Sys_RelParyGrp));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.RelPartyGrpCode = data.RelPartyGrpCode;
				                item.RelPartyGrpName = data.RelPartyGrpName;
				                item.OneTimeX = data.OneTimeX;
				                item.InternalX = data.InternalX;
				                item.RangeNR = data.RangeNR;
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
				var exp = lambda.Resolve<Sys_RelParyGrp>();
                var i = (from p in ctx.DataContext.Sys_RelParyGrp.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.RelPartyGrpCode = i.RelPartyGrpCode;
										this.RelPartyGrpName = i.RelPartyGrpName;
										this.OneTimeX = i.OneTimeX;
										this.InternalX = i.InternalX;
										this.RangeNR = i.RangeNR;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class Sys_RelParyGrpsFactory : Common.Business.Sys_RelParyGrps
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_RelParyGrp
                        select Sys_RelParyGrpFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_RelParyGrp
                        select Sys_RelParyGrpFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_RelParyGrp>();
                var i = (from p in ctx.DataContext.Sys_RelParyGrp.Where(exp)
                         select Sys_RelParyGrpFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_RelParyGrp>();
                var i = from p in ctx.DataContext.Sys_RelParyGrp.Where(exp)
                         select Sys_RelParyGrpFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
