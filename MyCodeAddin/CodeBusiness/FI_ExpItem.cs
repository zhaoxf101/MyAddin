using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpItem))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpItem:ReadOnlyBase<FI_ExpItem>
    {
        #region Business Methods

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
        public string ExpItemName
        {
            get ;
            set ;
        }

		
        public string ExpItemGrpCode
        {
            get ;
            set ;
        }

		
        public string PBudExpEcoCode
        {
            get ;
            set ;
        }

		
        public string ResExpTypeCode
        {
            get ;
            set ;
        }

		
        public bool IsResBud
        {
            get ;
            set ;
        }

		
        public bool IsThreeExp
        {
            get ;
            set ;
        }

		
        public string Memo
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

		public static FI_ExpItem Create()
        {
            return EF.DataPortal.Create<FI_ExpItem>();
        }

		public static FI_ExpItem Fetch(System.Linq.Expressions.Expression<Func<FI_ExpItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpItem>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpItems))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpItems:ReadOnlyListBase<FI_ExpItems,FI_ExpItem>
    {
        #region Factory Methods

        public static FI_ExpItems Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpItems>();
        }

		public static FI_ExpItems Fetch(System.Linq.Expressions.Expression<Func<FI_ExpItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpItem>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpItems>(lambda);
		}

		public static FI_ExpItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpItem>(exp,values)});
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
