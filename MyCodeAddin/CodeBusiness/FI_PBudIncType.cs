using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PBudIncType))]
#if Dev
    [RunLocal]
#endif

	public class FI_PBudIncType:ReadOnlyBase<FI_PBudIncType>
    {
        #region Business Methods

		
        public string PBudIncTypeCode
        {
            get ;
            set ;
        }

		
        public string PBudIncTypeName
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

		
        public bool Active
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

		public static FI_PBudIncType Create()
        {
            return EF.DataPortal.Create<FI_PBudIncType>();
        }

		public static FI_PBudIncType Fetch(System.Linq.Expressions.Expression<Func<FI_PBudIncType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PBudIncType>(exp,values);
            return EF.DataPortal.Fetch<FI_PBudIncType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PBudIncTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PBudIncTypes:ReadOnlyListBase<FI_PBudIncTypes,FI_PBudIncType>
    {
        #region Factory Methods

        public static FI_PBudIncTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_PBudIncTypes>();
        }

		public static FI_PBudIncTypes Fetch(System.Linq.Expressions.Expression<Func<FI_PBudIncType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PBudIncType>(exp,values);
            return EF.DataPortal.Fetch<FI_PBudIncTypes>(lambda);
		}

		public static FI_PBudIncTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PBudIncTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PBudIncTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PBudIncType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PBudIncTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PBudIncType>(exp,values)});
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
