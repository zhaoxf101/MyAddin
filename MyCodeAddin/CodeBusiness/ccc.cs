using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(ccc))]
#if Dev
    [RunLocal]
#endif

	public class ccc:ReadOnlyBase<ccc>
    {
        #region Business Methods

		
        public string PK1
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static ccc Create()
        {
            return EF.DataPortal.Create<ccc>();
        }

		public static ccc Fetch(System.Linq.Expressions.Expression<Func<ccc, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<ccc>(exp,values);
            return EF.DataPortal.Fetch<ccc>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(cccs))]
#if Dev
    [RunLocal]
#endif
	
	public class cccs:ReadOnlyListBase<cccs,ccc>
    {
        #region Factory Methods

        public static cccs Fetch()
        {
            return EF.DataPortal.Fetch<cccs>();
        }

		public static cccs Fetch(System.Linq.Expressions.Expression<Func<ccc, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<ccc>(exp,values);
            return EF.DataPortal.Fetch<cccs>(lambda);
		}

		public static cccs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<cccs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static cccs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<ccc, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<cccs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<ccc>(exp,values)});
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
