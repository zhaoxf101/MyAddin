using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CG_TranOrder))]
#if Dev
    [RunLocal]
#endif

	public class CG_TranOrder:ReadOnlyBase<CG_TranOrder>
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

		
        public string OrderText
        {
            get ;
            set ;
        }

		
        public string OrderMemo
        {
            get ;
            set ;
        }

		
        public string OrderDate
        {
            get ;
            set ;
        }

		
        public DateTime OrderDateTime
        {
            get ;
            set ;
        }

		
        public decimal OrderAmt
        {
            get ;
            set ;
        }

		
        public string PayWayCode
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string ClientIP
        {
            get ;
            set ;
        }

		
        public string ClientInfo
        {
            get ;
            set ;
        }

		
        public string FeeType
        {
            get ;
            set ;
        }

		
        public string Tel
        {
            get ;
            set ;
        }

		
        public string Email
        {
            get ;
            set ;
        }

		
        public string Status
        {
            get ;
            set ;
        }

		
        public string SBillNo
        {
            get ;
            set ;
        }

		
        public string SBillType
        {
            get ;
            set ;
        }

		
        public bool IsDelete
        {
            get ;
            set ;
        }

		
        public Guid OldId
        {
            get ;
            set ;
        }

		
        public string OutTranNo
        {
            get ;
            set ;
        }

		
        public string OutDate
        {
            get ;
            set ;
        }

		
        public DateTime? SuccessDate
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public string TName
        {
            get ;
            set ;
        }

		
        public string PayUnit
        {
            get ;
            set ;
        }

		
        public string IdNo
        {
            get ;
            set ;
        }

		
        public Guid? FeeOrderId
        {
            get ;
            set ;
        }

		
        public string FeeOrderNo
        {
            get ;
            set ;
        }

		
        public string OutSign
        {
            get ;
            set ;
        }

		
        public bool IsVoice
        {
            get ;
            set ;
        }

		
        public bool IsOut
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CG_TranOrder Create()
        {
            return EF.DataPortal.Create<CG_TranOrder>();
        }

		public static CG_TranOrder Fetch(System.Linq.Expressions.Expression<Func<CG_TranOrder, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CG_TranOrder>(exp,values);
            return EF.DataPortal.Fetch<CG_TranOrder>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CG_TranOrders))]
#if Dev
    [RunLocal]
#endif
	
	public class CG_TranOrders:ReadOnlyListBase<CG_TranOrders,CG_TranOrder>
    {
        #region Factory Methods

        public static CG_TranOrders Fetch()
        {
            return EF.DataPortal.Fetch<CG_TranOrders>();
        }

		public static CG_TranOrders Fetch(System.Linq.Expressions.Expression<Func<CG_TranOrder, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CG_TranOrder>(exp,values);
            return EF.DataPortal.Fetch<CG_TranOrders>(lambda);
		}

		public static CG_TranOrders Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CG_TranOrders>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CG_TranOrders Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CG_TranOrder, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CG_TranOrders>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CG_TranOrder>(exp,values)});
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
