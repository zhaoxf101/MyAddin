using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PayType))]
#if Dev
    [RunLocal]
#endif

	public class FI_PayType:ReadOnlyBase<FI_PayType>
    {
        #region Business Methods

		
        public string PayType
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PayType Create()
        {
            return EF.DataPortal.Create<FI_PayType>();
        }

		public static FI_PayType Fetch(System.Linq.Expressions.Expression<Func<FI_PayType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PayType>(exp,values);
            return EF.DataPortal.Fetch<FI_PayType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PayTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PayTypes:ReadOnlyListBase<FI_PayTypes,FI_PayType>
    {
        #region Factory Methods

        public static FI_PayTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_PayTypes>();
        }

		public static FI_PayTypes Fetch(System.Linq.Expressions.Expression<Func<FI_PayType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PayType>(exp,values);
            return EF.DataPortal.Fetch<FI_PayTypes>(lambda);
		}

		public static FI_PayTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PayTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PayTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PayType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PayTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PayType>(exp,values)});
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
