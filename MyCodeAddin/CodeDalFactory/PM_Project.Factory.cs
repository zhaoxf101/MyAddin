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
	public class PM_ProjectFactory:Common.Business.PM_Project
    {
        public static Common.Business.PM_Project Fetch(PM_Project data)
        {
            Common.Business.PM_Project item = (Common.Business.PM_Project)Activator.CreateInstance(typeof(Common.Business.PM_Project));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ProjCode = data.ProjCode;
				                item.ProjName = data.ProjName;
				                item.DeptCode = data.DeptCode;
				                item.CostCtr = data.CostCtr;
				                item.CtrlDeptCode = data.CtrlDeptCode;
				                item.ProjTypeCode = data.ProjTypeCode;
				                item.ProjFund = data.ProjFund;
				                item.ContrastCode1 = data.ContrastCode1;
				                item.ContrastCode2 = data.ContrastCode2;
				                item.ConBudProjCode = data.ConBudProjCode;
				                item.StartTime = data.StartTime;
				                item.EndTime = data.EndTime;
				                item.CloseDate = data.CloseDate;
				                item.LPersonId = data.LPersonId;
				                item.LPositionCode = data.LPositionCode;
				                item.DPositionCode = data.DPositionCode;
				                item.CLPositionCode = data.CLPositionCode;
				                item.SCLPositionCode = data.SCLPositionCode;
				                item.DLPersonId = data.DLPersonId;
				                item.CLPersonId = data.CLPersonId;
				                item.SCLPersonId = data.SCLPersonId;
				                item.StatusCode = data.StatusCode;
				                item.Memo = data.Memo;
				                item.ModProjCode = data.ModProjCode;
				                item.CanBud = data.CanBud;
				                item.IsAssPur = data.IsAssPur;
				                item.AssAmt = data.AssAmt;
				                item.IsUnderConstruction = data.IsUnderConstruction;
				                item.IsFinConCtrl = data.IsFinConCtrl;
				                item.IsPublic = data.IsPublic;
				                item.IsComDef = data.IsComDef;
				                item.IsPirFund = data.IsPirFund;
				                item.IsDepInc = data.IsDepInc;
				                item.IsMemCtrl = data.IsMemCtrl;
				                item.IsInCtrl = data.IsInCtrl;
				                item.IsRateCtrl = data.IsRateCtrl;
				                item.IncomeCode = data.IncomeCode;
				                item.IncDetCode = data.IncDetCode;
				                item.AllotTypeCode = data.AllotTypeCode;
				                item.IsIRIn = data.IsIRIn;
				                item.Attribute = data.Attribute;
				                item.AttrCode = data.AttrCode;
				                item.IsCarryOver = data.IsCarryOver;
				                item.IsBudCarryOver = data.IsBudCarryOver;
				                item.IsInCarryOver = data.IsInCarryOver;
				                item.IsBudAppCtrl = data.IsBudAppCtrl;
				                item.IsFoucsAppro = data.IsFoucsAppro;
				                item.IsFlowAppro = data.IsFlowAppro;
				                item.IsVBudProj = data.IsVBudProj;
				                item.BudProjCode = data.BudProjCode;
				                item.IsPBud = data.IsPBud;
				                item.IsCHK = data.IsCHK;
				                item.IsCWCHK = data.IsCWCHK;
				                item.CanDeficit = data.CanDeficit;
				                item.IsDeficit = data.IsDeficit;
				                item.MaxDeficit = data.MaxDeficit;
				                item.FDAmt = data.FDAmt;
				                item.EscorwAmt = data.EscorwAmt;
				                item.CEscorwAmt = data.CEscorwAmt;
				                item.NeedTaxAmt = data.NeedTaxAmt;
				                item.CNeedTaxAmt = data.CNeedTaxAmt;
				                item.IsInv = data.IsInv;
				                item.InvAmt = data.InvAmt;
				                item.RcvAmt = data.RcvAmt;
				                item.TaxAmt = data.TaxAmt;
				                item.VATAmt = data.VATAmt;
				                item.DisAmt = data.DisAmt;
				                item.IsFixFee = data.IsFixFee;
				                item.FixMFee = data.FixMFee;
				                item.CFixMFee = data.CFixMFee;
				                item.IsPurCont = data.IsPurCont;
				                item.ProjSource = data.ProjSource;
				                item.OEntity = data.OEntity;
				                item.YSWF = data.YSWF;
				                item.YTWF = data.YTWF;
				                item.ZXWF = data.ZXWF;
				                item.JKWF = data.JKWF;
				                item.LWWF = data.LWWF;
				                item.XDWF = data.XDWF;
				                item.ComGrpCode = data.ComGrpCode;
				                item.RDprojLevCode = data.RDprojLevCode;
				                item.RDProjSouUnitCode = data.RDProjSouUnitCode;
				                item.RDProjTypeCode = data.RDProjTypeCode;
				                item.RDProjSubTypeCode = data.RDProjSubTypeCode;
				                item.RDauthorizeSn = data.RDauthorizeSn;
				                item.RDAchievement = data.RDAchievement;
				                item.RDAuthorizeFee = data.RDAuthorizeFee;
				                item.RDAttachFee = data.RDAttachFee;
				                item.Active = data.Active;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.CCheckedUser = data.CCheckedUser;
				                item.CCheckedDate = data.CCheckedDate;
				                item.CWCheckedUser = data.CWCheckedUser;
				                item.CWCheckedDate = data.CWCheckedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<PM_Project>();
                var i = (from p in ctx.DataContext.PM_Project.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ProjCode = i.ProjCode;
										this.ProjName = i.ProjName;
										this.DeptCode = i.DeptCode;
										this.CostCtr = i.CostCtr;
										this.CtrlDeptCode = i.CtrlDeptCode;
										this.ProjTypeCode = i.ProjTypeCode;
										this.ProjFund = i.ProjFund;
										this.ContrastCode1 = i.ContrastCode1;
										this.ContrastCode2 = i.ContrastCode2;
										this.ConBudProjCode = i.ConBudProjCode;
										this.StartTime = i.StartTime;
										this.EndTime = i.EndTime;
										this.CloseDate = i.CloseDate;
										this.LPersonId = i.LPersonId;
										this.LPositionCode = i.LPositionCode;
										this.DPositionCode = i.DPositionCode;
										this.CLPositionCode = i.CLPositionCode;
										this.SCLPositionCode = i.SCLPositionCode;
										this.DLPersonId = i.DLPersonId;
										this.CLPersonId = i.CLPersonId;
										this.SCLPersonId = i.SCLPersonId;
										this.StatusCode = i.StatusCode;
										this.Memo = i.Memo;
										this.ModProjCode = i.ModProjCode;
										this.CanBud = i.CanBud;
										this.IsAssPur = i.IsAssPur;
										this.AssAmt = i.AssAmt;
										this.IsUnderConstruction = i.IsUnderConstruction;
										this.IsFinConCtrl = i.IsFinConCtrl;
										this.IsPublic = i.IsPublic;
										this.IsComDef = i.IsComDef;
										this.IsPirFund = i.IsPirFund;
										this.IsDepInc = i.IsDepInc;
										this.IsMemCtrl = i.IsMemCtrl;
										this.IsInCtrl = i.IsInCtrl;
										this.IsRateCtrl = i.IsRateCtrl;
										this.IncomeCode = i.IncomeCode;
										this.IncDetCode = i.IncDetCode;
										this.AllotTypeCode = i.AllotTypeCode;
										this.IsIRIn = i.IsIRIn;
										this.Attribute = i.Attribute;
										this.AttrCode = i.AttrCode;
										this.IsCarryOver = i.IsCarryOver;
										this.IsBudCarryOver = i.IsBudCarryOver;
										this.IsInCarryOver = i.IsInCarryOver;
										this.IsBudAppCtrl = i.IsBudAppCtrl;
										this.IsFoucsAppro = i.IsFoucsAppro;
										this.IsFlowAppro = i.IsFlowAppro;
										this.IsVBudProj = i.IsVBudProj;
										this.BudProjCode = i.BudProjCode;
										this.IsPBud = i.IsPBud;
										this.IsCHK = i.IsCHK;
										this.IsCWCHK = i.IsCWCHK;
										this.CanDeficit = i.CanDeficit;
										this.IsDeficit = i.IsDeficit;
										this.MaxDeficit = i.MaxDeficit;
										this.FDAmt = i.FDAmt;
										this.EscorwAmt = i.EscorwAmt;
										this.CEscorwAmt = i.CEscorwAmt;
										this.NeedTaxAmt = i.NeedTaxAmt;
										this.CNeedTaxAmt = i.CNeedTaxAmt;
										this.IsInv = i.IsInv;
										this.InvAmt = i.InvAmt;
										this.RcvAmt = i.RcvAmt;
										this.TaxAmt = i.TaxAmt;
										this.VATAmt = i.VATAmt;
										this.DisAmt = i.DisAmt;
										this.IsFixFee = i.IsFixFee;
										this.FixMFee = i.FixMFee;
										this.CFixMFee = i.CFixMFee;
										this.IsPurCont = i.IsPurCont;
										this.ProjSource = i.ProjSource;
										this.OEntity = i.OEntity;
										this.YSWF = i.YSWF;
										this.YTWF = i.YTWF;
										this.ZXWF = i.ZXWF;
										this.JKWF = i.JKWF;
										this.LWWF = i.LWWF;
										this.XDWF = i.XDWF;
										this.ComGrpCode = i.ComGrpCode;
										this.RDprojLevCode = i.RDprojLevCode;
										this.RDProjSouUnitCode = i.RDProjSouUnitCode;
										this.RDProjTypeCode = i.RDProjTypeCode;
										this.RDProjSubTypeCode = i.RDProjSubTypeCode;
										this.RDauthorizeSn = i.RDauthorizeSn;
										this.RDAchievement = i.RDAchievement;
										this.RDAuthorizeFee = i.RDAuthorizeFee;
										this.RDAttachFee = i.RDAttachFee;
										this.Active = i.Active;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.CCheckedUser = i.CCheckedUser;
										this.CCheckedDate = i.CCheckedDate;
										this.CWCheckedUser = i.CWCheckedUser;
										this.CWCheckedDate = i.CWCheckedDate;
					}
            }
        }
	}

	public class PM_ProjectsFactory : Common.Business.PM_Projects
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_Project
                        select PM_ProjectFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_Project
                        select PM_ProjectFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_Project>();
                var i = (from p in ctx.DataContext.PM_Project.Where(exp)
                         select PM_ProjectFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_Project>();
                var i = from p in ctx.DataContext.PM_Project.Where(exp)
                         select PM_ProjectFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
