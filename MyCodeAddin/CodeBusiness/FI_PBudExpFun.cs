using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PBudExpFun))]
#if Dev
    [RunLocal]
#endif

	public class FI_PBudExpFun:ReadOnlyBase<FI_PBudExpFun>
    {
        #region Business Methods

		
        public string PBudExpFunCode
        {
            get ;
            set ;
        }

		
        public string PBudExpFunName
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

		public static FI_PBudExpFun Create()
        {
            return EF.DataPortal.Create<FI_PBudExpFun>();
        }

		public static FI_PBudExpFun Fetch(System.Linq.Expressions.Expression<Func<FI_PBudExpFun, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PBudExpFun>(exp,values);
            return EF.DataPortal.Fetch<FI_PBudExpFun>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PBudExpFuns))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PBudExpFuns:ReadOnlyListBase<FI_PBudExpFuns,FI_PBudExpFun>
    {
        #region Factory Methods

        public static FI_PBudExpFuns Fetch()
        {
            return EF.DataPortal.Fetch<FI_PBudExpFuns>();
        }

		public static FI_PBudExpFuns Fetch(System.Linq.Expressions.Expression<Func<FI_PBudExpFun, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PBudExpFun>(exp,values);
            return EF.DataPortal.Fetch<FI_PBudExpFuns>(lambda);
		}

		public static FI_PBudExpFuns Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PBudExpFuns>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PBudExpFuns Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PBudExpFun, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PBudExpFuns>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PBudExpFun>(exp,values)});
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
