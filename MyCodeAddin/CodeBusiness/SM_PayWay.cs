using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_PayWay))]
#if Dev
    [RunLocal]
#endif

	public class SM_PayWay:ReadOnlyBase<SM_PayWay>
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

		
        public bool IsReturn
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_PayWay Create()
        {
            return EF.DataPortal.Create<SM_PayWay>();
        }

		public static SM_PayWay Fetch(System.Linq.Expressions.Expression<Func<SM_PayWay, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_PayWay>(exp,values);
            return EF.DataPortal.Fetch<SM_PayWay>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_PayWays))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_PayWays:ReadOnlyListBase<SM_PayWays,SM_PayWay>
    {
        #region Factory Methods

        public static SM_PayWays Fetch()
        {
            return EF.DataPortal.Fetch<SM_PayWays>();
        }

		public static SM_PayWays Fetch(System.Linq.Expressions.Expression<Func<SM_PayWay, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_PayWay>(exp,values);
            return EF.DataPortal.Fetch<SM_PayWays>(lambda);
		}

		public static SM_PayWays Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_PayWays>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_PayWays Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_PayWay, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_PayWays>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_PayWay>(exp,values)});
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
