using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpItemRes))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpItemRes:ReadOnlyBase<FI_ExpItemRes>
    {
        #region Business Methods

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public string ResRow
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpItemRes Create()
        {
            return EF.DataPortal.Create<FI_ExpItemRes>();
        }

		public static FI_ExpItemRes Fetch(System.Linq.Expressions.Expression<Func<FI_ExpItemRes, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpItemRes>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpItemRes>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpItemRess))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpItemRess:ReadOnlyListBase<FI_ExpItemRess,FI_ExpItemRes>
    {
        #region Factory Methods

        public static FI_ExpItemRess Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpItemRess>();
        }

		public static FI_ExpItemRess Fetch(System.Linq.Expressions.Expression<Func<FI_ExpItemRes, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpItemRes>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpItemRess>(lambda);
		}

		public static FI_ExpItemRess Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpItemRess>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpItemRess Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpItemRes, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpItemRess>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpItemRes>(exp,values)});
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
