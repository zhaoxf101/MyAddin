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
	public class CO_WorkTypeFactory:Common.Business.CO_WorkType
    {
        public static Common.Business.CO_WorkType Fetch(CO_WorkType data)
        {
            Common.Business.CO_WorkType item = (Common.Business.CO_WorkType)Activator.CreateInstance(typeof(Common.Business.CO_WorkType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.WorkType = data.WorkType;
				                item.UnitCode = data.UnitCode;
				                item.WorkTypeTYP = data.WorkTypeTYP;
				                item.CostCtrType = data.CostCtrType;
				                item.CostElem = data.CostElem;
				                item.SPRKZ = data.SPRKZ;
				                item.KTEXT = data.KTEXT;
				                item.LTEXT = data.LTEXT;
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
				var exp = lambda.Resolve<CO_WorkType>();
                var i = (from p in ctx.DataContext.CO_WorkType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.WorkType = i.WorkType;
										this.UnitCode = i.UnitCode;
										this.WorkTypeTYP = i.WorkTypeTYP;
										this.CostCtrType = i.CostCtrType;
										this.CostElem = i.CostElem;
										this.SPRKZ = i.SPRKZ;
										this.KTEXT = i.KTEXT;
										this.LTEXT = i.LTEXT;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class CO_WorkTypesFactory : Common.Business.CO_WorkTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CO_WorkType
                        select CO_WorkTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CO_WorkType
                        select CO_WorkTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CO_WorkType>();
                var i = (from p in ctx.DataContext.CO_WorkType.Where(exp)
                         select CO_WorkTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CO_WorkType>();
                var i = from p in ctx.DataContext.CO_WorkType.Where(exp)
                         select CO_WorkTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
