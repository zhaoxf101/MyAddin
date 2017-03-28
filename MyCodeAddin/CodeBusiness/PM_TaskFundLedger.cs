using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_TaskFundLedger))]
#if Dev
    [RunLocal]
#endif

	public class PM_TaskFundLedger:ReadOnlyBase<PM_TaskFundLedger>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public string FundBudAreaCode
        {
            get ;
            set ;
        }

		
        public string FundFinAreaCode
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public string BAccCode
        {
            get ;
            set ;
        }

		
        public string FAccCode
        {
            get ;
            set ;
        }

		
        public string PBudExpFunCode
        {
            get ;
            set ;
        }

		
        public string FundExpTypeCode
        {
            get ;
            set ;
        }

		
        public int ExpSort
        {
            get ;
            set ;
        }

		
        public bool IsExpSort
        {
            get ;
            set ;
        }

		
        public bool IsBudItem
        {
            get ;
            set ;
        }

		
        public bool IsFinItem
        {
            get ;
            set ;
        }

		
        public bool IsCarryOver
        {
            get ;
            set ;
        }

		
        public bool IsCarryOverIn
        {
            get ;
            set ;
        }

		
        public bool IsCarryRedu
        {
            get ;
            set ;
        }

		
        public bool IsSpecial
        {
            get ;
            set ;
        }

		
        public bool IsInCtrl
        {
            get ;
            set ;
        }

		
        public bool IsChkIn
        {
            get ;
            set ;
        }

		
        public bool IsFreeze
        {
            get ;
            set ;
        }

		
        public decimal MaxDeficit
        {
            get ;
            set ;
        }

		
        public decimal LRAmt
        {
            get ;
            set ;
        }

		
        public decimal BudAmt
        {
            get ;
            set ;
        }

		
        public decimal AdjAmt
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt
        {
            get ;
            set ;
        }

		
        public decimal LRLoanAmt
        {
            get ;
            set ;
        }

		
        public decimal LoanAmt
        {
            get ;
            set ;
        }

		
        public decimal WoffAmt
        {
            get ;
            set ;
        }

		
        public decimal LRInAmt
        {
            get ;
            set ;
        }

		
        public decimal InAmt
        {
            get ;
            set ;
        }

		
        public decimal OrdAmt
        {
            get ;
            set ;
        }

		
        public decimal FIOrdAmt
        {
            get ;
            set ;
        }

		
        public decimal BUnCaAmt
        {
            get ;
            set ;
        }

		
        public decimal InUnCaAmt
        {
            get ;
            set ;
        }

		
        public decimal PBudAmt
        {
            get ;
            set ;
        }

		
        public decimal PAdjAmt
        {
            get ;
            set ;
        }

		
        public decimal DisAmt
        {
            get ;
            set ;
        }

		
        public decimal AccuAssAmt
        {
            get ;
            set ;
        }

		
        public decimal AccuInAmt
        {
            get ;
            set ;
        }

		
        public decimal AccuExpAmt
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

		public static PM_TaskFundLedger Create()
        {
            return EF.DataPortal.Create<PM_TaskFundLedger>();
        }

		public static PM_TaskFundLedger Fetch(System.Linq.Expressions.Expression<Func<PM_TaskFundLedger, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_TaskFundLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_TaskFundLedger>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_TaskFundLedgers))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_TaskFundLedgers:ReadOnlyListBase<PM_TaskFundLedgers,PM_TaskFundLedger>
    {
        #region Factory Methods

        public static PM_TaskFundLedgers Fetch()
        {
            return EF.DataPortal.Fetch<PM_TaskFundLedgers>();
        }

		public static PM_TaskFundLedgers Fetch(System.Linq.Expressions.Expression<Func<PM_TaskFundLedger, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_TaskFundLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_TaskFundLedgers>(lambda);
		}

		public static PM_TaskFundLedgers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_TaskFundLedgers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_TaskFundLedgers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_TaskFundLedger, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_TaskFundLedgers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_TaskFundLedger>(exp,values)});
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
