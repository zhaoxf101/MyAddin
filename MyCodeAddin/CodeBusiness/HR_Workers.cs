using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_Workers))]
#if Dev
    [RunLocal]
#endif

	public class HR_Workers:ReadOnlyBase<HR_Workers>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string WorkersCode
        {
            get ;
            set ;
        }

		
        public string WorkersName
        {
            get ;
            set ;
        }

		
        public string WorkersLevel
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_Workers Create()
        {
            return EF.DataPortal.Create<HR_Workers>();
        }

		public static HR_Workers Fetch(System.Linq.Expressions.Expression<Func<HR_Workers, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_Workers>(exp,values);
            return EF.DataPortal.Fetch<HR_Workers>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_Workerss))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_Workerss:ReadOnlyListBase<HR_Workerss,HR_Workers>
    {
        #region Factory Methods

        public static HR_Workerss Fetch()
        {
            return EF.DataPortal.Fetch<HR_Workerss>();
        }

		public static HR_Workerss Fetch(System.Linq.Expressions.Expression<Func<HR_Workers, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_Workers>(exp,values);
            return EF.DataPortal.Fetch<HR_Workerss>(lambda);
		}

		public static HR_Workerss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_Workerss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_Workerss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_Workers, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_Workerss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_Workers>(exp,values)});
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
