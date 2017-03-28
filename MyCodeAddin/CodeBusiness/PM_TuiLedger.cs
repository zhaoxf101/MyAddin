using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_TuiLedger))]
#if Dev
    [RunLocal]
#endif

	public class PM_TuiLedger:ReadOnlyBase<PM_TuiLedger>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string ClassCode
        {
            get ;
            set ;
        }

		
        public decimal LAmt
        {
            get ;
            set ;
        }

		
        public decimal UAmt
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

		
		#endregion

		#region Factory Methods

		public static PM_TuiLedger Create()
        {
            return EF.DataPortal.Create<PM_TuiLedger>();
        }

		public static PM_TuiLedger Fetch(System.Linq.Expressions.Expression<Func<PM_TuiLedger, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_TuiLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_TuiLedger>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_TuiLedgers))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_TuiLedgers:ReadOnlyListBase<PM_TuiLedgers,PM_TuiLedger>
    {
        #region Factory Methods

        public static PM_TuiLedgers Fetch()
        {
            return EF.DataPortal.Fetch<PM_TuiLedgers>();
        }

		public static PM_TuiLedgers Fetch(System.Linq.Expressions.Expression<Func<PM_TuiLedger, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_TuiLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_TuiLedgers>(lambda);
		}

		public static PM_TuiLedgers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_TuiLedgers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_TuiLedgers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_TuiLedger, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_TuiLedgers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_TuiLedger>(exp,values)});
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
