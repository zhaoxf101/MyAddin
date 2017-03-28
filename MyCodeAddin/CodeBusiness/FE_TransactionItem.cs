using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_TransactionItem))]
#if Dev
    [RunLocal]
#endif

	public class FE_TransactionItem:ReadOnlyBase<FE_TransactionItem>
    {
        #region Business Methods

		
        public string Out_Trade_No
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string OrderNo
        {
            get ;
            set ;
        }

		
        public decimal PayFee
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_TransactionItem Create()
        {
            return EF.DataPortal.Create<FE_TransactionItem>();
        }

		public static FE_TransactionItem Fetch(System.Linq.Expressions.Expression<Func<FE_TransactionItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_TransactionItem>(exp,values);
            return EF.DataPortal.Fetch<FE_TransactionItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_TransactionItems))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_TransactionItems:ReadOnlyListBase<FE_TransactionItems,FE_TransactionItem>
    {
        #region Factory Methods

        public static FE_TransactionItems Fetch()
        {
            return EF.DataPortal.Fetch<FE_TransactionItems>();
        }

		public static FE_TransactionItems Fetch(System.Linq.Expressions.Expression<Func<FE_TransactionItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_TransactionItem>(exp,values);
            return EF.DataPortal.Fetch<FE_TransactionItems>(lambda);
		}

		public static FE_TransactionItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_TransactionItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_TransactionItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_TransactionItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_TransactionItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_TransactionItem>(exp,values)});
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
