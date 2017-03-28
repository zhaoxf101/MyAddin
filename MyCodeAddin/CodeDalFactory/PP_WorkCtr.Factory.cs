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
	public class PP_WorkCtrFactory:Common.Business.PP_WorkCtr
    {
        public static Common.Business.PP_WorkCtr Fetch(PP_WorkCtr data)
        {
            Common.Business.PP_WorkCtr item = (Common.Business.PP_WorkCtr)Activator.CreateInstance(typeof(Common.Business.PP_WorkCtr));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Plant = data.Plant;
				                item.WorkCtr = data.WorkCtr;
				                item.LText = data.LText;
				                item.WorkCtrTYP = data.WorkCtrTYP;
				                item.IsDel = data.IsDel;
				                item.Addr = data.Addr;
				                item.Leader = data.Leader;
				                item.CostCtr = data.CostCtr;
				                item.LOANZ = data.LOANZ;
				                item.SimCode = data.SimCode;
				                item.AccCode = data.AccCode;
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
				var exp = lambda.Resolve<PP_WorkCtr>();
                var i = (from p in ctx.DataContext.PP_WorkCtr.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Plant = i.Plant;
										this.WorkCtr = i.WorkCtr;
										this.LText = i.LText;
										this.WorkCtrTYP = i.WorkCtrTYP;
										this.IsDel = i.IsDel;
										this.Addr = i.Addr;
										this.Leader = i.Leader;
										this.CostCtr = i.CostCtr;
										this.LOANZ = i.LOANZ;
										this.SimCode = i.SimCode;
										this.AccCode = i.AccCode;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PP_WorkCtrsFactory : Common.Business.PP_WorkCtrs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PP_WorkCtr
                        select PP_WorkCtrFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PP_WorkCtr
                        select PP_WorkCtrFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PP_WorkCtr>();
                var i = (from p in ctx.DataContext.PP_WorkCtr.Where(exp)
                         select PP_WorkCtrFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PP_WorkCtr>();
                var i = from p in ctx.DataContext.PP_WorkCtr.Where(exp)
                         select PP_WorkCtrFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
