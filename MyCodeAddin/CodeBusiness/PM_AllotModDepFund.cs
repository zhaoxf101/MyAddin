using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_AllotModDepFund))]
#if Dev
    [RunLocal]
#endif

	public class PM_AllotModDepFund:ReadOnlyBase<PM_AllotModDepFund>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AllotModCode
        {
            get ;
            set ;
        }

		
        public string AllotItemCode
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_AllotModDepFund Create()
        {
            return EF.DataPortal.Create<PM_AllotModDepFund>();
        }

		public static PM_AllotModDepFund Fetch(System.Linq.Expressions.Expression<Func<PM_AllotModDepFund, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotModDepFund>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotModDepFund>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_AllotModDepFunds))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_AllotModDepFunds:ReadOnlyListBase<PM_AllotModDepFunds,PM_AllotModDepFund>
    {
        #region Factory Methods

        public static PM_AllotModDepFunds Fetch()
        {
            return EF.DataPortal.Fetch<PM_AllotModDepFunds>();
        }

		public static PM_AllotModDepFunds Fetch(System.Linq.Expressions.Expression<Func<PM_AllotModDepFund, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotModDepFund>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotModDepFunds>(lambda);
		}

		public static PM_AllotModDepFunds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_AllotModDepFunds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_AllotModDepFunds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_AllotModDepFund, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_AllotModDepFunds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_AllotModDepFund>(exp,values)});
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
