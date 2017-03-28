using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_PurContAppPayTerm))]
#if Dev
    [RunLocal]
#endif

	public class PM_PurContAppPayTerm:ReadOnlyBase<PM_PurContAppPayTerm>
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

		
        public int SignNo
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

		
        public decimal CurPayAmt
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

		
        public bool IsN
        {
            get ;
            set ;
        }

		
        public string PayMemo
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_PurContAppPayTerm Create()
        {
            return EF.DataPortal.Create<PM_PurContAppPayTerm>();
        }

		public static PM_PurContAppPayTerm Fetch(System.Linq.Expressions.Expression<Func<PM_PurContAppPayTerm, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_PurContAppPayTerm>(exp,values);
            return EF.DataPortal.Fetch<PM_PurContAppPayTerm>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_PurContAppPayTerms))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_PurContAppPayTerms:ReadOnlyListBase<PM_PurContAppPayTerms,PM_PurContAppPayTerm>
    {
        #region Factory Methods

        public static PM_PurContAppPayTerms Fetch()
        {
            return EF.DataPortal.Fetch<PM_PurContAppPayTerms>();
        }

		public static PM_PurContAppPayTerms Fetch(System.Linq.Expressions.Expression<Func<PM_PurContAppPayTerm, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_PurContAppPayTerm>(exp,values);
            return EF.DataPortal.Fetch<PM_PurContAppPayTerms>(lambda);
		}

		public static PM_PurContAppPayTerms Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_PurContAppPayTerms>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_PurContAppPayTerms Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_PurContAppPayTerm, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_PurContAppPayTerms>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_PurContAppPayTerm>(exp,values)});
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
