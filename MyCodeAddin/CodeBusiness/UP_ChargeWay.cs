using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_ChargeWay))]
#if Dev
    [RunLocal]
#endif

	public class UP_ChargeWay:ReadOnlyBase<UP_ChargeWay>
    {
        #region Business Methods

		
        public string ChargeWayCode
        {
            get ;
            set ;
        }

		
        public string ChargeWayName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static UP_ChargeWay Create()
        {
            return EF.DataPortal.Create<UP_ChargeWay>();
        }

		public static UP_ChargeWay Fetch(System.Linq.Expressions.Expression<Func<UP_ChargeWay, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_ChargeWay>(exp,values);
            return EF.DataPortal.Fetch<UP_ChargeWay>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_ChargeWays))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_ChargeWays:ReadOnlyListBase<UP_ChargeWays,UP_ChargeWay>
    {
        #region Factory Methods

        public static UP_ChargeWays Fetch()
        {
            return EF.DataPortal.Fetch<UP_ChargeWays>();
        }

		public static UP_ChargeWays Fetch(System.Linq.Expressions.Expression<Func<UP_ChargeWay, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_ChargeWay>(exp,values);
            return EF.DataPortal.Fetch<UP_ChargeWays>(lambda);
		}

		public static UP_ChargeWays Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_ChargeWays>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_ChargeWays Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_ChargeWay, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_ChargeWays>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_ChargeWay>(exp,values)});
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
