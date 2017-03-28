using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_Degree))]
#if Dev
    [RunLocal]
#endif

	public class SM_Degree:ReadOnlyBase<SM_Degree>
    {
        #region Business Methods

		
        public string DegreeCode
        {
            get ;
            set ;
        }

		
        public string DegreeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_Degree Create()
        {
            return EF.DataPortal.Create<SM_Degree>();
        }

		public static SM_Degree Fetch(System.Linq.Expressions.Expression<Func<SM_Degree, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_Degree>(exp,values);
            return EF.DataPortal.Fetch<SM_Degree>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_Degrees))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_Degrees:ReadOnlyListBase<SM_Degrees,SM_Degree>
    {
        #region Factory Methods

        public static SM_Degrees Fetch()
        {
            return EF.DataPortal.Fetch<SM_Degrees>();
        }

		public static SM_Degrees Fetch(System.Linq.Expressions.Expression<Func<SM_Degree, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_Degree>(exp,values);
            return EF.DataPortal.Fetch<SM_Degrees>(lambda);
		}

		public static SM_Degrees Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_Degrees>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_Degrees Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_Degree, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_Degrees>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_Degree>(exp,values)});
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
