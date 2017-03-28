using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_Views))]
#if Dev
    [RunLocal]
#endif

	public class EF_Views:ReadOnlyBase<EF_Views>
    {
        #region Business Methods

		
        public string ViewName
        {
            get ;
            set ;
        }

		
        public string TableName
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public int Position
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_Views Create()
        {
            return EF.DataPortal.Create<EF_Views>();
        }

		public static EF_Views Fetch(System.Linq.Expressions.Expression<Func<EF_Views, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_Views>(exp,values);
            return EF.DataPortal.Fetch<EF_Views>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_Viewss))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_Viewss:ReadOnlyListBase<EF_Viewss,EF_Views>
    {
        #region Factory Methods

        public static EF_Viewss Fetch()
        {
            return EF.DataPortal.Fetch<EF_Viewss>();
        }

		public static EF_Viewss Fetch(System.Linq.Expressions.Expression<Func<EF_Views, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_Views>(exp,values);
            return EF.DataPortal.Fetch<EF_Viewss>(lambda);
		}

		public static EF_Viewss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_Viewss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_Viewss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_Views, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_Viewss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_Views>(exp,values)});
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
