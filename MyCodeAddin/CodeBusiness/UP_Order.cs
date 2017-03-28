using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_Order))]
#if Dev
    [RunLocal]
#endif

	public class UP_Order:ReadOnlyBase<UP_Order>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string OrderNo
        {
            get ;
            set ;
        }

		
        public string OrderDate
        {
            get ;
            set ;
        }

		
        public string OrderTitle
        {
            get ;
            set ;
        }

		
        public string RequestId
        {
            get ;
            set ;
        }

		
        public string TradeTypeCode
        {
            get ;
            set ;
        }

		
        public string ChargeWayCode
        {
            get ;
            set ;
        }

		
        public string PUserCode
        {
            get ;
            set ;
        }

		
        public string PAccountNo
        {
            get ;
            set ;
        }

		
        public Guid PAccountId
        {
            get ;
            set ;
        }

		
        public string RUserCode
        {
            get ;
            set ;
        }

		
        public string RAccountNo
        {
            get ;
            set ;
        }

		
        public Guid RAccountId
        {
            get ;
            set ;
        }

		
        public decimal TradeAmt
        {
            get ;
            set ;
        }

		
        public decimal TradeActAmt
        {
            get ;
            set ;
        }

		
        public string OrderStatus
        {
            get ;
            set ;
        }

		
        public string ApiArgs
        {
            get ;
            set ;
        }

		
        public string ApiStatus
        {
            get ;
            set ;
        }

		
        public Guid MerchantId
        {
            get ;
            set ;
        }

		
        public Guid ShopId
        {
            get ;
            set ;
        }

		
        public Guid PosId
        {
            get ;
            set ;
        }

		
        public string ShopOperator
        {
            get ;
            set ;
        }

		
        public string BarCode
        {
            get ;
            set ;
        }

		
        public string PhoneMac
        {
            get ;
            set ;
        }

		
        public string Remark
        {
            get ;
            set ;
        }

		
        public string OutOrderNo
        {
            get ;
            set ;
        }

		
        public string TradeNo
        {
            get ;
            set ;
        }

		
        public string TradeDate
        {
            get ;
            set ;
        }

		
        public string OffsetNo
        {
            get ;
            set ;
        }

		
        public string OffsetDate
        {
            get ;
            set ;
        }

		
        public string OffsetMark
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
        public string ChangeUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangeDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static UP_Order Create()
        {
            return EF.DataPortal.Create<UP_Order>();
        }

		public static UP_Order Fetch(System.Linq.Expressions.Expression<Func<UP_Order, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_Order>(exp,values);
            return EF.DataPortal.Fetch<UP_Order>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_Orders))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_Orders:ReadOnlyListBase<UP_Orders,UP_Order>
    {
        #region Factory Methods

        public static UP_Orders Fetch()
        {
            return EF.DataPortal.Fetch<UP_Orders>();
        }

		public static UP_Orders Fetch(System.Linq.Expressions.Expression<Func<UP_Order, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_Order>(exp,values);
            return EF.DataPortal.Fetch<UP_Orders>(lambda);
		}

		public static UP_Orders Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_Orders>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_Orders Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_Order, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_Orders>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_Order>(exp,values)});
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
