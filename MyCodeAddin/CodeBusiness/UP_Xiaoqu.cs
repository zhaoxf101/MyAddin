using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_Xiaoqu))]
#if Dev
    [RunLocal]
#endif

	public class UP_Xiaoqu:ReadOnlyBase<UP_Xiaoqu>
    {
        #region Business Methods

		
        public string xiaoqu_id
        {
            get ;
            set ;
        }

		
        public string xiaoqu
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static UP_Xiaoqu Create()
        {
            return EF.DataPortal.Create<UP_Xiaoqu>();
        }

		public static UP_Xiaoqu Fetch(System.Linq.Expressions.Expression<Func<UP_Xiaoqu, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_Xiaoqu>(exp,values);
            return EF.DataPortal.Fetch<UP_Xiaoqu>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_Xiaoqus))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_Xiaoqus:ReadOnlyListBase<UP_Xiaoqus,UP_Xiaoqu>
    {
        #region Factory Methods

        public static UP_Xiaoqus Fetch()
        {
            return EF.DataPortal.Fetch<UP_Xiaoqus>();
        }

		public static UP_Xiaoqus Fetch(System.Linq.Expressions.Expression<Func<UP_Xiaoqu, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_Xiaoqu>(exp,values);
            return EF.DataPortal.Fetch<UP_Xiaoqus>(lambda);
		}

		public static UP_Xiaoqus Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_Xiaoqus>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_Xiaoqus Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_Xiaoqu, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_Xiaoqus>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_Xiaoqu>(exp,values)});
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
