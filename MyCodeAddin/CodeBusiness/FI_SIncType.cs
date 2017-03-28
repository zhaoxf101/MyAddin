using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_SIncType))]
#if Dev
    [RunLocal]
#endif

	public class FI_SIncType:ReadOnlyBase<FI_SIncType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SIncTypeCode
        {
            get ;
            set ;
        }

		
        public string SIncTypeName
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

		public static FI_SIncType Create()
        {
            return EF.DataPortal.Create<FI_SIncType>();
        }

		public static FI_SIncType Fetch(System.Linq.Expressions.Expression<Func<FI_SIncType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_SIncType>(exp,values);
            return EF.DataPortal.Fetch<FI_SIncType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_SIncTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_SIncTypes:ReadOnlyListBase<FI_SIncTypes,FI_SIncType>
    {
        #region Factory Methods

        public static FI_SIncTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_SIncTypes>();
        }

		public static FI_SIncTypes Fetch(System.Linq.Expressions.Expression<Func<FI_SIncType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_SIncType>(exp,values);
            return EF.DataPortal.Fetch<FI_SIncTypes>(lambda);
		}

		public static FI_SIncTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_SIncTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_SIncTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_SIncType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_SIncTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_SIncType>(exp,values)});
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
