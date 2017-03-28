using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BudSourceType))]
#if Dev
    [RunLocal]
#endif

	public class FI_BudSourceType:ReadOnlyBase<FI_BudSourceType>
    {
        #region Business Methods

		
        public string BudSourceGrpCode
        {
            get ;
            set ;
        }

		
        public string BudSourceGrpName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_BudSourceType Create()
        {
            return EF.DataPortal.Create<FI_BudSourceType>();
        }

		public static FI_BudSourceType Fetch(System.Linq.Expressions.Expression<Func<FI_BudSourceType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BudSourceType>(exp,values);
            return EF.DataPortal.Fetch<FI_BudSourceType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BudSourceTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BudSourceTypes:ReadOnlyListBase<FI_BudSourceTypes,FI_BudSourceType>
    {
        #region Factory Methods

        public static FI_BudSourceTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_BudSourceTypes>();
        }

		public static FI_BudSourceTypes Fetch(System.Linq.Expressions.Expression<Func<FI_BudSourceType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BudSourceType>(exp,values);
            return EF.DataPortal.Fetch<FI_BudSourceTypes>(lambda);
		}

		public static FI_BudSourceTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BudSourceTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BudSourceTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BudSourceType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BudSourceTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BudSourceType>(exp,values)});
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
