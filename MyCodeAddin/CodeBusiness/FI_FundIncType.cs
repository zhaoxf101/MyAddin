using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_FundIncType))]
#if Dev
    [RunLocal]
#endif

	public class FI_FundIncType:ReadOnlyBase<FI_FundIncType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string FundIncTypeCode
        {
            get ;
            set ;
        }

		
        public string FundIncTypeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_FundIncType Create()
        {
            return EF.DataPortal.Create<FI_FundIncType>();
        }

		public static FI_FundIncType Fetch(System.Linq.Expressions.Expression<Func<FI_FundIncType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_FundIncType>(exp,values);
            return EF.DataPortal.Fetch<FI_FundIncType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_FundIncTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_FundIncTypes:ReadOnlyListBase<FI_FundIncTypes,FI_FundIncType>
    {
        #region Factory Methods

        public static FI_FundIncTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_FundIncTypes>();
        }

		public static FI_FundIncTypes Fetch(System.Linq.Expressions.Expression<Func<FI_FundIncType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_FundIncType>(exp,values);
            return EF.DataPortal.Fetch<FI_FundIncTypes>(lambda);
		}

		public static FI_FundIncTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_FundIncTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_FundIncTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_FundIncType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_FundIncTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_FundIncType>(exp,values)});
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
