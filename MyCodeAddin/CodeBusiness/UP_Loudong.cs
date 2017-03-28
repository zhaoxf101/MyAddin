using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_Loudong))]
#if Dev
    [RunLocal]
#endif

	public class UP_Loudong:ReadOnlyBase<UP_Loudong>
    {
        #region Business Methods

		
        public string xiaoqu_id
        {
            get ;
            set ;
        }

		
        public string loudong_id
        {
            get ;
            set ;
        }

		
        public string loudong
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static UP_Loudong Create()
        {
            return EF.DataPortal.Create<UP_Loudong>();
        }

		public static UP_Loudong Fetch(System.Linq.Expressions.Expression<Func<UP_Loudong, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_Loudong>(exp,values);
            return EF.DataPortal.Fetch<UP_Loudong>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_Loudongs))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_Loudongs:ReadOnlyListBase<UP_Loudongs,UP_Loudong>
    {
        #region Factory Methods

        public static UP_Loudongs Fetch()
        {
            return EF.DataPortal.Fetch<UP_Loudongs>();
        }

		public static UP_Loudongs Fetch(System.Linq.Expressions.Expression<Func<UP_Loudong, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_Loudong>(exp,values);
            return EF.DataPortal.Fetch<UP_Loudongs>(lambda);
		}

		public static UP_Loudongs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_Loudongs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_Loudongs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_Loudong, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_Loudongs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_Loudong>(exp,values)});
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
