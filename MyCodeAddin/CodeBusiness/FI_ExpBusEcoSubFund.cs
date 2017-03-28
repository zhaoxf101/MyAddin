using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusEcoSubFund))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusEcoSubFund:ReadOnlyBase<FI_ExpBusEcoSubFund>
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

		
        public string PBudExpEcoCode
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public decimal AdjAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpBusEcoSubFund Create()
        {
            return EF.DataPortal.Create<FI_ExpBusEcoSubFund>();
        }

		public static FI_ExpBusEcoSubFund Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusEcoSubFund, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusEcoSubFund>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusEcoSubFund>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusEcoSubFunds))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusEcoSubFunds:ReadOnlyListBase<FI_ExpBusEcoSubFunds,FI_ExpBusEcoSubFund>
    {
        #region Factory Methods

        public static FI_ExpBusEcoSubFunds Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusEcoSubFunds>();
        }

		public static FI_ExpBusEcoSubFunds Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusEcoSubFund, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusEcoSubFund>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusEcoSubFunds>(lambda);
		}

		public static FI_ExpBusEcoSubFunds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusEcoSubFunds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusEcoSubFunds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusEcoSubFund, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusEcoSubFunds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusEcoSubFund>(exp,values)});
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
