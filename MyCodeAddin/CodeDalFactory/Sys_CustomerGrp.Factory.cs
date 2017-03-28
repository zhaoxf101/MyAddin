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
	public class Sys_CustomerGrpFactory:Common.Business.Sys_CustomerGrp
    {
        public static Common.Business.Sys_CustomerGrp Fetch(Sys_CustomerGrp data)
        {
            Common.Business.Sys_CustomerGrp item = (Common.Business.Sys_CustomerGrp)Activator.CreateInstance(typeof(Common.Business.Sys_CustomerGrp));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.CustGrpCode = data.CustGrpCode;
				                item.CustGrpName = data.CustGrpName;
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
				var exp = lambda.Resolve<Sys_CustomerGrp>();
                var i = (from p in ctx.DataContext.Sys_CustomerGrp.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.CustGrpCode = i.CustGrpCode;
										this.CustGrpName = i.CustGrpName;
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

	public class Sys_CustomerGrpsFactory : Common.Business.Sys_CustomerGrps
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_CustomerGrp
                        select Sys_CustomerGrpFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_CustomerGrp
                        select Sys_CustomerGrpFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_CustomerGrp>();
                var i = (from p in ctx.DataContext.Sys_CustomerGrp.Where(exp)
                         select Sys_CustomerGrpFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_CustomerGrp>();
                var i = from p in ctx.DataContext.Sys_CustomerGrp.Where(exp)
                         select Sys_CustomerGrpFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
