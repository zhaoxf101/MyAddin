using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_Balance))]
#if Dev
    [RunLocal]
#endif

	public class FE_Balance:ReadOnlyBase<FE_Balance>
    {
        #region Business Methods

		
        public string Mch_Id
        {
            get ;
            set ;
        }

		
        public string DebitDate
        {
            get ;
            set ;
        }

		
        public string StartDate
        {
            get ;
            set ;
        }

		
        public string EndDate
        {
            get ;
            set ;
        }

		
        public decimal TransactionFee
        {
            get ;
            set ;
        }

		
        public int TransactionCount
        {
            get ;
            set ;
        }

		
        public decimal RefundFee
        {
            get ;
            set ;
        }

		
        public int RefundCount
        {
            get ;
            set ;
        }

		
        public decimal PayFee
        {
            get ;
            set ;
        }

		
        public decimal poundage
        {
            get ;
            set ;
        }

		
        public decimal BalanceFee
        {
            get ;
            set ;
        }

		
        public bool IsChecked
        {
            get ;
            set ;
        }

		
        public string BillNo
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_Balance Create()
        {
            return EF.DataPortal.Create<FE_Balance>();
        }

		public static FE_Balance Fetch(System.Linq.Expressions.Expression<Func<FE_Balance, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_Balance>(exp,values);
            return EF.DataPortal.Fetch<FE_Balance>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_Balances))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_Balances:ReadOnlyListBase<FE_Balances,FE_Balance>
    {
        #region Factory Methods

        public static FE_Balances Fetch()
        {
            return EF.DataPortal.Fetch<FE_Balances>();
        }

		public static FE_Balances Fetch(System.Linq.Expressions.Expression<Func<FE_Balance, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_Balance>(exp,values);
            return EF.DataPortal.Fetch<FE_Balances>(lambda);
		}

		public static FE_Balances Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_Balances>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_Balances Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_Balance, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_Balances>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_Balance>(exp,values)});
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
