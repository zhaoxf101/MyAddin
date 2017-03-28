using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_Post))]
#if Dev
    [RunLocal]
#endif

	public class HR_Post:ReadOnlyBase<HR_Post>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PostCode
        {
            get ;
            set ;
        }

		
        public string PostName
        {
            get ;
            set ;
        }

		
        public string PostLevel
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_Post Create()
        {
            return EF.DataPortal.Create<HR_Post>();
        }

		public static HR_Post Fetch(System.Linq.Expressions.Expression<Func<HR_Post, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_Post>(exp,values);
            return EF.DataPortal.Fetch<HR_Post>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_Posts))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_Posts:ReadOnlyListBase<HR_Posts,HR_Post>
    {
        #region Factory Methods

        public static HR_Posts Fetch()
        {
            return EF.DataPortal.Fetch<HR_Posts>();
        }

		public static HR_Posts Fetch(System.Linq.Expressions.Expression<Func<HR_Post, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_Post>(exp,values);
            return EF.DataPortal.Fetch<HR_Posts>(lambda);
		}

		public static HR_Posts Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_Posts>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_Posts Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_Post, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_Posts>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_Post>(exp,values)});
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
