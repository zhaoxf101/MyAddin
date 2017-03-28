using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_Bill))]
#if Dev
    [RunLocal]
#endif

	public class FE_Bill:ReadOnlyBase<FE_Bill>
    {
        #region Business Methods

		
        public int Bill_Id
        {
            get ;
            set ;
        }

		
        public string TradeTime
        {
            get ;
            set ;
        }

		
        public string AppId
        {
            get ;
            set ;
        }

		
        public string Mch_Id
        {
            get ;
            set ;
        }

		
        public string Sub_Mch_Id
        {
            get ;
            set ;
        }

		
        public string Device_Info
        {
            get ;
            set ;
        }

		
        public string Transaction_Id
        {
            get ;
            set ;
        }

		
        public string Out_Trade_No
        {
            get ;
            set ;
        }

		
        public string OpenId
        {
            get ;
            set ;
        }

		
        public string Trade_Type
        {
            get ;
            set ;
        }

		
        public string TradeStatus
        {
            get ;
            set ;
        }

		
        public string Bank
        {
            get ;
            set ;
        }

		
        public string Fee_Type
        {
            get ;
            set ;
        }

		
        public decimal? Total_Fee
        {
            get ;
            set ;
        }

		
        public decimal? RedPacketMoney
        {
            get ;
            set ;
        }

		
        public string WX_Refund_No
        {
            get ;
            set ;
        }

		
        public string SH_Refund_No
        {
            get ;
            set ;
        }

		
        public decimal? RefundMoney
        {
            get ;
            set ;
        }

		
        public decimal? RedPacketRefund
        {
            get ;
            set ;
        }

		
        public string RefundType
        {
            get ;
            set ;
        }

		
        public string RefundStatus
        {
            get ;
            set ;
        }

		
        public string Body
        {
            get ;
            set ;
        }

		
        public string Attach
        {
            get ;
            set ;
        }

		
        public decimal? Fee
        {
            get ;
            set ;
        }

		
        public decimal? Fee_Rate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_Bill Create()
        {
            return EF.DataPortal.Create<FE_Bill>();
        }

		public static FE_Bill Fetch(System.Linq.Expressions.Expression<Func<FE_Bill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_Bill>(exp,values);
            return EF.DataPortal.Fetch<FE_Bill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_Bills))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_Bills:ReadOnlyListBase<FE_Bills,FE_Bill>
    {
        #region Factory Methods

        public static FE_Bills Fetch()
        {
            return EF.DataPortal.Fetch<FE_Bills>();
        }

		public static FE_Bills Fetch(System.Linq.Expressions.Expression<Func<FE_Bill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_Bill>(exp,values);
            return EF.DataPortal.Fetch<FE_Bills>(lambda);
		}

		public static FE_Bills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_Bills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_Bills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_Bill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_Bills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_Bill>(exp,values)});
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
