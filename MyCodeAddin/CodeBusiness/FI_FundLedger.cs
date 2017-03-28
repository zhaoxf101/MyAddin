using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_FundLedger))]
#if Dev
    [RunLocal]
#endif

	public class FI_FundLedger:ReadOnlyBase<FI_FundLedger>
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

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public decimal LRAmt
        {
            get ;
            set ;
        }

		
        public decimal InAmt
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

		
        public decimal BAmt
        {
            get ;
            set ;
        }

		
        public decimal IncAmt01
        {
            get ;
            set ;
        }

		
        public decimal IncAmt02
        {
            get ;
            set ;
        }

		
        public decimal IncAmt03
        {
            get ;
            set ;
        }

		
        public decimal IncAmt04
        {
            get ;
            set ;
        }

		
        public decimal IncAmt05
        {
            get ;
            set ;
        }

		
        public decimal IncAmt06
        {
            get ;
            set ;
        }

		
        public decimal IncAmt07
        {
            get ;
            set ;
        }

		
        public decimal IncAmt08
        {
            get ;
            set ;
        }

		
        public decimal IncAmt09
        {
            get ;
            set ;
        }

		
        public decimal IncAmt10
        {
            get ;
            set ;
        }

		
        public decimal IncAmt11
        {
            get ;
            set ;
        }

		
        public decimal IncAmt12
        {
            get ;
            set ;
        }

		
        public decimal IncAmt13
        {
            get ;
            set ;
        }

		
        public decimal IncAmt14
        {
            get ;
            set ;
        }

		
        public decimal IncAmt15
        {
            get ;
            set ;
        }

		
        public decimal IncAmt16
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt01
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt02
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt03
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt04
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt05
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt06
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt07
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt08
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt09
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt10
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt11
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt12
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt13
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt14
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt15
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt16
        {
            get ;
            set ;
        }

		
        public decimal BLAmt
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt01
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt02
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt03
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt04
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt05
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt06
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt07
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt08
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt09
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt10
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt11
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt12
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt13
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt14
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt15
        {
            get ;
            set ;
        }

		
        public decimal LoaAmt16
        {
            get ;
            set ;
        }

		
        public decimal LorAmt01
        {
            get ;
            set ;
        }

		
        public decimal LorAmt02
        {
            get ;
            set ;
        }

		
        public decimal LorAmt03
        {
            get ;
            set ;
        }

		
        public decimal LorAmt04
        {
            get ;
            set ;
        }

		
        public decimal LorAmt05
        {
            get ;
            set ;
        }

		
        public decimal LorAmt06
        {
            get ;
            set ;
        }

		
        public decimal LorAmt07
        {
            get ;
            set ;
        }

		
        public decimal LorAmt08
        {
            get ;
            set ;
        }

		
        public decimal LorAmt09
        {
            get ;
            set ;
        }

		
        public decimal LorAmt10
        {
            get ;
            set ;
        }

		
        public decimal LorAmt11
        {
            get ;
            set ;
        }

		
        public decimal LorAmt12
        {
            get ;
            set ;
        }

		
        public decimal LorAmt13
        {
            get ;
            set ;
        }

		
        public decimal LorAmt14
        {
            get ;
            set ;
        }

		
        public decimal LorAmt15
        {
            get ;
            set ;
        }

		
        public decimal LorAmt16
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_FundLedger Create()
        {
            return EF.DataPortal.Create<FI_FundLedger>();
        }

		public static FI_FundLedger Fetch(System.Linq.Expressions.Expression<Func<FI_FundLedger, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_FundLedger>(exp,values);
            return EF.DataPortal.Fetch<FI_FundLedger>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_FundLedgers))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_FundLedgers:ReadOnlyListBase<FI_FundLedgers,FI_FundLedger>
    {
        #region Factory Methods

        public static FI_FundLedgers Fetch()
        {
            return EF.DataPortal.Fetch<FI_FundLedgers>();
        }

		public static FI_FundLedgers Fetch(System.Linq.Expressions.Expression<Func<FI_FundLedger, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_FundLedger>(exp,values);
            return EF.DataPortal.Fetch<FI_FundLedgers>(lambda);
		}

		public static FI_FundLedgers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_FundLedgers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_FundLedgers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_FundLedger, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_FundLedgers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_FundLedger>(exp,values)});
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
