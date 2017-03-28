using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_AllotApp))]
#if Dev
    [RunLocal]
#endif

	public class PM_AllotApp:ReadOnlyBase<PM_AllotApp>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AllotAppNo
        {
            get ;
            set ;
        }

		
        public string BarCode
        {
            get ;
            set ;
        }

		
        public string BusType
        {
            get ;
            set ;
        }

		
        public string AllotBusTypeCode
        {
            get ;
            set ;
        }

		
        public string AllotTypeCode
        {
            get ;
            set ;
        }

		
        public string IncDetCode
        {
            get ;
            set ;
        }

		
        public string ItemText
        {
            get ;
            set ;
        }

		
        public bool IsFundIn
        {
            get ;
            set ;
        }

		
        public bool IsProjIn
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string LStaff
        {
            get ;
            set ;
        }

		
        public string CostCtr
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

		
        public decimal UnInProjAmt
        {
            get ;
            set ;
        }

		
        public decimal AppAmt
        {
            get ;
            set ;
        }

		
        public decimal AlloAmt
        {
            get ;
            set ;
        }

		
        public decimal MaxExpAmt
        {
            get ;
            set ;
        }

		
        public decimal OrdExpAmt
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt
        {
            get ;
            set ;
        }

		
        public decimal MaxFee
        {
            get ;
            set ;
        }

		
        public decimal FeeAmt
        {
            get ;
            set ;
        }

		
        public decimal OrdFee
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsAllot
        {
            get ;
            set ;
        }

		
        public bool IsAppr
        {
            get ;
            set ;
        }

		
        public bool IsChk
        {
            get ;
            set ;
        }

		
        public bool Cancelled
        {
            get ;
            set ;
        }

		
        public bool Approved
        {
            get ;
            set ;
        }

		
        public bool IsCancel
        {
            get ;
            set ;
        }

		
        public bool IsAllotEnd
        {
            get ;
            set ;
        }

		
        public string IncAccCode
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string AccDateTime
        {
            get ;
            set ;
        }

		
        public bool GenVouX
        {
            get ;
            set ;
        }

		
        public string PreVouchNo
        {
            get ;
            set ;
        }

		
        public string VouchText
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string AccPid
        {
            get ;
            set ;
        }

		
        public string VouDate
        {
            get ;
            set ;
        }

		
        public string VouchNo
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

		
        public string RDCheckedUser
        {
            get ;
            set ;
        }

		
        public DateTime? RDCheckedDate
        {
            get ;
            set ;
        }

		
        public string FICheckedUser
        {
            get ;
            set ;
        }

		
        public DateTime? FICheckedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_AllotApp Create()
        {
            return EF.DataPortal.Create<PM_AllotApp>();
        }

		public static PM_AllotApp Fetch(System.Linq.Expressions.Expression<Func<PM_AllotApp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotApp>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotApp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_AllotApps))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_AllotApps:ReadOnlyListBase<PM_AllotApps,PM_AllotApp>
    {
        #region Factory Methods

        public static PM_AllotApps Fetch()
        {
            return EF.DataPortal.Fetch<PM_AllotApps>();
        }

		public static PM_AllotApps Fetch(System.Linq.Expressions.Expression<Func<PM_AllotApp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotApp>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotApps>(lambda);
		}

		public static PM_AllotApps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_AllotApps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_AllotApps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_AllotApp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_AllotApps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_AllotApp>(exp,values)});
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
