using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_FeeOrder))]
#if Dev
    [RunLocal]
#endif

	public class FE_FeeOrder:ReadOnlyBase<FE_FeeOrder>
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

		
        public string OrderType
        {
            get ;
            set ;
        }

		
        public DateTime StartDate
        {
            get ;
            set ;
        }

		
        public DateTime EndDate
        {
            get ;
            set ;
        }

		
        public string OrderText
        {
            get ;
            set ;
        }

		
        public string UserGroup
        {
            get ;
            set ;
        }

		
        public string Status
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public string DepartCode
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public decimal? OrderAmt
        {
            get ;
            set ;
        }

		
        public decimal? InAmt
        {
            get ;
            set ;
        }

		
        public decimal? CAmt
        {
            get ;
            set ;
        }

		
        public bool IsBatch
        {
            get ;
            set ;
        }

		
        public bool? IsIdentity
        {
            get ;
            set ;
        }

		
        public string FeeItemCode
        {
            get ;
            set ;
        }

		
        public string ProfitCtrType
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_FeeOrder Create()
        {
            return EF.DataPortal.Create<FE_FeeOrder>();
        }

		public static FE_FeeOrder Fetch(System.Linq.Expressions.Expression<Func<FE_FeeOrder, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_FeeOrder>(exp,values);
            return EF.DataPortal.Fetch<FE_FeeOrder>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_FeeOrders))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_FeeOrders:ReadOnlyListBase<FE_FeeOrders,FE_FeeOrder>
    {
        #region Factory Methods

        public static FE_FeeOrders Fetch()
        {
            return EF.DataPortal.Fetch<FE_FeeOrders>();
        }

		public static FE_FeeOrders Fetch(System.Linq.Expressions.Expression<Func<FE_FeeOrder, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_FeeOrder>(exp,values);
            return EF.DataPortal.Fetch<FE_FeeOrders>(lambda);
		}

		public static FE_FeeOrders Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_FeeOrders>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_FeeOrders Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_FeeOrder, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_FeeOrders>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_FeeOrder>(exp,values)});
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
