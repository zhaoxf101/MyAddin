using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CG_PayWay))]
#if Dev
    [RunLocal]
#endif

	public class CG_PayWay:ReadOnlyBase<CG_PayWay>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PayWayCode
        {
            get ;
            set ;
        }

		
        public string PayWayName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CG_PayWay Create()
        {
            return EF.DataPortal.Create<CG_PayWay>();
        }

		public static CG_PayWay Fetch(System.Linq.Expressions.Expression<Func<CG_PayWay, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CG_PayWay>(exp,values);
            return EF.DataPortal.Fetch<CG_PayWay>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CG_PayWays))]
#if Dev
    [RunLocal]
#endif
	
	public class CG_PayWays:ReadOnlyListBase<CG_PayWays,CG_PayWay>
    {
        #region Factory Methods

        public static CG_PayWays Fetch()
        {
            return EF.DataPortal.Fetch<CG_PayWays>();
        }

		public static CG_PayWays Fetch(System.Linq.Expressions.Expression<Func<CG_PayWay, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CG_PayWay>(exp,values);
            return EF.DataPortal.Fetch<CG_PayWays>(lambda);
		}

		public static CG_PayWays Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CG_PayWays>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CG_PayWays Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CG_PayWay, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CG_PayWays>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CG_PayWay>(exp,values)});
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
