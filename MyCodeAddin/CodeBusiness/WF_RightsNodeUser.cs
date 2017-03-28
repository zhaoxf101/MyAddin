using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_RightsNodeUser))]
#if Dev
    [RunLocal]
#endif

	public class WF_RightsNodeUser:ReadOnlyBase<WF_RightsNodeUser>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string RNodeCode
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string PositionCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static WF_RightsNodeUser Create()
        {
            return EF.DataPortal.Create<WF_RightsNodeUser>();
        }

		public static WF_RightsNodeUser Fetch(System.Linq.Expressions.Expression<Func<WF_RightsNodeUser, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_RightsNodeUser>(exp,values);
            return EF.DataPortal.Fetch<WF_RightsNodeUser>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_RightsNodeUsers))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_RightsNodeUsers:ReadOnlyListBase<WF_RightsNodeUsers,WF_RightsNodeUser>
    {
        #region Factory Methods

        public static WF_RightsNodeUsers Fetch()
        {
            return EF.DataPortal.Fetch<WF_RightsNodeUsers>();
        }

		public static WF_RightsNodeUsers Fetch(System.Linq.Expressions.Expression<Func<WF_RightsNodeUser, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_RightsNodeUser>(exp,values);
            return EF.DataPortal.Fetch<WF_RightsNodeUsers>(lambda);
		}

		public static WF_RightsNodeUsers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_RightsNodeUsers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_RightsNodeUsers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_RightsNodeUser, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_RightsNodeUsers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_RightsNodeUser>(exp,values)});
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
