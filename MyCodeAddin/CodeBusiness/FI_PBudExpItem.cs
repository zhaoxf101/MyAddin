using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PBudExpItem))]
#if Dev
    [RunLocal]
#endif

	public class FI_PBudExpItem:ReadOnlyBase<FI_PBudExpItem>
    {
        #region Business Methods

		
        public string PBudExpItemCode
        {
            get ;
            set ;
        }

		
        public string PBudExpItemName
        {
            get ;
            set ;
        }

		
        public string PCode
        {
            get ;
            set ;
        }

		
        public bool IsGroup
        {
            get ;
            set ;
        }

		
        public bool IsSys
        {
            get ;
            set ;
        }

		
        public bool IsPub
        {
            get ;
            set ;
        }

		
        public string PItemStaGrpCode
        {
            get ;
            set ;
        }

		
        public bool? IsRoot
        {
            get ;
            set ;
        }

		
        public bool Active
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

		public static FI_PBudExpItem Create()
        {
            return EF.DataPortal.Create<FI_PBudExpItem>();
        }

		public static FI_PBudExpItem Fetch(System.Linq.Expressions.Expression<Func<FI_PBudExpItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PBudExpItem>(exp,values);
            return EF.DataPortal.Fetch<FI_PBudExpItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PBudExpItems))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PBudExpItems:ReadOnlyListBase<FI_PBudExpItems,FI_PBudExpItem>
    {
        #region Factory Methods

        public static FI_PBudExpItems Fetch()
        {
            return EF.DataPortal.Fetch<FI_PBudExpItems>();
        }

		public static FI_PBudExpItems Fetch(System.Linq.Expressions.Expression<Func<FI_PBudExpItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PBudExpItem>(exp,values);
            return EF.DataPortal.Fetch<FI_PBudExpItems>(lambda);
		}

		public static FI_PBudExpItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PBudExpItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PBudExpItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PBudExpItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PBudExpItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PBudExpItem>(exp,values)});
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
