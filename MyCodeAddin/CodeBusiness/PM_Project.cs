using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_Project))]
#if Dev
    [RunLocal]
#endif

	public class PM_Project:ReadOnlyBase<PM_Project>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string ProjName
        {
            get ;
            set ;
        }

		
        public string DeptCode
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string CtrlDeptCode
        {
            get ;
            set ;
        }

		
        public string ProjTypeCode
        {
            get ;
            set ;
        }

		
        public string ProjFund
        {
            get ;
            set ;
        }

		
        public string ContrastCode1
        {
            get ;
            set ;
        }

		
        public string ContrastCode2
        {
            get ;
            set ;
        }

		
        public string ConBudProjCode
        {
            get ;
            set ;
        }

		
        public DateTime? StartTime
        {
            get ;
            set ;
        }

		
        public DateTime? EndTime
        {
            get ;
            set ;
        }

		
        public DateTime? CloseDate
        {
            get ;
            set ;
        }

		
        public string LPersonId
        {
            get ;
            set ;
        }

		
        public string LPositionCode
        {
            get ;
            set ;
        }

		
        public string DPositionCode
        {
            get ;
            set ;
        }

		
        public string CLPositionCode
        {
            get ;
            set ;
        }

		
        public string SCLPositionCode
        {
            get ;
            set ;
        }

		
        public string DLPersonId
        {
            get ;
            set ;
        }

		
        public string CLPersonId
        {
            get ;
            set ;
        }

		
        public string SCLPersonId
        {
            get ;
            set ;
        }

		
        public string StatusCode
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string ModProjCode
        {
            get ;
            set ;
        }

		
        public bool CanBud
        {
            get ;
            set ;
        }

		
        public bool IsAssPur
        {
            get ;
            set ;
        }

		
        public decimal AssAmt
        {
            get ;
            set ;
        }

		
        public bool IsUnderConstruction
        {
            get ;
            set ;
        }

		
        public bool IsFinConCtrl
        {
            get ;
            set ;
        }

		
        public bool IsPublic
        {
            get ;
            set ;
        }

		
        public bool IsComDef
        {
            get ;
            set ;
        }

		
        public bool IsPirFund
        {
            get ;
            set ;
        }

		
        public bool IsDepInc
        {
            get ;
            set ;
        }

		
        public bool IsMemCtrl
        {
            get ;
            set ;
        }

		
        public bool IsInCtrl
        {
            get ;
            set ;
        }

		
        public bool IsRateCtrl
        {
            get ;
            set ;
        }

		
        public string IncomeCode
        {
            get ;
            set ;
        }

		
        public string IncDetCode
        {
            get ;
            set ;
        }

		
        public string AllotTypeCode
        {
            get ;
            set ;
        }

		
        public bool IsIRIn
        {
            get ;
            set ;
        }

		
        public bool Attribute
        {
            get ;
            set ;
        }

		
        public string AttrCode
        {
            get ;
            set ;
        }

		
        public bool IsCarryOver
        {
            get ;
            set ;
        }

		
        public bool IsBudCarryOver
        {
            get ;
            set ;
        }

		
        public bool IsInCarryOver
        {
            get ;
            set ;
        }

		
        public bool IsBudAppCtrl
        {
            get ;
            set ;
        }

		
        public bool IsFoucsAppro
        {
            get ;
            set ;
        }

		
        public bool IsFlowAppro
        {
            get ;
            set ;
        }

		
        public bool IsVBudProj
        {
            get ;
            set ;
        }

		
        public string BudProjCode
        {
            get ;
            set ;
        }

		
        public bool IsPBud
        {
            get ;
            set ;
        }

		
        public bool IsCHK
        {
            get ;
            set ;
        }

		
        public bool IsCWCHK
        {
            get ;
            set ;
        }

		
        public bool CanDeficit
        {
            get ;
            set ;
        }

		
        public bool IsDeficit
        {
            get ;
            set ;
        }

		
        public decimal MaxDeficit
        {
            get ;
            set ;
        }

		
        public decimal FDAmt
        {
            get ;
            set ;
        }

		
        public decimal EscorwAmt
        {
            get ;
            set ;
        }

		
        public decimal CEscorwAmt
        {
            get ;
            set ;
        }

		
        public decimal NeedTaxAmt
        {
            get ;
            set ;
        }

		
        public decimal CNeedTaxAmt
        {
            get ;
            set ;
        }

		
        public bool IsInv
        {
            get ;
            set ;
        }

		
        public decimal InvAmt
        {
            get ;
            set ;
        }

		
        public decimal RcvAmt
        {
            get ;
            set ;
        }

		
        public decimal TaxAmt
        {
            get ;
            set ;
        }

		
        public decimal VATAmt
        {
            get ;
            set ;
        }

		
        public decimal DisAmt
        {
            get ;
            set ;
        }

		
        public bool IsFixFee
        {
            get ;
            set ;
        }

		
        public decimal FixMFee
        {
            get ;
            set ;
        }

		
        public decimal CFixMFee
        {
            get ;
            set ;
        }

		
        public bool IsPurCont
        {
            get ;
            set ;
        }

		
        public string ProjSource
        {
            get ;
            set ;
        }

		
        public string OEntity
        {
            get ;
            set ;
        }

		
        public string YSWF
        {
            get ;
            set ;
        }

		
        public string YTWF
        {
            get ;
            set ;
        }

		
        public string ZXWF
        {
            get ;
            set ;
        }

		
        public string JKWF
        {
            get ;
            set ;
        }

		
        public string LWWF
        {
            get ;
            set ;
        }

		
        public string XDWF
        {
            get ;
            set ;
        }

		
        public string ComGrpCode
        {
            get ;
            set ;
        }

		
        public string RDprojLevCode
        {
            get ;
            set ;
        }

		
        public string RDProjSouUnitCode
        {
            get ;
            set ;
        }

		
        public string RDProjTypeCode
        {
            get ;
            set ;
        }

		
        public string RDProjSubTypeCode
        {
            get ;
            set ;
        }

		
        public string RDauthorizeSn
        {
            get ;
            set ;
        }

		
        public string RDAchievement
        {
            get ;
            set ;
        }

		
        public decimal RDAuthorizeFee
        {
            get ;
            set ;
        }

		
        public decimal RDAttachFee
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
        public string CCheckedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CCheckedDate
        {
            get ;
            set ;
        }

		
        public string CWCheckedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CWCheckedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_Project Create()
        {
            return EF.DataPortal.Create<PM_Project>();
        }

		public static PM_Project Fetch(System.Linq.Expressions.Expression<Func<PM_Project, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_Project>(exp,values);
            return EF.DataPortal.Fetch<PM_Project>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_Projects))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_Projects:ReadOnlyListBase<PM_Projects,PM_Project>
    {
        #region Factory Methods

        public static PM_Projects Fetch()
        {
            return EF.DataPortal.Fetch<PM_Projects>();
        }

		public static PM_Projects Fetch(System.Linq.Expressions.Expression<Func<PM_Project, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_Project>(exp,values);
            return EF.DataPortal.Fetch<PM_Projects>(lambda);
		}

		public static PM_Projects Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_Projects>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_Projects Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_Project, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_Projects>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_Project>(exp,values)});
        }

        #endregion

		[Serializable]
        public class Paging
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get 
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        [Serializable]
        public class PagigExpress
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            public LambdaExpression Lambda { get; set; }
        }

    }
}
