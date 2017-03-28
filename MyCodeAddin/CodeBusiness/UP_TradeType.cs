using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_TradeType))]
#if Dev
    [RunLocal]
#endif

	public class UP_TradeType:ReadOnlyBase<UP_TradeType>
    {
        #region Business Methods

		
        public string TradeTypeCode
        {
            get ;
            set ;
        }

		
        public string TradeTypeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static UP_TradeType Create()
        {
            return EF.DataPortal.Create<UP_TradeType>();
        }

		public static UP_TradeType Fetch(System.Linq.Expressions.Expression<Func<UP_TradeType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_TradeType>(exp,values);
            return EF.DataPortal.Fetch<UP_TradeType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_TradeTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_TradeTypes:ReadOnlyListBase<UP_TradeTypes,UP_TradeType>
    {
        #region Factory Methods

        public static UP_TradeTypes Fetch()
        {
            return EF.DataPortal.Fetch<UP_TradeTypes>();
        }

		public static UP_TradeTypes Fetch(System.Linq.Expressions.Expression<Func<UP_TradeType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_TradeType>(exp,values);
            return EF.DataPortal.Fetch<UP_TradeTypes>(lambda);
		}

		public static UP_TradeTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_TradeTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_TradeTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_TradeType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_TradeTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_TradeType>(exp,values)});
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
