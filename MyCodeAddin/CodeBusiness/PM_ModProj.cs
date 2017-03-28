using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ModProj))]
#if Dev
    [RunLocal]
#endif

	public class PM_ModProj:ReadOnlyBase<PM_ModProj>
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

		
        public bool Active
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

		
        public string CtrlDeptCode
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

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool CanBud
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

		
        public bool IsPirFund
        {
            get ;
            set ;
        }

		
        public string IncomeCode
        {
            get ;
            set ;
        }

		
        public string AllotTypeCode
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

		
        public bool IsCarryOver
        {
            get ;
            set ;
        }

		
        public bool IsInv
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

		
        public decimal FDAmt
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

		
        public string XDWF
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

		
        public string ZXWF
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

		
		#endregion

		#region Factory Methods

		public static PM_ModProj Create()
        {
            return EF.DataPortal.Create<PM_ModProj>();
        }

		public static PM_ModProj Fetch(System.Linq.Expressions.Expression<Func<PM_ModProj, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ModProj>(exp,values);
            return EF.DataPortal.Fetch<PM_ModProj>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ModProjs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ModProjs:ReadOnlyListBase<PM_ModProjs,PM_ModProj>
    {
        #region Factory Methods

        public static PM_ModProjs Fetch()
        {
            return EF.DataPortal.Fetch<PM_ModProjs>();
        }

		public static PM_ModProjs Fetch(System.Linq.Expressions.Expression<Func<PM_ModProj, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ModProj>(exp,values);
            return EF.DataPortal.Fetch<PM_ModProjs>(lambda);
		}

		public static PM_ModProjs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ModProjs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ModProjs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ModProj, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ModProjs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ModProj>(exp,values)});
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
