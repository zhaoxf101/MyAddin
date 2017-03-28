using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_FundExpType))]
#if Dev
    [RunLocal]
#endif

	public class FI_FundExpType:ReadOnlyBase<FI_FundExpType>
    {
        #region Business Methods

		
        public string FundExpTypeCode
        {
            get ;
            set ;
        }

		
        public string FundExpTypeName
        {
            get ;
            set ;
        }

		
        public string FundExpTypeGrpCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_FundExpType Create()
        {
            return EF.DataPortal.Create<FI_FundExpType>();
        }

		public static FI_FundExpType Fetch(System.Linq.Expressions.Expression<Func<FI_FundExpType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_FundExpType>(exp,values);
            return EF.DataPortal.Fetch<FI_FundExpType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_FundExpTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_FundExpTypes:ReadOnlyListBase<FI_FundExpTypes,FI_FundExpType>
    {
        #region Factory Methods

        public static FI_FundExpTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_FundExpTypes>();
        }

		public static FI_FundExpTypes Fetch(System.Linq.Expressions.Expression<Func<FI_FundExpType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_FundExpType>(exp,values);
            return EF.DataPortal.Fetch<FI_FundExpTypes>(lambda);
		}

		public static FI_FundExpTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_FundExpTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_FundExpTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_FundExpType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_FundExpTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_FundExpType>(exp,values)});
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
