using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_AllotSub))]
#if Dev
    [RunLocal]
#endif

	public class PM_AllotSub:ReadOnlyBase<PM_AllotSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AllotAppNo
        {
            get ;
            set ;
        }

		
        public string AllotItemCode
        {
            get ;
            set ;
        }

		
        public decimal MaxAllotRate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_AllotSub Create()
        {
            return EF.DataPortal.Create<PM_AllotSub>();
        }

		public static PM_AllotSub Fetch(System.Linq.Expressions.Expression<Func<PM_AllotSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotSub>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_AllotSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_AllotSubs:ReadOnlyListBase<PM_AllotSubs,PM_AllotSub>
    {
        #region Factory Methods

        public static PM_AllotSubs Fetch()
        {
            return EF.DataPortal.Fetch<PM_AllotSubs>();
        }

		public static PM_AllotSubs Fetch(System.Linq.Expressions.Expression<Func<PM_AllotSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotSub>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotSubs>(lambda);
		}

		public static PM_AllotSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_AllotSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_AllotSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_AllotSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_AllotSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_AllotSub>(exp,values)});
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
