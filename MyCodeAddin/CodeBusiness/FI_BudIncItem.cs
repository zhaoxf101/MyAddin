using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BudIncItem))]
#if Dev
    [RunLocal]
#endif

	public class FI_BudIncItem:ReadOnlyBase<FI_BudIncItem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BudIncItemCode
        {
            get ;
            set ;
        }

		
        public string BudIncItemName
        {
            get ;
            set ;
        }

		
        public string SBudIncTypeCode
        {
            get ;
            set ;
        }

		
        public bool Flag
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_BudIncItem Create()
        {
            return EF.DataPortal.Create<FI_BudIncItem>();
        }

		public static FI_BudIncItem Fetch(System.Linq.Expressions.Expression<Func<FI_BudIncItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BudIncItem>(exp,values);
            return EF.DataPortal.Fetch<FI_BudIncItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BudIncItems))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BudIncItems:ReadOnlyListBase<FI_BudIncItems,FI_BudIncItem>
    {
        #region Factory Methods

        public static FI_BudIncItems Fetch()
        {
            return EF.DataPortal.Fetch<FI_BudIncItems>();
        }

		public static FI_BudIncItems Fetch(System.Linq.Expressions.Expression<Func<FI_BudIncItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BudIncItem>(exp,values);
            return EF.DataPortal.Fetch<FI_BudIncItems>(lambda);
		}

		public static FI_BudIncItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BudIncItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BudIncItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BudIncItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BudIncItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BudIncItem>(exp,values)});
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
