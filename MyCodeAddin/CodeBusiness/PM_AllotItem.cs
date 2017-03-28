using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_AllotItem))]
#if Dev
    [RunLocal]
#endif

	public class PM_AllotItem:ReadOnlyBase<PM_AllotItem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AllotItemCode
        {
            get ;
            set ;
        }

		
        public string AllotItemName
        {
            get ;
            set ;
        }

		
        public string AllotAreaCode
        {
            get ;
            set ;
        }

		
        public bool IsManaFee
        {
            get ;
            set ;
        }

		
        public bool IsTax
        {
            get ;
            set ;
        }

		
        public bool IsFixFee
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

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public string PBudExpEcoCode
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

		public static PM_AllotItem Create()
        {
            return EF.DataPortal.Create<PM_AllotItem>();
        }

		public static PM_AllotItem Fetch(System.Linq.Expressions.Expression<Func<PM_AllotItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotItem>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_AllotItems))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_AllotItems:ReadOnlyListBase<PM_AllotItems,PM_AllotItem>
    {
        #region Factory Methods

        public static PM_AllotItems Fetch()
        {
            return EF.DataPortal.Fetch<PM_AllotItems>();
        }

		public static PM_AllotItems Fetch(System.Linq.Expressions.Expression<Func<PM_AllotItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotItem>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotItems>(lambda);
		}

		public static PM_AllotItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_AllotItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_AllotItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_AllotItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_AllotItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_AllotItem>(exp,values)});
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
