using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpFundType))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpFundType:ReadOnlyBase<FI_ExpFundType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExpFundTypeCode
        {
            get ;
            set ;
        }

		
        public string ExpFundTypeName
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsGroup
        {
            get ;
            set ;
        }

		
        public string PConCode
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

		public static FI_ExpFundType Create()
        {
            return EF.DataPortal.Create<FI_ExpFundType>();
        }

		public static FI_ExpFundType Fetch(System.Linq.Expressions.Expression<Func<FI_ExpFundType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpFundType>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpFundType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpFundTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpFundTypes:ReadOnlyListBase<FI_ExpFundTypes,FI_ExpFundType>
    {
        #region Factory Methods

        public static FI_ExpFundTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpFundTypes>();
        }

		public static FI_ExpFundTypes Fetch(System.Linq.Expressions.Expression<Func<FI_ExpFundType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpFundType>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpFundTypes>(lambda);
		}

		public static FI_ExpFundTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpFundTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpFundTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpFundType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpFundTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpFundType>(exp,values)});
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
