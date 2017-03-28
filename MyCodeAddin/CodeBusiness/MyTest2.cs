using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MyTest2))]
#if Dev
    [RunLocal]
#endif

	public class MyTest2:ReadOnlyBase<MyTest2>
    {
        #region Business Methods

		
        public int myKey
        {
            get ;
            set ;
        }

		
        public int? myValue
        {
            get ;
            set ;
        }

		
        public System.Data.Linq.Binary TS
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static MyTest2 Create()
        {
            return EF.DataPortal.Create<MyTest2>();
        }

		public static MyTest2 Fetch(System.Linq.Expressions.Expression<Func<MyTest2, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MyTest2>(exp,values);
            return EF.DataPortal.Fetch<MyTest2>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MyTest2s))]
#if Dev
    [RunLocal]
#endif
	
	public class MyTest2s:ReadOnlyListBase<MyTest2s,MyTest2>
    {
        #region Factory Methods

        public static MyTest2s Fetch()
        {
            return EF.DataPortal.Fetch<MyTest2s>();
        }

		public static MyTest2s Fetch(System.Linq.Expressions.Expression<Func<MyTest2, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MyTest2>(exp,values);
            return EF.DataPortal.Fetch<MyTest2s>(lambda);
		}

		public static MyTest2s Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MyTest2s>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MyTest2s Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MyTest2, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MyTest2s>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MyTest2>(exp,values)});
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
