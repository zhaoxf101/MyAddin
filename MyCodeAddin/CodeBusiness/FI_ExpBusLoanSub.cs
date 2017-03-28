using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusLoanSub))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusLoanSub:ReadOnlyBase<FI_ExpBusLoanSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExpBusCode
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

		
        public string LoanCode
        {
            get ;
            set ;
        }

		
        public string FundCode
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

		
        public decimal OrdAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpBusLoanSub Create()
        {
            return EF.DataPortal.Create<FI_ExpBusLoanSub>();
        }

		public static FI_ExpBusLoanSub Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusLoanSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusLoanSub>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusLoanSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusLoanSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusLoanSubs:ReadOnlyListBase<FI_ExpBusLoanSubs,FI_ExpBusLoanSub>
    {
        #region Factory Methods

        public static FI_ExpBusLoanSubs Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusLoanSubs>();
        }

		public static FI_ExpBusLoanSubs Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusLoanSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusLoanSub>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusLoanSubs>(lambda);
		}

		public static FI_ExpBusLoanSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusLoanSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusLoanSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusLoanSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusLoanSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusLoanSub>(exp,values)});
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
