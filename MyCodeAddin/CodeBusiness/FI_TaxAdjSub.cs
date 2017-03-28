using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_TaxAdjSub))]
#if Dev
    [RunLocal]
#endif

	public class FI_TaxAdjSub:ReadOnlyBase<FI_TaxAdjSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TaxAdjCode
        {
            get ;
            set ;
        }

		
        public string Period
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
        public decimal TaxAmt
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

		public static FI_TaxAdjSub Create()
        {
            return EF.DataPortal.Create<FI_TaxAdjSub>();
        }

		public static FI_TaxAdjSub Fetch(System.Linq.Expressions.Expression<Func<FI_TaxAdjSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_TaxAdjSub>(exp,values);
            return EF.DataPortal.Fetch<FI_TaxAdjSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_TaxAdjSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_TaxAdjSubs:ReadOnlyListBase<FI_TaxAdjSubs,FI_TaxAdjSub>
    {
        #region Factory Methods

        public static FI_TaxAdjSubs Fetch()
        {
            return EF.DataPortal.Fetch<FI_TaxAdjSubs>();
        }

		public static FI_TaxAdjSubs Fetch(System.Linq.Expressions.Expression<Func<FI_TaxAdjSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_TaxAdjSub>(exp,values);
            return EF.DataPortal.Fetch<FI_TaxAdjSubs>(lambda);
		}

		public static FI_TaxAdjSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_TaxAdjSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_TaxAdjSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_TaxAdjSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_TaxAdjSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_TaxAdjSub>(exp,values)});
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
