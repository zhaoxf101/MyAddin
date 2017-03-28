using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CG_Order))]
#if Dev
    [RunLocal]
#endif

	public class CG_Order:ReadOnlyBase<CG_Order>
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

		
        public string BillNo
        {
            get ;
            set ;
        }

		
        public string IntervalCode
        {
            get ;
            set ;
        }

		
        public string FeeItemCode
        {
            get ;
            set ;
        }

		
        public string BillText
        {
            get ;
            set ;
        }

		
        public string SText
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string UserGroup
        {
            get ;
            set ;
        }

		
        public string StartDate
        {
            get ;
            set ;
        }

		
        public string EndDate
        {
            get ;
            set ;
        }

		
        public bool IsSub
        {
            get ;
            set ;
        }

		
        public bool IsSpecAmt
        {
            get ;
            set ;
        }

		
        public bool IsOnce
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

		
        public decimal OrderAmt
        {
            get ;
            set ;
        }

		
        public decimal CAmt
        {
            get ;
            set ;
        }

		
        public decimal AdjAmt
        {
            get ;
            set ;
        }

		
        public bool IsClose
        {
            get ;
            set ;
        }

		
        public string DepCode
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

		public static CG_Order Create()
        {
            return EF.DataPortal.Create<CG_Order>();
        }

		public static CG_Order Fetch(System.Linq.Expressions.Expression<Func<CG_Order, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CG_Order>(exp,values);
            return EF.DataPortal.Fetch<CG_Order>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CG_Orders))]
#if Dev
    [RunLocal]
#endif
	
	public class CG_Orders:ReadOnlyListBase<CG_Orders,CG_Order>
    {
        #region Factory Methods

        public static CG_Orders Fetch()
        {
            return EF.DataPortal.Fetch<CG_Orders>();
        }

		public static CG_Orders Fetch(System.Linq.Expressions.Expression<Func<CG_Order, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CG_Order>(exp,values);
            return EF.DataPortal.Fetch<CG_Orders>(lambda);
		}

		public static CG_Orders Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CG_Orders>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CG_Orders Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CG_Order, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CG_Orders>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CG_Order>(exp,values)});
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
