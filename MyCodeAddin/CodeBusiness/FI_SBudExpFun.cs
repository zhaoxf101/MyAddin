using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_SBudExpFun))]
#if Dev
    [RunLocal]
#endif

	public class FI_SBudExpFun:ReadOnlyBase<FI_SBudExpFun>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SBudExpFunCode
        {
            get ;
            set ;
        }

		
        public string SBudExpFunName
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

		
        public bool IsRoot
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

		public static FI_SBudExpFun Create()
        {
            return EF.DataPortal.Create<FI_SBudExpFun>();
        }

		public static FI_SBudExpFun Fetch(System.Linq.Expressions.Expression<Func<FI_SBudExpFun, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_SBudExpFun>(exp,values);
            return EF.DataPortal.Fetch<FI_SBudExpFun>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_SBudExpFuns))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_SBudExpFuns:ReadOnlyListBase<FI_SBudExpFuns,FI_SBudExpFun>
    {
        #region Factory Methods

        public static FI_SBudExpFuns Fetch()
        {
            return EF.DataPortal.Fetch<FI_SBudExpFuns>();
        }

		public static FI_SBudExpFuns Fetch(System.Linq.Expressions.Expression<Func<FI_SBudExpFun, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_SBudExpFun>(exp,values);
            return EF.DataPortal.Fetch<FI_SBudExpFuns>(lambda);
		}

		public static FI_SBudExpFuns Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_SBudExpFuns>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_SBudExpFuns Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_SBudExpFun, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_SBudExpFuns>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_SBudExpFun>(exp,values)});
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
