using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusFund))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusFund:ReadOnlyBase<FI_ExpBusFund>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExpBusCode
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public decimal AdjAmt
        {
            get ;
            set ;
        }

		
        public decimal OrdAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpBusFund Create()
        {
            return EF.DataPortal.Create<FI_ExpBusFund>();
        }

		public static FI_ExpBusFund Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusFund, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusFund>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusFund>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusFunds))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusFunds:ReadOnlyListBase<FI_ExpBusFunds,FI_ExpBusFund>
    {
        #region Factory Methods

        public static FI_ExpBusFunds Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusFunds>();
        }

		public static FI_ExpBusFunds Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusFund, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusFund>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusFunds>(lambda);
		}

		public static FI_ExpBusFunds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusFunds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusFunds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusFund, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusFunds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusFund>(exp,values)});
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
