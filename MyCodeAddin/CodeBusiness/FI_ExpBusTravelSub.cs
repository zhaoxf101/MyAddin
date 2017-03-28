using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusTravelSub))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusTravelSub:ReadOnlyBase<FI_ExpBusTravelSub>
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

		
        public int TravelRowId
        {
            get ;
            set ;
        }

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public string ResouGrpCode
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt
        {
            get ;
            set ;
        }

		
        public decimal ActAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpBusTravelSub Create()
        {
            return EF.DataPortal.Create<FI_ExpBusTravelSub>();
        }

		public static FI_ExpBusTravelSub Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusTravelSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusTravelSub>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusTravelSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusTravelSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusTravelSubs:ReadOnlyListBase<FI_ExpBusTravelSubs,FI_ExpBusTravelSub>
    {
        #region Factory Methods

        public static FI_ExpBusTravelSubs Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusTravelSubs>();
        }

		public static FI_ExpBusTravelSubs Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusTravelSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusTravelSub>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusTravelSubs>(lambda);
		}

		public static FI_ExpBusTravelSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusTravelSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusTravelSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusTravelSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusTravelSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusTravelSub>(exp,values)});
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
