using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_Activity))]
#if Dev
    [RunLocal]
#endif

	public class WF_Activity:ReadOnlyBase<WF_Activity>
    {
        #region Business Methods

		
        public string ActivityId
        {
            get ;
            set ;
        }

		
        public string ActivityName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static WF_Activity Create()
        {
            return EF.DataPortal.Create<WF_Activity>();
        }

		public static WF_Activity Fetch(System.Linq.Expressions.Expression<Func<WF_Activity, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_Activity>(exp,values);
            return EF.DataPortal.Fetch<WF_Activity>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_Activitys))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_Activitys:ReadOnlyListBase<WF_Activitys,WF_Activity>
    {
        #region Factory Methods

        public static WF_Activitys Fetch()
        {
            return EF.DataPortal.Fetch<WF_Activitys>();
        }

		public static WF_Activitys Fetch(System.Linq.Expressions.Expression<Func<WF_Activity, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_Activity>(exp,values);
            return EF.DataPortal.Fetch<WF_Activitys>(lambda);
		}

		public static WF_Activitys Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_Activitys>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_Activitys Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_Activity, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_Activitys>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_Activity>(exp,values)});
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
