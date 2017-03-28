using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_IMSOrder))]
#if Dev
    [RunLocal]
#endif

	public class UP_IMSOrder:ReadOnlyBase<UP_IMSOrder>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string OrderNo
        {
            get ;
            set ;
        }

		
        public string xiaoqu_id
        {
            get ;
            set ;
        }

		
        public int room_id
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static UP_IMSOrder Create()
        {
            return EF.DataPortal.Create<UP_IMSOrder>();
        }

		public static UP_IMSOrder Fetch(System.Linq.Expressions.Expression<Func<UP_IMSOrder, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_IMSOrder>(exp,values);
            return EF.DataPortal.Fetch<UP_IMSOrder>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_IMSOrders))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_IMSOrders:ReadOnlyListBase<UP_IMSOrders,UP_IMSOrder>
    {
        #region Factory Methods

        public static UP_IMSOrders Fetch()
        {
            return EF.DataPortal.Fetch<UP_IMSOrders>();
        }

		public static UP_IMSOrders Fetch(System.Linq.Expressions.Expression<Func<UP_IMSOrder, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_IMSOrder>(exp,values);
            return EF.DataPortal.Fetch<UP_IMSOrders>(lambda);
		}

		public static UP_IMSOrders Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_IMSOrders>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_IMSOrders Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_IMSOrder, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_IMSOrders>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_IMSOrder>(exp,values)});
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
