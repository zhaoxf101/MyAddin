using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_TuitionBill))]
#if Dev
    [RunLocal]
#endif

	public class SM_TuitionBill:ReadOnlyBase<SM_TuitionBill>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string iDealNo
        {
            get ;
            set ;
        }

		
        public string vPayWayCode
        {
            get ;
            set ;
        }

		
        public string cYear
        {
            get ;
            set ;
        }

		
        public string vFeeItemCode
        {
            get ;
            set ;
        }

		
        public decimal nBankAmout
        {
            get ;
            set ;
        }

		
        public decimal nCashAmount
        {
            get ;
            set ;
        }

		
        public decimal nAmount
        {
            get ;
            set ;
        }

		
        public string vCurrName
        {
            get ;
            set ;
        }

		
        public decimal nExchangeRate
        {
            get ;
            set ;
        }

		
        public decimal nForeignCurrency
        {
            get ;
            set ;
        }

		
        public decimal nPayable
        {
            get ;
            set ;
        }

		
        public decimal nPayableChange
        {
            get ;
            set ;
        }

		
        public decimal nPaid
        {
            get ;
            set ;
        }

		
        public decimal nowe
        {
            get ;
            set ;
        }

		
        public string vBillTypeCode
        {
            get ;
            set ;
        }

		
        public decimal? nBillAmount
        {
            get ;
            set ;
        }

		
        public bool? bPrint
        {
            get ;
            set ;
        }

		
        public string vTuitionBillPrintOrder
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_TuitionBill Create()
        {
            return EF.DataPortal.Create<SM_TuitionBill>();
        }

		public static SM_TuitionBill Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionBill>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_TuitionBills))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_TuitionBills:ReadOnlyListBase<SM_TuitionBills,SM_TuitionBill>
    {
        #region Factory Methods

        public static SM_TuitionBills Fetch()
        {
            return EF.DataPortal.Fetch<SM_TuitionBills>();
        }

		public static SM_TuitionBills Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionBill>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionBills>(lambda);
		}

		public static SM_TuitionBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_TuitionBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_TuitionBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_TuitionBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_TuitionBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_TuitionBill>(exp,values)});
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
