using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_SIncItem))]
#if Dev
    [RunLocal]
#endif

	public class FI_SIncItem:ReadOnlyBase<FI_SIncItem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SIncItemCode
        {
            get ;
            set ;
        }

		
        public string SIncItemName
        {
            get ;
            set ;
        }

		
        public string SIncTypeCode
        {
            get ;
            set ;
        }

		
        public string ExpFundTypeCode
        {
            get ;
            set ;
        }

		
        public string PBudIncTypeCode
        {
            get ;
            set ;
        }

		
        public string FundBudAreaCode
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsDel
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

		public static FI_SIncItem Create()
        {
            return EF.DataPortal.Create<FI_SIncItem>();
        }

		public static FI_SIncItem Fetch(System.Linq.Expressions.Expression<Func<FI_SIncItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_SIncItem>(exp,values);
            return EF.DataPortal.Fetch<FI_SIncItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_SIncItems))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_SIncItems:ReadOnlyListBase<FI_SIncItems,FI_SIncItem>
    {
        #region Factory Methods

        public static FI_SIncItems Fetch()
        {
            return EF.DataPortal.Fetch<FI_SIncItems>();
        }

		public static FI_SIncItems Fetch(System.Linq.Expressions.Expression<Func<FI_SIncItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_SIncItem>(exp,values);
            return EF.DataPortal.Fetch<FI_SIncItems>(lambda);
		}

		public static FI_SIncItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_SIncItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_SIncItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_SIncItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_SIncItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_SIncItem>(exp,values)});
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
