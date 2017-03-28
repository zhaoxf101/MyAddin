using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_BarMark))]
#if Dev
    [RunLocal]
#endif

	public class EF_BarMark:ReadOnlyBase<EF_BarMark>
    {
        #region Business Methods

		
        public string BarMark
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

		public static EF_BarMark Create()
        {
            return EF.DataPortal.Create<EF_BarMark>();
        }

		public static EF_BarMark Fetch(System.Linq.Expressions.Expression<Func<EF_BarMark, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_BarMark>(exp,values);
            return EF.DataPortal.Fetch<EF_BarMark>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_BarMarks))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_BarMarks:ReadOnlyListBase<EF_BarMarks,EF_BarMark>
    {
        #region Factory Methods

        public static EF_BarMarks Fetch()
        {
            return EF.DataPortal.Fetch<EF_BarMarks>();
        }

		public static EF_BarMarks Fetch(System.Linq.Expressions.Expression<Func<EF_BarMark, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_BarMark>(exp,values);
            return EF.DataPortal.Fetch<EF_BarMarks>(lambda);
		}

		public static EF_BarMarks Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_BarMarks>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_BarMarks Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_BarMark, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_BarMarks>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_BarMark>(exp,values)});
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
