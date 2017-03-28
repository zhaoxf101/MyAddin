using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjectLedger))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjectLedger:ReadOnlyBase<PM_ProjectLedger>
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

		
        public bool IsAllotFund
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool Freeze
        {
            get ;
            set ;
        }

		
        public bool IsAdd
        {
            get ;
            set ;
        }

		
        public string StatusCode
        {
            get ;
            set ;
        }

		
        public string BudCheckMemo
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

		
        public decimal FDAmt
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

		
        public decimal ExpAmt
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

		
        public decimal RateAmt
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

		public static PM_ProjectLedger Create()
        {
            return EF.DataPortal.Create<PM_ProjectLedger>();
        }

		public static PM_ProjectLedger Fetch(System.Linq.Expressions.Expression<Func<PM_ProjectLedger, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjectLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjectLedger>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjectLedgers))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjectLedgers:ReadOnlyListBase<PM_ProjectLedgers,PM_ProjectLedger>
    {
        #region Factory Methods

        public static PM_ProjectLedgers Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjectLedgers>();
        }

		public static PM_ProjectLedgers Fetch(System.Linq.Expressions.Expression<Func<PM_ProjectLedger, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjectLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjectLedgers>(lambda);
		}

		public static PM_ProjectLedgers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjectLedgers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjectLedgers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjectLedger, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjectLedgers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjectLedger>(exp,values)});
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
