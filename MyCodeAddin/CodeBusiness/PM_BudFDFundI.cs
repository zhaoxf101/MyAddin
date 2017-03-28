using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_BudFDFundI))]
#if Dev
    [RunLocal]
#endif

	public class PM_BudFDFundI:ReadOnlyBase<PM_BudFDFundI>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AppNo
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

		
        public bool? IsAdd
        {
            get ;
            set ;
        }

		
        public bool CanChg
        {
            get ;
            set ;
        }

		
        public decimal BudAmt
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

		public static PM_BudFDFundI Create()
        {
            return EF.DataPortal.Create<PM_BudFDFundI>();
        }

		public static PM_BudFDFundI Fetch(System.Linq.Expressions.Expression<Func<PM_BudFDFundI, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_BudFDFundI>(exp,values);
            return EF.DataPortal.Fetch<PM_BudFDFundI>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_BudFDFundIs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_BudFDFundIs:ReadOnlyListBase<PM_BudFDFundIs,PM_BudFDFundI>
    {
        #region Factory Methods

        public static PM_BudFDFundIs Fetch()
        {
            return EF.DataPortal.Fetch<PM_BudFDFundIs>();
        }

		public static PM_BudFDFundIs Fetch(System.Linq.Expressions.Expression<Func<PM_BudFDFundI, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_BudFDFundI>(exp,values);
            return EF.DataPortal.Fetch<PM_BudFDFundIs>(lambda);
		}

		public static PM_BudFDFundIs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_BudFDFundIs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_BudFDFundIs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_BudFDFundI, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_BudFDFundIs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_BudFDFundI>(exp,values)});
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
