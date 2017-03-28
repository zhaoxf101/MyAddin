using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(TM_ExperCate))]
#if Dev
    [RunLocal]
#endif

	public class TM_ExperCate:ReadOnlyBase<TM_ExperCate>
    {
        #region Business Methods

		
        public string ExperCateCode
        {
            get ;
            set ;
        }

		
        public string ExperCateName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static TM_ExperCate Create()
        {
            return EF.DataPortal.Create<TM_ExperCate>();
        }

		public static TM_ExperCate Fetch(System.Linq.Expressions.Expression<Func<TM_ExperCate, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<TM_ExperCate>(exp,values);
            return EF.DataPortal.Fetch<TM_ExperCate>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(TM_ExperCates))]
#if Dev
    [RunLocal]
#endif
	
	public class TM_ExperCates:ReadOnlyListBase<TM_ExperCates,TM_ExperCate>
    {
        #region Factory Methods

        public static TM_ExperCates Fetch()
        {
            return EF.DataPortal.Fetch<TM_ExperCates>();
        }

		public static TM_ExperCates Fetch(System.Linq.Expressions.Expression<Func<TM_ExperCate, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<TM_ExperCate>(exp,values);
            return EF.DataPortal.Fetch<TM_ExperCates>(lambda);
		}

		public static TM_ExperCates Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<TM_ExperCates>(new Paging { Page=page,RowCount=rowCount});
        }

        public static TM_ExperCates Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<TM_ExperCate, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<TM_ExperCates>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<TM_ExperCate>(exp,values)});
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
