using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusItemFund))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusItemFund:ReadOnlyBase<FI_ExpBusItemFund>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string CostCtr
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

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpBusItemFund Create()
        {
            return EF.DataPortal.Create<FI_ExpBusItemFund>();
        }

		public static FI_ExpBusItemFund Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusItemFund, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusItemFund>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusItemFund>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusItemFunds))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusItemFunds:ReadOnlyListBase<FI_ExpBusItemFunds,FI_ExpBusItemFund>
    {
        #region Factory Methods

        public static FI_ExpBusItemFunds Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusItemFunds>();
        }

		public static FI_ExpBusItemFunds Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusItemFund, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusItemFund>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusItemFunds>(lambda);
		}

		public static FI_ExpBusItemFunds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusItemFunds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusItemFunds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusItemFund, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusItemFunds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusItemFund>(exp,values)});
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
