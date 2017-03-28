using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MM_SalesGrp))]
#if Dev
    [RunLocal]
#endif

	public class MM_SalesGrp:ReadOnlyBase<MM_SalesGrp>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string VKORG
        {
            get ;
            set ;
        }

		
        public string SText
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static MM_SalesGrp Create()
        {
            return EF.DataPortal.Create<MM_SalesGrp>();
        }

		public static MM_SalesGrp Fetch(System.Linq.Expressions.Expression<Func<MM_SalesGrp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MM_SalesGrp>(exp,values);
            return EF.DataPortal.Fetch<MM_SalesGrp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MM_SalesGrps))]
#if Dev
    [RunLocal]
#endif
	
	public class MM_SalesGrps:ReadOnlyListBase<MM_SalesGrps,MM_SalesGrp>
    {
        #region Factory Methods

        public static MM_SalesGrps Fetch()
        {
            return EF.DataPortal.Fetch<MM_SalesGrps>();
        }

		public static MM_SalesGrps Fetch(System.Linq.Expressions.Expression<Func<MM_SalesGrp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MM_SalesGrp>(exp,values);
            return EF.DataPortal.Fetch<MM_SalesGrps>(lambda);
		}

		public static MM_SalesGrps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MM_SalesGrps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MM_SalesGrps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MM_SalesGrp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MM_SalesGrps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MM_SalesGrp>(exp,values)});
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
