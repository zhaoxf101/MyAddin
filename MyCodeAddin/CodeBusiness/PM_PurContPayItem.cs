using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_PurContPayItem))]
#if Dev
    [RunLocal]
#endif

	public class PM_PurContPayItem:ReadOnlyBase<PM_PurContPayItem>
    {
        #region Business Methods

		
        public string PurContPayItemCode
        {
            get ;
            set ;
        }

		
        public string PurContPayItemName
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

		public static PM_PurContPayItem Create()
        {
            return EF.DataPortal.Create<PM_PurContPayItem>();
        }

		public static PM_PurContPayItem Fetch(System.Linq.Expressions.Expression<Func<PM_PurContPayItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_PurContPayItem>(exp,values);
            return EF.DataPortal.Fetch<PM_PurContPayItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_PurContPayItems))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_PurContPayItems:ReadOnlyListBase<PM_PurContPayItems,PM_PurContPayItem>
    {
        #region Factory Methods

        public static PM_PurContPayItems Fetch()
        {
            return EF.DataPortal.Fetch<PM_PurContPayItems>();
        }

		public static PM_PurContPayItems Fetch(System.Linq.Expressions.Expression<Func<PM_PurContPayItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_PurContPayItem>(exp,values);
            return EF.DataPortal.Fetch<PM_PurContPayItems>(lambda);
		}

		public static PM_PurContPayItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_PurContPayItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_PurContPayItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_PurContPayItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_PurContPayItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_PurContPayItem>(exp,values)});
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
