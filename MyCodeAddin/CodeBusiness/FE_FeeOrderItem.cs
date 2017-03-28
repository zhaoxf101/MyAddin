using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_FeeOrderItem))]
#if Dev
    [RunLocal]
#endif

	public class FE_FeeOrderItem:ReadOnlyBase<FE_FeeOrderItem>
    {
        #region Business Methods

		
        public string Client
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

		
        public string RowsId
        {
            get ;
            set ;
        }

		
        public decimal? InAmt
        {
            get ;
            set ;
        }

		
        public decimal? PayAmt
        {
            get ;
            set ;
        }

		
        public decimal? AdjustFee
        {
            get ;
            set ;
        }

		
        public string VerifyFiled
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_FeeOrderItem Create()
        {
            return EF.DataPortal.Create<FE_FeeOrderItem>();
        }

		public static FE_FeeOrderItem Fetch(System.Linq.Expressions.Expression<Func<FE_FeeOrderItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_FeeOrderItem>(exp,values);
            return EF.DataPortal.Fetch<FE_FeeOrderItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_FeeOrderItems))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_FeeOrderItems:ReadOnlyListBase<FE_FeeOrderItems,FE_FeeOrderItem>
    {
        #region Factory Methods

        public static FE_FeeOrderItems Fetch()
        {
            return EF.DataPortal.Fetch<FE_FeeOrderItems>();
        }

		public static FE_FeeOrderItems Fetch(System.Linq.Expressions.Expression<Func<FE_FeeOrderItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_FeeOrderItem>(exp,values);
            return EF.DataPortal.Fetch<FE_FeeOrderItems>(lambda);
		}

		public static FE_FeeOrderItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_FeeOrderItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_FeeOrderItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_FeeOrderItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_FeeOrderItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_FeeOrderItem>(exp,values)});
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
