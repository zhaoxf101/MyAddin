using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ExpItemFundLedger))]
#if Dev
    [RunLocal]
#endif

	public class PM_ExpItemFundLedger:ReadOnlyBase<PM_ExpItemFundLedger>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string Year
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

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public string ExpItemRow
        {
            get ;
            set ;
        }

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
        public decimal LRAmt
        {
            get ;
            set ;
        }

		
        public decimal BudAmt
        {
            get ;
            set ;
        }

		
        public decimal AdjAmt
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt
        {
            get ;
            set ;
        }

		
        public decimal PBudAmt
        {
            get ;
            set ;
        }

		
        public decimal PAdjAmt
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_ExpItemFundLedger Create()
        {
            return EF.DataPortal.Create<PM_ExpItemFundLedger>();
        }

		public static PM_ExpItemFundLedger Fetch(System.Linq.Expressions.Expression<Func<PM_ExpItemFundLedger, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ExpItemFundLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_ExpItemFundLedger>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ExpItemFundLedgers))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ExpItemFundLedgers:ReadOnlyListBase<PM_ExpItemFundLedgers,PM_ExpItemFundLedger>
    {
        #region Factory Methods

        public static PM_ExpItemFundLedgers Fetch()
        {
            return EF.DataPortal.Fetch<PM_ExpItemFundLedgers>();
        }

		public static PM_ExpItemFundLedgers Fetch(System.Linq.Expressions.Expression<Func<PM_ExpItemFundLedger, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ExpItemFundLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_ExpItemFundLedgers>(lambda);
		}

		public static PM_ExpItemFundLedgers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ExpItemFundLedgers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ExpItemFundLedgers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ExpItemFundLedger, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ExpItemFundLedgers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ExpItemFundLedger>(exp,values)});
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
