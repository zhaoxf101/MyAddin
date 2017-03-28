using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusEcoSub))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusEcoSub:ReadOnlyBase<FI_ExpBusEcoSub>
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

		public static FI_ExpBusEcoSub Create()
        {
            return EF.DataPortal.Create<FI_ExpBusEcoSub>();
        }

		public static FI_ExpBusEcoSub Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusEcoSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusEcoSub>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusEcoSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusEcoSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusEcoSubs:ReadOnlyListBase<FI_ExpBusEcoSubs,FI_ExpBusEcoSub>
    {
        #region Factory Methods

        public static FI_ExpBusEcoSubs Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusEcoSubs>();
        }

		public static FI_ExpBusEcoSubs Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusEcoSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusEcoSub>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusEcoSubs>(lambda);
		}

		public static FI_ExpBusEcoSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusEcoSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusEcoSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusEcoSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusEcoSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusEcoSub>(exp,values)});
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
