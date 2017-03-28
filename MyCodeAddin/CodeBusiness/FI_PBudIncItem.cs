using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PBudIncItem))]
#if Dev
    [RunLocal]
#endif

	public class FI_PBudIncItem:ReadOnlyBase<FI_PBudIncItem>
    {
        #region Business Methods

		
        public string PBudIncItemCode
        {
            get ;
            set ;
        }

		
        public string PBudIncItemName
        {
            get ;
            set ;
        }

		
        public string PBudIncTypeCode
        {
            get ;
            set ;
        }

		
        public string PCode
        {
            get ;
            set ;
        }

		
        public bool IsSpecial
        {
            get ;
            set ;
        }

		
        public string FundSourceCode
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public bool IsGroup
        {
            get ;
            set ;
        }

		
        public bool Active
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

		public static FI_PBudIncItem Create()
        {
            return EF.DataPortal.Create<FI_PBudIncItem>();
        }

		public static FI_PBudIncItem Fetch(System.Linq.Expressions.Expression<Func<FI_PBudIncItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PBudIncItem>(exp,values);
            return EF.DataPortal.Fetch<FI_PBudIncItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PBudIncItems))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PBudIncItems:ReadOnlyListBase<FI_PBudIncItems,FI_PBudIncItem>
    {
        #region Factory Methods

        public static FI_PBudIncItems Fetch()
        {
            return EF.DataPortal.Fetch<FI_PBudIncItems>();
        }

		public static FI_PBudIncItems Fetch(System.Linq.Expressions.Expression<Func<FI_PBudIncItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PBudIncItem>(exp,values);
            return EF.DataPortal.Fetch<FI_PBudIncItems>(lambda);
		}

		public static FI_PBudIncItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PBudIncItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PBudIncItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PBudIncItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PBudIncItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PBudIncItem>(exp,values)});
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
