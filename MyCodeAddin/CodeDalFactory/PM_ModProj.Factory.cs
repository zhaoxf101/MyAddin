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
	public class PM_ModProjFactory:Common.Business.PM_ModProj
    {
        public static Common.Business.PM_ModProj Fetch(PM_ModProj data)
        {
            Common.Business.PM_ModProj item = (Common.Business.PM_ModProj)Activator.CreateInstance(typeof(Common.Business.PM_ModProj));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ProjCode = data.ProjCode;
				                item.ProjName = data.ProjName;
				                item.Active = data.Active;
				                item.ProjTypeCode = data.ProjTypeCode;
				                item.ProjFund = data.ProjFund;
				                item.CtrlDeptCode = data.CtrlDeptCode;
				                item.CLPositionCode = data.CLPositionCode;
				                item.SCLPositionCode = data.SCLPositionCode;
				                item.Memo = data.Memo;
				                item.CanBud = data.CanBud;
				                item.IsPublic = data.IsPublic;
				                item.IsComDef = data.IsComDef;
				                item.IsVBudProj = data.IsVBudProj;
				                item.BudProjCode = data.BudProjCode;
				                item.IsPBud = data.IsPBud;
				                item.IsPirFund = data.IsPirFund;
				                item.IncomeCode = data.IncomeCode;
				                item.AllotTypeCode = data.AllotTypeCode;
				                item.Attribute = data.Attribute;
				                item.AttrCode = data.AttrCode;
				                item.IsBudAppCtrl = data.IsBudAppCtrl;
				                item.IsFoucsAppro = data.IsFoucsAppro;
				                item.IsFlowAppro = data.IsFlowAppro;
				                item.IsCarryOver = data.IsCarryOver;
				                item.IsInv = data.IsInv;
				                item.CanDeficit = data.CanDeficit;
				                item.IsDeficit = data.IsDeficit;
				                item.MaxDeficit = data.MaxDeficit;
				                item.ProjSource = data.ProjSource;
				                item.OEntity = data.OEntity;
				                item.RDprojLevCode = data.RDprojLevCode;
				                item.RDProjSouUnitCode = data.RDProjSouUnitCode;
				                item.RDProjTypeCode = data.RDProjTypeCode;
				                item.RDProjSubTypeCode = data.RDProjSubTypeCode;
				                item.FDAmt = data.FDAmt;
				                item.YSWF = data.YSWF;
				                item.YTWF = data.YTWF;
				                item.XDWF = data.XDWF;
				                item.JKWF = data.JKWF;
				                item.LWWF = data.LWWF;
				                item.ZXWF = data.ZXWF;
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
				var exp = lambda.Resolve<PM_ModProj>();
                var i = (from p in ctx.DataContext.PM_ModProj.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ProjCode = i.ProjCode;
										this.ProjName = i.ProjName;
										this.Active = i.Active;
										this.ProjTypeCode = i.ProjTypeCode;
										this.ProjFund = i.ProjFund;
										this.CtrlDeptCode = i.CtrlDeptCode;
										this.CLPositionCode = i.CLPositionCode;
										this.SCLPositionCode = i.SCLPositionCode;
										this.Memo = i.Memo;
										this.CanBud = i.CanBud;
										this.IsPublic = i.IsPublic;
										this.IsComDef = i.IsComDef;
										this.IsVBudProj = i.IsVBudProj;
										this.BudProjCode = i.BudProjCode;
										this.IsPBud = i.IsPBud;
										this.IsPirFund = i.IsPirFund;
										this.IncomeCode = i.IncomeCode;
										this.AllotTypeCode = i.AllotTypeCode;
										this.Attribute = i.Attribute;
										this.AttrCode = i.AttrCode;
										this.IsBudAppCtrl = i.IsBudAppCtrl;
										this.IsFoucsAppro = i.IsFoucsAppro;
										this.IsFlowAppro = i.IsFlowAppro;
										this.IsCarryOver = i.IsCarryOver;
										this.IsInv = i.IsInv;
										this.CanDeficit = i.CanDeficit;
										this.IsDeficit = i.IsDeficit;
										this.MaxDeficit = i.MaxDeficit;
										this.ProjSource = i.ProjSource;
										this.OEntity = i.OEntity;
										this.RDprojLevCode = i.RDprojLevCode;
										this.RDProjSouUnitCode = i.RDProjSouUnitCode;
										this.RDProjTypeCode = i.RDProjTypeCode;
										this.RDProjSubTypeCode = i.RDProjSubTypeCode;
										this.FDAmt = i.FDAmt;
										this.YSWF = i.YSWF;
										this.YTWF = i.YTWF;
										this.XDWF = i.XDWF;
										this.JKWF = i.JKWF;
										this.LWWF = i.LWWF;
										this.ZXWF = i.ZXWF;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_ModProjsFactory : Common.Business.PM_ModProjs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ModProj
                        select PM_ModProjFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ModProj
                        select PM_ModProjFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ModProj>();
                var i = (from p in ctx.DataContext.PM_ModProj.Where(exp)
                         select PM_ModProjFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ModProj>();
                var i = from p in ctx.DataContext.PM_ModProj.Where(exp)
                         select PM_ModProjFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
