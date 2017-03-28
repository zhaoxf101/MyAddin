using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CG_Interval))]
#if Dev
    [RunLocal]
#endif

	public class CG_Interval:ReadOnlyBase<CG_Interval>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string IntervalCode
        {
            get ;
            set ;
        }

		
        public string IntervalName
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

		
		#endregion

		#region Factory Methods

		public static CG_Interval Create()
        {
            return EF.DataPortal.Create<CG_Interval>();
        }

		public static CG_Interval Fetch(System.Linq.Expressions.Expression<Func<CG_Interval, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CG_Interval>(exp,values);
            return EF.DataPortal.Fetch<CG_Interval>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CG_Intervals))]
#if Dev
    [RunLocal]
#endif
	
	public class CG_Intervals:ReadOnlyListBase<CG_Intervals,CG_Interval>
    {
        #region Factory Methods

        public static CG_Intervals Fetch()
        {
            return EF.DataPortal.Fetch<CG_Intervals>();
        }

		public static CG_Intervals Fetch(System.Linq.Expressions.Expression<Func<CG_Interval, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CG_Interval>(exp,values);
            return EF.DataPortal.Fetch<CG_Intervals>(lambda);
		}

		public static CG_Intervals Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CG_Intervals>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CG_Intervals Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CG_Interval, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CG_Intervals>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CG_Interval>(exp,values)});
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
