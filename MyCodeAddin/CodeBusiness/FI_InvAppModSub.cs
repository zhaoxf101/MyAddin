using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_InvAppModSub))]
#if Dev
    [RunLocal]
#endif

	public class FI_InvAppModSub:ReadOnlyBase<FI_InvAppModSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string InvAppModCode
        {
            get ;
            set ;
        }

		
        public string InvItemCode
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

		public static FI_InvAppModSub Create()
        {
            return EF.DataPortal.Create<FI_InvAppModSub>();
        }

		public static FI_InvAppModSub Fetch(System.Linq.Expressions.Expression<Func<FI_InvAppModSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_InvAppModSub>(exp,values);
            return EF.DataPortal.Fetch<FI_InvAppModSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_InvAppModSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_InvAppModSubs:ReadOnlyListBase<FI_InvAppModSubs,FI_InvAppModSub>
    {
        #region Factory Methods

        public static FI_InvAppModSubs Fetch()
        {
            return EF.DataPortal.Fetch<FI_InvAppModSubs>();
        }

		public static FI_InvAppModSubs Fetch(System.Linq.Expressions.Expression<Func<FI_InvAppModSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_InvAppModSub>(exp,values);
            return EF.DataPortal.Fetch<FI_InvAppModSubs>(lambda);
		}

		public static FI_InvAppModSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_InvAppModSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_InvAppModSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_InvAppModSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_InvAppModSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_InvAppModSub>(exp,values)});
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
