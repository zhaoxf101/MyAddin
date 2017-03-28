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
	public class EQ_LabLevFactory:Common.Business.EQ_LabLev
    {
        public static Common.Business.EQ_LabLev Fetch(EQ_LabLev data)
        {
            Common.Business.EQ_LabLev item = (Common.Business.EQ_LabLev)Activator.CreateInstance(typeof(Common.Business.EQ_LabLev));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.LabLevCode = data.LabLevCode;
				                item.LabLevName = data.LabLevName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EQ_LabLev>();
                var i = (from p in ctx.DataContext.EQ_LabLev.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.LabLevCode = i.LabLevCode;
										this.LabLevName = i.LabLevName;
					}
            }
        }
	}

	public class EQ_LabLevsFactory : Common.Business.EQ_LabLevs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EQ_LabLev
                        select EQ_LabLevFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EQ_LabLev
                        select EQ_LabLevFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EQ_LabLev>();
                var i = (from p in ctx.DataContext.EQ_LabLev.Where(exp)
                         select EQ_LabLevFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EQ_LabLev>();
                var i = from p in ctx.DataContext.EQ_LabLev.Where(exp)
                         select EQ_LabLevFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
