using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjMemLedger))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjMemLedger:ReadOnlyBase<PM_ProjMemLedger>
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

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public decimal BudAmt
        {
            get ;
            set ;
        }

		
        public decimal LoanAmt
        {
            get ;
            set ;
        }

		
        public decimal WoffAmt
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

		public static PM_ProjMemLedger Create()
        {
            return EF.DataPortal.Create<PM_ProjMemLedger>();
        }

		public static PM_ProjMemLedger Fetch(System.Linq.Expressions.Expression<Func<PM_ProjMemLedger, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjMemLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjMemLedger>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjMemLedgers))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjMemLedgers:ReadOnlyListBase<PM_ProjMemLedgers,PM_ProjMemLedger>
    {
        #region Factory Methods

        public static PM_ProjMemLedgers Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjMemLedgers>();
        }

		public static PM_ProjMemLedgers Fetch(System.Linq.Expressions.Expression<Func<PM_ProjMemLedger, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjMemLedger>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjMemLedgers>(lambda);
		}

		public static PM_ProjMemLedgers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjMemLedgers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjMemLedgers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjMemLedger, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjMemLedgers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjMemLedger>(exp,values)});
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
