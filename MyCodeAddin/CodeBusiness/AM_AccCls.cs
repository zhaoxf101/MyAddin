using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(AM_AccCls))]
#if Dev
    [RunLocal]
#endif

	public class AM_AccCls:ReadOnlyBase<AM_AccCls>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AccCls
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string AccGroup
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static AM_AccCls Create()
        {
            return EF.DataPortal.Create<AM_AccCls>();
        }

		public static AM_AccCls Fetch(System.Linq.Expressions.Expression<Func<AM_AccCls, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<AM_AccCls>(exp,values);
            return EF.DataPortal.Fetch<AM_AccCls>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(AM_AccClss))]
#if Dev
    [RunLocal]
#endif
	
	public class AM_AccClss:ReadOnlyListBase<AM_AccClss,AM_AccCls>
    {
        #region Factory Methods

        public static AM_AccClss Fetch()
        {
            return EF.DataPortal.Fetch<AM_AccClss>();
        }

		public static AM_AccClss Fetch(System.Linq.Expressions.Expression<Func<AM_AccCls, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<AM_AccCls>(exp,values);
            return EF.DataPortal.Fetch<AM_AccClss>(lambda);
		}

		public static AM_AccClss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<AM_AccClss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static AM_AccClss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<AM_AccCls, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<AM_AccClss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<AM_AccCls>(exp,values)});
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
