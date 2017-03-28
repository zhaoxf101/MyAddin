using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusSubFund))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusSubFund:ReadOnlyBase<FI_ExpBusSubFund>
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

		
        public string ExpItemId
        {
            get ;
            set ;
        }

		
        public string ResId
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

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
        public string PBudExpEcoCode
        {
            get ;
            set ;
        }

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpBusSubFund Create()
        {
            return EF.DataPortal.Create<FI_ExpBusSubFund>();
        }

		public static FI_ExpBusSubFund Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusSubFund, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusSubFund>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusSubFund>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusSubFunds))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusSubFunds:ReadOnlyListBase<FI_ExpBusSubFunds,FI_ExpBusSubFund>
    {
        #region Factory Methods

        public static FI_ExpBusSubFunds Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusSubFunds>();
        }

		public static FI_ExpBusSubFunds Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusSubFund, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusSubFund>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusSubFunds>(lambda);
		}

		public static FI_ExpBusSubFunds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusSubFunds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusSubFunds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusSubFund, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusSubFunds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusSubFund>(exp,values)});
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
