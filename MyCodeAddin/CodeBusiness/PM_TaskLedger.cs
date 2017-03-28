using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_TaskLedger))]
#if Dev
    [RunLocal]
#endif

	public class PM_TaskLedger:ReadOnlyBase<PM_TaskLedger>
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

		
        public string SBudExpFunCode
        {
            get ;
            set ;
        }

		
        public bool Freeze
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

		
        public bool IsBudCtrl
        {
            get ;
            set ;
        }

		
        public bool IsSpecial
        {
            get ;
            set ;
        }

		
        public string ExpAcctCode1
        {
            get ;
            set ;
        }

		
        public string ExpAcctCode2
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

		public static PM_TaskLedger Create()
        {
            return EF.DataPortal.Create<PM_TaskLedger>();
        }

		public static PM_TaskLedger Fetch(System.Linq.Expressions.Expression<Func<PM_TaskLedger, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_TaskLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_TaskLedger>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_TaskLedgers))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_TaskLedgers:ReadOnlyListBase<PM_TaskLedgers,PM_TaskLedger>
    {
        #region Factory Methods

        public static PM_TaskLedgers Fetch()
        {
            return EF.DataPortal.Fetch<PM_TaskLedgers>();
        }

		public static PM_TaskLedgers Fetch(System.Linq.Expressions.Expression<Func<PM_TaskLedger, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_TaskLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_TaskLedgers>(lambda);
		}

		public static PM_TaskLedgers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_TaskLedgers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_TaskLedgers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_TaskLedger, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_TaskLedgers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_TaskLedger>(exp,values)});
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
