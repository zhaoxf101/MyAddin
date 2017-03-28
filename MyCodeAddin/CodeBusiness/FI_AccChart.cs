using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_AccChart))]
#if Dev
    [RunLocal]
#endif

	public class FI_AccChart:ReadOnlyBase<FI_AccChart>
    {
        #region Business Methods

		
        public string AccChart
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public int Length
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_AccChart Create()
        {
            return EF.DataPortal.Create<FI_AccChart>();
        }

		public static FI_AccChart Fetch(System.Linq.Expressions.Expression<Func<FI_AccChart, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_AccChart>(exp,values);
            return EF.DataPortal.Fetch<FI_AccChart>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_AccCharts))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_AccCharts:ReadOnlyListBase<FI_AccCharts,FI_AccChart>
    {
        #region Factory Methods

        public static FI_AccCharts Fetch()
        {
            return EF.DataPortal.Fetch<FI_AccCharts>();
        }

		public static FI_AccCharts Fetch(System.Linq.Expressions.Expression<Func<FI_AccChart, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_AccChart>(exp,values);
            return EF.DataPortal.Fetch<FI_AccCharts>(lambda);
		}

		public static FI_AccCharts Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_AccCharts>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_AccCharts Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_AccChart, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_AccCharts>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_AccChart>(exp,values)});
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
