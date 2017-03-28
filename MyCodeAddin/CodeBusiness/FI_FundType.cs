using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_FundType))]
#if Dev
    [RunLocal]
#endif

	public class FI_FundType:ReadOnlyBase<FI_FundType>
    {
        #region Business Methods

		
        public string FundTypeCode
        {
            get ;
            set ;
        }

		
        public string FundTypeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_FundType Create()
        {
            return EF.DataPortal.Create<FI_FundType>();
        }

		public static FI_FundType Fetch(System.Linq.Expressions.Expression<Func<FI_FundType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_FundType>(exp,values);
            return EF.DataPortal.Fetch<FI_FundType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_FundTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_FundTypes:ReadOnlyListBase<FI_FundTypes,FI_FundType>
    {
        #region Factory Methods

        public static FI_FundTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_FundTypes>();
        }

		public static FI_FundTypes Fetch(System.Linq.Expressions.Expression<Func<FI_FundType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_FundType>(exp,values);
            return EF.DataPortal.Fetch<FI_FundTypes>(lambda);
		}

		public static FI_FundTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_FundTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_FundTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_FundType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_FundTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_FundType>(exp,values)});
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
