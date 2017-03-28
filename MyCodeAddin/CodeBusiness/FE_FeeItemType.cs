using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_FeeItemType))]
#if Dev
    [RunLocal]
#endif

	public class FE_FeeItemType:ReadOnlyBase<FE_FeeItemType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string FeeItemType
        {
            get ;
            set ;
        }

		
        public string FeeItemName
        {
            get ;
            set ;
        }

		
        public string TCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_FeeItemType Create()
        {
            return EF.DataPortal.Create<FE_FeeItemType>();
        }

		public static FE_FeeItemType Fetch(System.Linq.Expressions.Expression<Func<FE_FeeItemType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_FeeItemType>(exp,values);
            return EF.DataPortal.Fetch<FE_FeeItemType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_FeeItemTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_FeeItemTypes:ReadOnlyListBase<FE_FeeItemTypes,FE_FeeItemType>
    {
        #region Factory Methods

        public static FE_FeeItemTypes Fetch()
        {
            return EF.DataPortal.Fetch<FE_FeeItemTypes>();
        }

		public static FE_FeeItemTypes Fetch(System.Linq.Expressions.Expression<Func<FE_FeeItemType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_FeeItemType>(exp,values);
            return EF.DataPortal.Fetch<FE_FeeItemTypes>(lambda);
		}

		public static FE_FeeItemTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_FeeItemTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_FeeItemTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_FeeItemType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_FeeItemTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_FeeItemType>(exp,values)});
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
