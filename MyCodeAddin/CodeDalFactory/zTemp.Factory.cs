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
	public class zTempFactory:Common.Business.zTemp
    {
        public static Common.Business.zTemp Fetch(zTemp data)
        {
            Common.Business.zTemp item = (Common.Business.zTemp)Activator.CreateInstance(typeof(Common.Business.zTemp));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.sno = data.sno;
				                item.sname = data.sname;
				                item.classid = data.classid;
				                item.classname = data.classname;
				                item.depid = data.depid;
				                item.depname = data.depname;
				                item.spcid = data.spcid;
				                item.spcname = data.spcname;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<zTemp>();
                var i = (from p in ctx.DataContext.zTemp.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.sno = i.sno;
										this.sname = i.sname;
										this.classid = i.classid;
										this.classname = i.classname;
										this.depid = i.depid;
										this.depname = i.depname;
										this.spcid = i.spcid;
										this.spcname = i.spcname;
					}
            }
        }
	}

	public class zTempsFactory : Common.Business.zTemps
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.zTemp
                        select zTempFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.zTemp
                        select zTempFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<zTemp>();
                var i = (from p in ctx.DataContext.zTemp.Where(exp)
                         select zTempFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<zTemp>();
                var i = from p in ctx.DataContext.zTemp.Where(exp)
                         select zTempFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
