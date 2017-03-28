using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ExpItemLedger))]
#if Dev
    [RunLocal]
#endif

	public class PM_ExpItemLedger:ReadOnlyBase<PM_ExpItemLedger>
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

		
        public bool Freeze
        {
            get ;
            set ;
        }

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
        public string PBudExpEcoCode
        {
            get ;
            set ;
        }

		
        public string PBudExpItemCode
        {
            get ;
            set ;
        }

		
        public string PBudExpFunCode
        {
            get ;
            set ;
        }

		
        public bool IsBudCtrl
        {
            get ;
            set ;
        }

		
        public bool IsSpecial
        {
            get ;
            set ;
        }

		
        public string MaterialCode
        {
            get ;
            set ;
        }

		
        public decimal FDAmt
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

		
        public decimal OrdAmt
        {
            get ;
            set ;
        }

		
        public decimal FIOrdAmt
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

		public static PM_ExpItemLedger Create()
        {
            return EF.DataPortal.Create<PM_ExpItemLedger>();
        }

		public static PM_ExpItemLedger Fetch(System.Linq.Expressions.Expression<Func<PM_ExpItemLedger, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ExpItemLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_ExpItemLedger>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ExpItemLedgers))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ExpItemLedgers:ReadOnlyListBase<PM_ExpItemLedgers,PM_ExpItemLedger>
    {
        #region Factory Methods

        public static PM_ExpItemLedgers Fetch()
        {
            return EF.DataPortal.Fetch<PM_ExpItemLedgers>();
        }

		public static PM_ExpItemLedgers Fetch(System.Linq.Expressions.Expression<Func<PM_ExpItemLedger, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ExpItemLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_ExpItemLedgers>(lambda);
		}

		public static PM_ExpItemLedgers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ExpItemLedgers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ExpItemLedgers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ExpItemLedger, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ExpItemLedgers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ExpItemLedger>(exp,values)});
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
