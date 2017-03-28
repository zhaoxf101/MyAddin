using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_WoffProjFund))]
#if Dev
    [RunLocal]
#endif

	public class PM_WoffProjFund:ReadOnlyBase<PM_WoffProjFund>
    {
        #region Business Methods

		
        public string WoffCode
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public decimal? WoffAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_WoffProjFund Create()
        {
            return EF.DataPortal.Create<PM_WoffProjFund>();
        }

		public static PM_WoffProjFund Fetch(System.Linq.Expressions.Expression<Func<PM_WoffProjFund, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_WoffProjFund>(exp,values);
            return EF.DataPortal.Fetch<PM_WoffProjFund>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_WoffProjFunds))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_WoffProjFunds:ReadOnlyListBase<PM_WoffProjFunds,PM_WoffProjFund>
    {
        #region Factory Methods

        public static PM_WoffProjFunds Fetch()
        {
            return EF.DataPortal.Fetch<PM_WoffProjFunds>();
        }

		public static PM_WoffProjFunds Fetch(System.Linq.Expressions.Expression<Func<PM_WoffProjFund, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_WoffProjFund>(exp,values);
            return EF.DataPortal.Fetch<PM_WoffProjFunds>(lambda);
		}

		public static PM_WoffProjFunds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_WoffProjFunds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_WoffProjFunds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_WoffProjFund, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_WoffProjFunds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_WoffProjFund>(exp,values)});
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
