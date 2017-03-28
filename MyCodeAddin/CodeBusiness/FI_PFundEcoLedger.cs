using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PFundEcoLedger))]
#if Dev
    [RunLocal]
#endif

	public class FI_PFundEcoLedger:ReadOnlyBase<FI_PFundEcoLedger>
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

		
        public string PProjCode
        {
            get ;
            set ;
        }

		
        public string PBudExpEcoCode
        {
            get ;
            set ;
        }

		
        public string PFundEcoType
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

		
        public decimal InAmt
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

		
        public string Memo
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

		public static FI_PFundEcoLedger Create()
        {
            return EF.DataPortal.Create<FI_PFundEcoLedger>();
        }

		public static FI_PFundEcoLedger Fetch(System.Linq.Expressions.Expression<Func<FI_PFundEcoLedger, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PFundEcoLedger>(exp,values);
            return EF.DataPortal.Fetch<FI_PFundEcoLedger>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PFundEcoLedgers))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PFundEcoLedgers:ReadOnlyListBase<FI_PFundEcoLedgers,FI_PFundEcoLedger>
    {
        #region Factory Methods

        public static FI_PFundEcoLedgers Fetch()
        {
            return EF.DataPortal.Fetch<FI_PFundEcoLedgers>();
        }

		public static FI_PFundEcoLedgers Fetch(System.Linq.Expressions.Expression<Func<FI_PFundEcoLedger, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PFundEcoLedger>(exp,values);
            return EF.DataPortal.Fetch<FI_PFundEcoLedgers>(lambda);
		}

		public static FI_PFundEcoLedgers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PFundEcoLedgers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PFundEcoLedgers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PFundEcoLedger, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PFundEcoLedgers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PFundEcoLedger>(exp,values)});
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
