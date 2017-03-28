using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ExpItemResLedger))]
#if Dev
    [RunLocal]
#endif

	public class PM_ExpItemResLedger:ReadOnlyBase<PM_ExpItemResLedger>
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

		
        public string ExpItemRow
        {
            get ;
            set ;
        }

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public bool IsPBuy
        {
            get ;
            set ;
        }

		
        public bool Freeze
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public decimal FDQty
        {
            get ;
            set ;
        }

		
        public decimal BudQty
        {
            get ;
            set ;
        }

		
        public decimal LRAmt
        {
            get ;
            set ;
        }

		
        public decimal FDAmt
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

		public static PM_ExpItemResLedger Create()
        {
            return EF.DataPortal.Create<PM_ExpItemResLedger>();
        }

		public static PM_ExpItemResLedger Fetch(System.Linq.Expressions.Expression<Func<PM_ExpItemResLedger, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ExpItemResLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_ExpItemResLedger>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ExpItemResLedgers))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ExpItemResLedgers:ReadOnlyListBase<PM_ExpItemResLedgers,PM_ExpItemResLedger>
    {
        #region Factory Methods

        public static PM_ExpItemResLedgers Fetch()
        {
            return EF.DataPortal.Fetch<PM_ExpItemResLedgers>();
        }

		public static PM_ExpItemResLedgers Fetch(System.Linq.Expressions.Expression<Func<PM_ExpItemResLedger, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ExpItemResLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_ExpItemResLedgers>(lambda);
		}

		public static PM_ExpItemResLedgers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ExpItemResLedgers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ExpItemResLedgers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ExpItemResLedger, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ExpItemResLedgers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ExpItemResLedger>(exp,values)});
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
