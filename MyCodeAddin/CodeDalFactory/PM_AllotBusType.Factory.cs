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
	public class PM_AllotBusTypeFactory:Common.Business.PM_AllotBusType
    {
        public static Common.Business.PM_AllotBusType Fetch(PM_AllotBusType data)
        {
            Common.Business.PM_AllotBusType item = (Common.Business.PM_AllotBusType)Activator.CreateInstance(typeof(Common.Business.PM_AllotBusType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AllotBusTypeCode = data.AllotBusTypeCode;
				                item.AllotBusTypeName = data.AllotBusTypeName;
				                item.BusType = data.BusType;
				                item.AllotGrp = data.AllotGrp;
				                item.AccCode = data.AccCode;
				                item.IncDetTypeCode = data.IncDetTypeCode;
				                item.IsTuiAllo = data.IsTuiAllo;
				                item.IsInvChk = data.IsInvChk;
				                item.IsTaxChk = data.IsTaxChk;
				                item.AccType = data.AccType;
				                item.GLMark = data.GLMark;
				                item.IncAccCode = data.IncAccCode;
				                item.AllotAccCls = data.AllotAccCls;
				                item.IsReturn = data.IsReturn;
				                item.IsPending = data.IsPending;
				                item.IsDis = data.IsDis;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_AllotBusType>();
                var i = (from p in ctx.DataContext.PM_AllotBusType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AllotBusTypeCode = i.AllotBusTypeCode;
										this.AllotBusTypeName = i.AllotBusTypeName;
										this.BusType = i.BusType;
										this.AllotGrp = i.AllotGrp;
										this.AccCode = i.AccCode;
										this.IncDetTypeCode = i.IncDetTypeCode;
										this.IsTuiAllo = i.IsTuiAllo;
										this.IsInvChk = i.IsInvChk;
										this.IsTaxChk = i.IsTaxChk;
										this.AccType = i.AccType;
										this.GLMark = i.GLMark;
										this.IncAccCode = i.IncAccCode;
										this.AllotAccCls = i.AllotAccCls;
										this.IsReturn = i.IsReturn;
										this.IsPending = i.IsPending;
										this.IsDis = i.IsDis;
					}
            }
        }
	}

	public class PM_AllotBusTypesFactory : Common.Business.PM_AllotBusTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_AllotBusType
                        select PM_AllotBusTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_AllotBusType
                        select PM_AllotBusTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_AllotBusType>();
                var i = (from p in ctx.DataContext.PM_AllotBusType.Where(exp)
                         select PM_AllotBusTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_AllotBusType>();
                var i = from p in ctx.DataContext.PM_AllotBusType.Where(exp)
                         select PM_AllotBusTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
