using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_Trade))]
#if Dev
    [RunLocal]
#endif

	public class Sys_Trade:ReadOnlyBase<Sys_Trade>
    {
        #region Business Methods

		
        public string TradeCode
        {
            get ;
            set ;
        }

		
        public string TradeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_Trade Create()
        {
            return EF.DataPortal.Create<Sys_Trade>();
        }

		public static Sys_Trade Fetch(System.Linq.Expressions.Expression<Func<Sys_Trade, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_Trade>(exp,values);
            return EF.DataPortal.Fetch<Sys_Trade>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_Trades))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_Trades:ReadOnlyListBase<Sys_Trades,Sys_Trade>
    {
        #region Factory Methods

        public static Sys_Trades Fetch()
        {
            return EF.DataPortal.Fetch<Sys_Trades>();
        }

		public static Sys_Trades Fetch(System.Linq.Expressions.Expression<Func<Sys_Trade, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_Trade>(exp,values);
            return EF.DataPortal.Fetch<Sys_Trades>(lambda);
		}

		public static Sys_Trades Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_Trades>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_Trades Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_Trade, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_Trades>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_Trade>(exp,values)});
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
