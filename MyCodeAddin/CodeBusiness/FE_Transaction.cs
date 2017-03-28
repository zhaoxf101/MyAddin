using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_Transaction))]
#if Dev
    [RunLocal]
#endif

	public class FE_Transaction:ReadOnlyBase<FE_Transaction>
    {
        #region Business Methods

		
        public string Out_Trade_No
        {
            get ;
            set ;
        }

		
        public string Mch_Id
        {
            get ;
            set ;
        }

		
        public string AppId
        {
            get ;
            set ;
        }

		
        public string Device_Info
        {
            get ;
            set ;
        }

		
        public string Nonce_Str
        {
            get ;
            set ;
        }

		
        public string Sign
        {
            get ;
            set ;
        }

		
        public string Body
        {
            get ;
            set ;
        }

		
        public string Detail
        {
            get ;
            set ;
        }

		
        public string Attach
        {
            get ;
            set ;
        }

		
        public string Fee_Type
        {
            get ;
            set ;
        }

		
        public decimal Total_Fee
        {
            get ;
            set ;
        }

		
        public string Spbill_Create_IP
        {
            get ;
            set ;
        }

		
        public string Time_Start
        {
            get ;
            set ;
        }

		
        public string Time_Expire
        {
            get ;
            set ;
        }

		
        public string Goods_Tag
        {
            get ;
            set ;
        }

		
        public string Trade_Type
        {
            get ;
            set ;
        }

		
        public string Product_Id
        {
            get ;
            set ;
        }

		
        public string Limit_Pay
        {
            get ;
            set ;
        }

		
        public string OpenId
        {
            get ;
            set ;
        }

		
        public string SignType
        {
            get ;
            set ;
        }

		
        public string PaySign
        {
            get ;
            set ;
        }

		
        public string Package
        {
            get ;
            set ;
        }

		
        public string Transaction_Id
        {
            get ;
            set ;
        }

		
        public DateTime? NotifyTime
        {
            get ;
            set ;
        }

		
        public DateTime? End_Time
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string BName
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string TransactionState
        {
            get ;
            set ;
        }

		
        public string BillState
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_Transaction Create()
        {
            return EF.DataPortal.Create<FE_Transaction>();
        }

		public static FE_Transaction Fetch(System.Linq.Expressions.Expression<Func<FE_Transaction, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_Transaction>(exp,values);
            return EF.DataPortal.Fetch<FE_Transaction>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_Transactions))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_Transactions:ReadOnlyListBase<FE_Transactions,FE_Transaction>
    {
        #region Factory Methods

        public static FE_Transactions Fetch()
        {
            return EF.DataPortal.Fetch<FE_Transactions>();
        }

		public static FE_Transactions Fetch(System.Linq.Expressions.Expression<Func<FE_Transaction, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_Transaction>(exp,values);
            return EF.DataPortal.Fetch<FE_Transactions>(lambda);
		}

		public static FE_Transactions Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_Transactions>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_Transactions Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_Transaction, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_Transactions>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_Transaction>(exp,values)});
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
