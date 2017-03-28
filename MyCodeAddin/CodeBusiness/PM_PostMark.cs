using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_PostMark))]
#if Dev
    [RunLocal]
#endif

	public class PM_PostMark:ReadOnlyBase<PM_PostMark>
    {
        #region Business Methods

		
        public string PostMark
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_PostMark Create()
        {
            return EF.DataPortal.Create<PM_PostMark>();
        }

		public static PM_PostMark Fetch(System.Linq.Expressions.Expression<Func<PM_PostMark, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_PostMark>(exp,values);
            return EF.DataPortal.Fetch<PM_PostMark>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_PostMarks))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_PostMarks:ReadOnlyListBase<PM_PostMarks,PM_PostMark>
    {
        #region Factory Methods

        public static PM_PostMarks Fetch()
        {
            return EF.DataPortal.Fetch<PM_PostMarks>();
        }

		public static PM_PostMarks Fetch(System.Linq.Expressions.Expression<Func<PM_PostMark, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_PostMark>(exp,values);
            return EF.DataPortal.Fetch<PM_PostMarks>(lambda);
		}

		public static PM_PostMarks Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_PostMarks>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_PostMarks Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_PostMark, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_PostMarks>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_PostMark>(exp,values)});
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
