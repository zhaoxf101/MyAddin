using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_WoffLoanSub))]
#if Dev
    [RunLocal]
#endif

	public class FI_WoffLoanSub:ReadOnlyBase<FI_WoffLoanSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string WoffCode
        {
            get ;
            set ;
        }

		
        public string VouchNo
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

		
        public string LineNR
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public string LoanCode
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

		
        public string ContractId
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public decimal ActAmt
        {
            get ;
            set ;
        }

		
        public string ItemText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_WoffLoanSub Create()
        {
            return EF.DataPortal.Create<FI_WoffLoanSub>();
        }

		public static FI_WoffLoanSub Fetch(System.Linq.Expressions.Expression<Func<FI_WoffLoanSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_WoffLoanSub>(exp,values);
            return EF.DataPortal.Fetch<FI_WoffLoanSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_WoffLoanSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_WoffLoanSubs:ReadOnlyListBase<FI_WoffLoanSubs,FI_WoffLoanSub>
    {
        #region Factory Methods

        public static FI_WoffLoanSubs Fetch()
        {
            return EF.DataPortal.Fetch<FI_WoffLoanSubs>();
        }

		public static FI_WoffLoanSubs Fetch(System.Linq.Expressions.Expression<Func<FI_WoffLoanSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_WoffLoanSub>(exp,values);
            return EF.DataPortal.Fetch<FI_WoffLoanSubs>(lambda);
		}

		public static FI_WoffLoanSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_WoffLoanSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_WoffLoanSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_WoffLoanSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_WoffLoanSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_WoffLoanSub>(exp,values)});
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
