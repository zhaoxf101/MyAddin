using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_FeeReduce))]
#if Dev
    [RunLocal]
#endif

	public class SM_FeeReduce:ReadOnlyBase<SM_FeeReduce>
    {
        #region Business Methods

		
        public string ReduceCode
        {
            get ;
            set ;
        }

		
        public string ReduceName
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_FeeReduce Create()
        {
            return EF.DataPortal.Create<SM_FeeReduce>();
        }

		public static SM_FeeReduce Fetch(System.Linq.Expressions.Expression<Func<SM_FeeReduce, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_FeeReduce>(exp,values);
            return EF.DataPortal.Fetch<SM_FeeReduce>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_FeeReduces))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_FeeReduces:ReadOnlyListBase<SM_FeeReduces,SM_FeeReduce>
    {
        #region Factory Methods

        public static SM_FeeReduces Fetch()
        {
            return EF.DataPortal.Fetch<SM_FeeReduces>();
        }

		public static SM_FeeReduces Fetch(System.Linq.Expressions.Expression<Func<SM_FeeReduce, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_FeeReduce>(exp,values);
            return EF.DataPortal.Fetch<SM_FeeReduces>(lambda);
		}

		public static SM_FeeReduces Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_FeeReduces>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_FeeReduces Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_FeeReduce, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_FeeReduces>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_FeeReduce>(exp,values)});
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
