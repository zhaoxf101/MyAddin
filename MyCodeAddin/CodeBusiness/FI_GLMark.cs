using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_GLMark))]
#if Dev
    [RunLocal]
#endif

	public class FI_GLMark:ReadOnlyBase<FI_GLMark>
    {
        #region Business Methods

		
        public string AccType
        {
            get ;
            set ;
        }

		
        public string GLMark
        {
            get ;
            set ;
        }

		
        public string SText
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_GLMark Create()
        {
            return EF.DataPortal.Create<FI_GLMark>();
        }

		public static FI_GLMark Fetch(System.Linq.Expressions.Expression<Func<FI_GLMark, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_GLMark>(exp,values);
            return EF.DataPortal.Fetch<FI_GLMark>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_GLMarks))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_GLMarks:ReadOnlyListBase<FI_GLMarks,FI_GLMark>
    {
        #region Factory Methods

        public static FI_GLMarks Fetch()
        {
            return EF.DataPortal.Fetch<FI_GLMarks>();
        }

		public static FI_GLMarks Fetch(System.Linq.Expressions.Expression<Func<FI_GLMark, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_GLMark>(exp,values);
            return EF.DataPortal.Fetch<FI_GLMarks>(lambda);
		}

		public static FI_GLMarks Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_GLMarks>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_GLMarks Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_GLMark, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_GLMarks>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_GLMark>(exp,values)});
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
