using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_LoanSub))]
#if Dev
    [RunLocal]
#endif

	public class FI_LoanSub:ReadOnlyBase<FI_LoanSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string LoanCode
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

		
        public decimal LoanAmt
        {
            get ;
            set ;
        }

		
        public decimal LoanActAmt
        {
            get ;
            set ;
        }

		
        public decimal ExpBusAmt
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

		
		#endregion

		#region Factory Methods

		public static FI_LoanSub Create()
        {
            return EF.DataPortal.Create<FI_LoanSub>();
        }

		public static FI_LoanSub Fetch(System.Linq.Expressions.Expression<Func<FI_LoanSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_LoanSub>(exp,values);
            return EF.DataPortal.Fetch<FI_LoanSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_LoanSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_LoanSubs:ReadOnlyListBase<FI_LoanSubs,FI_LoanSub>
    {
        #region Factory Methods

        public static FI_LoanSubs Fetch()
        {
            return EF.DataPortal.Fetch<FI_LoanSubs>();
        }

		public static FI_LoanSubs Fetch(System.Linq.Expressions.Expression<Func<FI_LoanSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_LoanSub>(exp,values);
            return EF.DataPortal.Fetch<FI_LoanSubs>(lambda);
		}

		public static FI_LoanSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_LoanSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_LoanSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_LoanSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_LoanSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_LoanSub>(exp,values)});
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
