using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_AllotAppFund))]
#if Dev
    [RunLocal]
#endif

	public class PM_AllotAppFund:ReadOnlyBase<PM_AllotAppFund>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AllotAppNo
        {
            get ;
            set ;
        }

		
        public string TaskCode
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

		
        public decimal FDAmt
        {
            get ;
            set ;
        }

		
        public decimal AppAmt
        {
            get ;
            set ;
        }

		
        public string CAccCode
        {
            get ;
            set ;
        }

		
        public string DAccCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_AllotAppFund Create()
        {
            return EF.DataPortal.Create<PM_AllotAppFund>();
        }

		public static PM_AllotAppFund Fetch(System.Linq.Expressions.Expression<Func<PM_AllotAppFund, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotAppFund>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotAppFund>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_AllotAppFunds))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_AllotAppFunds:ReadOnlyListBase<PM_AllotAppFunds,PM_AllotAppFund>
    {
        #region Factory Methods

        public static PM_AllotAppFunds Fetch()
        {
            return EF.DataPortal.Fetch<PM_AllotAppFunds>();
        }

		public static PM_AllotAppFunds Fetch(System.Linq.Expressions.Expression<Func<PM_AllotAppFund, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotAppFund>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotAppFunds>(lambda);
		}

		public static PM_AllotAppFunds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_AllotAppFunds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_AllotAppFunds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_AllotAppFund, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_AllotAppFunds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_AllotAppFund>(exp,values)});
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
