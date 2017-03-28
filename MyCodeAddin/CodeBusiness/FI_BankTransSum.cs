using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BankTransSum))]
#if Dev
    [RunLocal]
#endif

	public class FI_BankTransSum:ReadOnlyBase<FI_BankTransSum>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TransBillNo
        {
            get ;
            set ;
        }

		
        public string FreeItemCode
        {
            get ;
            set ;
        }

		
        public string SumType
        {
            get ;
            set ;
        }

		
        public string SumItemCode
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
        public string ItemText
        {
            get ;
            set ;
        }

		
        public decimal? Amt
        {
            get ;
            set ;
        }

		
        public string IncDetCode
        {
            get ;
            set ;
        }

		
        public bool IsInc
        {
            get ;
            set ;
        }

		
        public string RelPartyCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_BankTransSum Create()
        {
            return EF.DataPortal.Create<FI_BankTransSum>();
        }

		public static FI_BankTransSum Fetch(System.Linq.Expressions.Expression<Func<FI_BankTransSum, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BankTransSum>(exp,values);
            return EF.DataPortal.Fetch<FI_BankTransSum>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BankTransSums))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BankTransSums:ReadOnlyListBase<FI_BankTransSums,FI_BankTransSum>
    {
        #region Factory Methods

        public static FI_BankTransSums Fetch()
        {
            return EF.DataPortal.Fetch<FI_BankTransSums>();
        }

		public static FI_BankTransSums Fetch(System.Linq.Expressions.Expression<Func<FI_BankTransSum, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BankTransSum>(exp,values);
            return EF.DataPortal.Fetch<FI_BankTransSums>(lambda);
		}

		public static FI_BankTransSums Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BankTransSums>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BankTransSums Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BankTransSum, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BankTransSums>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BankTransSum>(exp,values)});
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
