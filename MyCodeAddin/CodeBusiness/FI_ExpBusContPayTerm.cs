using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusContPayTerm))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusContPayTerm:ReadOnlyBase<FI_ExpBusContPayTerm>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExpBusCode
        {
            get ;
            set ;
        }

		
        public string ContractId
        {
            get ;
            set ;
        }

		
        public string PayItemCode
        {
            get ;
            set ;
        }

		
        public int PayNo
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public bool IsExp
        {
            get ;
            set ;
        }

		
        public bool IsOther
        {
            get ;
            set ;
        }

		
        public decimal ActAmt
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

		public static FI_ExpBusContPayTerm Create()
        {
            return EF.DataPortal.Create<FI_ExpBusContPayTerm>();
        }

		public static FI_ExpBusContPayTerm Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusContPayTerm, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusContPayTerm>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusContPayTerm>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusContPayTerms))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusContPayTerms:ReadOnlyListBase<FI_ExpBusContPayTerms,FI_ExpBusContPayTerm>
    {
        #region Factory Methods

        public static FI_ExpBusContPayTerms Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusContPayTerms>();
        }

		public static FI_ExpBusContPayTerms Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusContPayTerm, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusContPayTerm>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusContPayTerms>(lambda);
		}

		public static FI_ExpBusContPayTerms Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusContPayTerms>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusContPayTerms Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusContPayTerm, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusContPayTerms>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusContPayTerm>(exp,values)});
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
