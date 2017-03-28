using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_Transaction))]
#if Dev
    [RunLocal]
#endif

	public class UP_Transaction:ReadOnlyBase<UP_Transaction>
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

		
        public string TradeDate
        {
            get ;
            set ;
        }

		
        public string TradeNo
        {
            get ;
            set ;
        }

		
        public string BookDate
        {
            get ;
            set ;
        }

		
        public Guid OrderId
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

		
        public Guid AccountId
        {
            get ;
            set ;
        }

		
        public string AccountNo
        {
            get ;
            set ;
        }

		
        public string UserCode
        {
            get ;
            set ;
        }

		
        public string TradeTitle
        {
            get ;
            set ;
        }

		
        public decimal Balance
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

		
        public bool DeCrX
        {
            get ;
            set ;
        }

		
        public string Remark
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

		public static UP_Transaction Create()
        {
            return EF.DataPortal.Create<UP_Transaction>();
        }

		public static UP_Transaction Fetch(System.Linq.Expressions.Expression<Func<UP_Transaction, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_Transaction>(exp,values);
            return EF.DataPortal.Fetch<UP_Transaction>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_Transactions))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_Transactions:ReadOnlyListBase<UP_Transactions,UP_Transaction>
    {
        #region Factory Methods

        public static UP_Transactions Fetch()
        {
            return EF.DataPortal.Fetch<UP_Transactions>();
        }

		public static UP_Transactions Fetch(System.Linq.Expressions.Expression<Func<UP_Transaction, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_Transaction>(exp,values);
            return EF.DataPortal.Fetch<UP_Transactions>(lambda);
		}

		public static UP_Transactions Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_Transactions>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_Transactions Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_Transaction, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_Transactions>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_Transaction>(exp,values)});
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
