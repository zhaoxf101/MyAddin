using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_InvItem))]
#if Dev
    [RunLocal]
#endif

	public class FI_InvItem:ReadOnlyBase<FI_InvItem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string InvItemCode
        {
            get ;
            set ;
        }

		
        public string InvItemName
        {
            get ;
            set ;
        }

		
        public string PermitItemCode
        {
            get ;
            set ;
        }

		
        public string InvTypCode
        {
            get ;
            set ;
        }

		
        public string SIncItemCode
        {
            get ;
            set ;
        }

		
        public bool IsToProjct
        {
            get ;
            set ;
        }

		
        public bool IsAutoCancInv
        {
            get ;
            set ;
        }

		
        public bool IsRD
        {
            get ;
            set ;
        }

		
        public string CAccCode
        {
            get ;
            set ;
        }

		
        public string DAccCode
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

		public static FI_InvItem Create()
        {
            return EF.DataPortal.Create<FI_InvItem>();
        }

		public static FI_InvItem Fetch(System.Linq.Expressions.Expression<Func<FI_InvItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_InvItem>(exp,values);
            return EF.DataPortal.Fetch<FI_InvItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_InvItems))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_InvItems:ReadOnlyListBase<FI_InvItems,FI_InvItem>
    {
        #region Factory Methods

        public static FI_InvItems Fetch()
        {
            return EF.DataPortal.Fetch<FI_InvItems>();
        }

		public static FI_InvItems Fetch(System.Linq.Expressions.Expression<Func<FI_InvItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_InvItem>(exp,values);
            return EF.DataPortal.Fetch<FI_InvItems>(lambda);
		}

		public static FI_InvItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_InvItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_InvItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_InvItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_InvItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_InvItem>(exp,values)});
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
