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
	public class PM_ProjIncDetFactory:Common.Business.PM_ProjIncDet
    {
        public static Common.Business.PM_ProjIncDet Fetch(PM_ProjIncDet data)
        {
            Common.Business.PM_ProjIncDet item = (Common.Business.PM_ProjIncDet)Activator.CreateInstance(typeof(Common.Business.PM_ProjIncDet));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ProjCode = data.ProjCode;
				                item.IncDetCode = data.IncDetCode;
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
				var exp = lambda.Resolve<PM_ProjIncDet>();
                var i = (from p in ctx.DataContext.PM_ProjIncDet.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ProjCode = i.ProjCode;
										this.IncDetCode = i.IncDetCode;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_ProjIncDetsFactory : Common.Business.PM_ProjIncDets
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ProjIncDet
                        select PM_ProjIncDetFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ProjIncDet
                        select PM_ProjIncDetFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ProjIncDet>();
                var i = (from p in ctx.DataContext.PM_ProjIncDet.Where(exp)
                         select PM_ProjIncDetFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ProjIncDet>();
                var i = from p in ctx.DataContext.PM_ProjIncDet.Where(exp)
                         select PM_ProjIncDetFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
