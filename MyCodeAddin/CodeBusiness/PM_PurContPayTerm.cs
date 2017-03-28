using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_PurContPayTerm))]
#if Dev
    [RunLocal]
#endif

	public class PM_PurContPayTerm:ReadOnlyBase<PM_PurContPayTerm>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ContractId
        {
            get ;
            set ;
        }

		
        public int PayNo
        {
            get ;
            set ;
        }

		
        public string PayItemCode
        {
            get ;
            set ;
        }

		
        public int SignNo
        {
            get ;
            set ;
        }

		
        public string PayDate
        {
            get ;
            set ;
        }

		
        public decimal PayAmt
        {
            get ;
            set ;
        }

		
        public decimal AdjPayAmt
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt
        {
            get ;
            set ;
        }

		
        public bool CanPay
        {
            get ;
            set ;
        }

		
        public string PayMemo
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

		
        public decimal OrdAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_PurContPayTerm Create()
        {
            return EF.DataPortal.Create<PM_PurContPayTerm>();
        }

		public static PM_PurContPayTerm Fetch(System.Linq.Expressions.Expression<Func<PM_PurContPayTerm, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_PurContPayTerm>(exp,values);
            return EF.DataPortal.Fetch<PM_PurContPayTerm>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_PurContPayTerms))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_PurContPayTerms:ReadOnlyListBase<PM_PurContPayTerms,PM_PurContPayTerm>
    {
        #region Factory Methods

        public static PM_PurContPayTerms Fetch()
        {
            return EF.DataPortal.Fetch<PM_PurContPayTerms>();
        }

		public static PM_PurContPayTerms Fetch(System.Linq.Expressions.Expression<Func<PM_PurContPayTerm, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_PurContPayTerm>(exp,values);
            return EF.DataPortal.Fetch<PM_PurContPayTerms>(lambda);
		}

		public static PM_PurContPayTerms Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_PurContPayTerms>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_PurContPayTerms Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_PurContPayTerm, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_PurContPayTerms>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_PurContPayTerm>(exp,values)});
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
