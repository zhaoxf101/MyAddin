using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(ztf))]
#if Dev
    [RunLocal]
#endif

	public class ztf:ReadOnlyBase<ztf>
    {
        #region Business Methods

		
        public string y
        {
            get ;
            set ;
        }

		
        public string pcode
        {
            get ;
            set ;
        }

		
        public string tcode
        {
            get ;
            set ;
        }

		
        public string fcode
        {
            get ;
            set ;
        }

		
        public decimal? bamt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static ztf Create()
        {
            return EF.DataPortal.Create<ztf>();
        }

		public static ztf Fetch(System.Linq.Expressions.Expression<Func<ztf, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<ztf>(exp,values);
            return EF.DataPortal.Fetch<ztf>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(ztfs))]
#if Dev
    [RunLocal]
#endif
	
	public class ztfs:ReadOnlyListBase<ztfs,ztf>
    {
        #region Factory Methods

        public static ztfs Fetch()
        {
            return EF.DataPortal.Fetch<ztfs>();
        }

		public static ztfs Fetch(System.Linq.Expressions.Expression<Func<ztf, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<ztf>(exp,values);
            return EF.DataPortal.Fetch<ztfs>(lambda);
		}

		public static ztfs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<ztfs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static ztfs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<ztf, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<ztfs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<ztf>(exp,values)});
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
