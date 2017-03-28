using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MM_PurchaseGrp))]
#if Dev
    [RunLocal]
#endif

	public class MM_PurchaseGrp:ReadOnlyBase<MM_PurchaseGrp>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PurchaseGrp
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

		public static MM_PurchaseGrp Create()
        {
            return EF.DataPortal.Create<MM_PurchaseGrp>();
        }

		public static MM_PurchaseGrp Fetch(System.Linq.Expressions.Expression<Func<MM_PurchaseGrp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MM_PurchaseGrp>(exp,values);
            return EF.DataPortal.Fetch<MM_PurchaseGrp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MM_PurchaseGrps))]
#if Dev
    [RunLocal]
#endif
	
	public class MM_PurchaseGrps:ReadOnlyListBase<MM_PurchaseGrps,MM_PurchaseGrp>
    {
        #region Factory Methods

        public static MM_PurchaseGrps Fetch()
        {
            return EF.DataPortal.Fetch<MM_PurchaseGrps>();
        }

		public static MM_PurchaseGrps Fetch(System.Linq.Expressions.Expression<Func<MM_PurchaseGrp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MM_PurchaseGrp>(exp,values);
            return EF.DataPortal.Fetch<MM_PurchaseGrps>(lambda);
		}

		public static MM_PurchaseGrps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MM_PurchaseGrps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MM_PurchaseGrps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MM_PurchaseGrp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MM_PurchaseGrps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MM_PurchaseGrp>(exp,values)});
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
