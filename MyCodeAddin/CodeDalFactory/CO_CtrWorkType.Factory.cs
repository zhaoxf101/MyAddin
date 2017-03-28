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
	public class CO_CtrWorkTypeFactory:Common.Business.CO_CtrWorkType
    {
        public static Common.Business.CO_CtrWorkType Fetch(CO_CtrWorkType data)
        {
            Common.Business.CO_CtrWorkType item = (Common.Business.CO_CtrWorkType)Activator.CreateInstance(typeof(Common.Business.CO_CtrWorkType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.WorkType = data.WorkType;
				                item.AccYear = data.AccYear;
				                item.PERID = data.PERID;
				                item.CostCtr = data.CostCtr;
				                item.UnitCode = data.UnitCode;
				                item.LST = data.LST;
				                item.KAP = data.KAP;
				                item.TKF = data.TKF;
				                item.TKV = data.TKV;
				                item.AEQ = data.AEQ;
				                item.CostElem = data.CostElem;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CO_CtrWorkType>();
                var i = (from p in ctx.DataContext.CO_CtrWorkType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.WorkType = i.WorkType;
										this.AccYear = i.AccYear;
										this.PERID = i.PERID;
										this.CostCtr = i.CostCtr;
										this.UnitCode = i.UnitCode;
										this.LST = i.LST;
										this.KAP = i.KAP;
										this.TKF = i.TKF;
										this.TKV = i.TKV;
										this.AEQ = i.AEQ;
										this.CostElem = i.CostElem;
					}
            }
        }
	}

	public class CO_CtrWorkTypesFactory : Common.Business.CO_CtrWorkTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CO_CtrWorkType
                        select CO_CtrWorkTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CO_CtrWorkType
                        select CO_CtrWorkTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CO_CtrWorkType>();
                var i = (from p in ctx.DataContext.CO_CtrWorkType.Where(exp)
                         select CO_CtrWorkTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CO_CtrWorkType>();
                var i = from p in ctx.DataContext.CO_CtrWorkType.Where(exp)
                         select CO_CtrWorkTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
