using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(zz2))]
#if Dev
    [RunLocal]
#endif

	public class zz2:ReadOnlyBase<zz2>
    {
        #region Business Methods

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public float? TaskCode
        {
            get ;
            set ;
        }

		
        public float? FundCode
        {
            get ;
            set ;
        }

		
        public string PBudExpFunCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static zz2 Create()
        {
            return EF.DataPortal.Create<zz2>();
        }

		public static zz2 Fetch(System.Linq.Expressions.Expression<Func<zz2, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<zz2>(exp,values);
            return EF.DataPortal.Fetch<zz2>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(zz2s))]
#if Dev
    [RunLocal]
#endif
	
	public class zz2s:ReadOnlyListBase<zz2s,zz2>
    {
        #region Factory Methods

        public static zz2s Fetch()
        {
            return EF.DataPortal.Fetch<zz2s>();
        }

		public static zz2s Fetch(System.Linq.Expressions.Expression<Func<zz2, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<zz2>(exp,values);
            return EF.DataPortal.Fetch<zz2s>(lambda);
		}

		public static zz2s Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<zz2s>(new Paging { Page=page,RowCount=rowCount});
        }

        public static zz2s Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<zz2, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<zz2s>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<zz2>(exp,values)});
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
