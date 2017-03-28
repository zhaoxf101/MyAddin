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
	public class PP_WorkTYPofCtrFactory:Common.Business.PP_WorkTYPofCtr
    {
        public static Common.Business.PP_WorkTYPofCtr Fetch(PP_WorkTYPofCtr data)
        {
            Common.Business.PP_WorkTYPofCtr item = (Common.Business.PP_WorkTYPofCtr)Activator.CreateInstance(typeof(Common.Business.PP_WorkTYPofCtr));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.WorkCtr = data.WorkCtr;
				                item.ACTXK = data.ACTXK;
				                item.ACTXY = data.ACTXY;
				                item.WorkType = data.WorkType;
				                item.UnitCode = data.UnitCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PP_WorkTYPofCtr>();
                var i = (from p in ctx.DataContext.PP_WorkTYPofCtr.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.WorkCtr = i.WorkCtr;
										this.ACTXK = i.ACTXK;
										this.ACTXY = i.ACTXY;
										this.WorkType = i.WorkType;
										this.UnitCode = i.UnitCode;
					}
            }
        }
	}

	public class PP_WorkTYPofCtrsFactory : Common.Business.PP_WorkTYPofCtrs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PP_WorkTYPofCtr
                        select PP_WorkTYPofCtrFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PP_WorkTYPofCtr
                        select PP_WorkTYPofCtrFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PP_WorkTYPofCtr>();
                var i = (from p in ctx.DataContext.PP_WorkTYPofCtr.Where(exp)
                         select PP_WorkTYPofCtrFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PP_WorkTYPofCtr>();
                var i = from p in ctx.DataContext.PP_WorkTYPofCtr.Where(exp)
                         select PP_WorkTYPofCtrFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
