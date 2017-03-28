using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_SOATrade))]
#if Dev
    [RunLocal]
#endif

	public class EF_SOATrade:ReadOnlyBase<EF_SOATrade>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string BillCode
        {
            get ;
            set ;
        }

		
        public string TradeDate
        {
            get ;
            set ;
        }

		
        public string TradeNo
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_SOATrade Create()
        {
            return EF.DataPortal.Create<EF_SOATrade>();
        }

		public static EF_SOATrade Fetch(System.Linq.Expressions.Expression<Func<EF_SOATrade, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_SOATrade>(exp,values);
            return EF.DataPortal.Fetch<EF_SOATrade>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_SOATrades))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_SOATrades:ReadOnlyListBase<EF_SOATrades,EF_SOATrade>
    {
        #region Factory Methods

        public static EF_SOATrades Fetch()
        {
            return EF.DataPortal.Fetch<EF_SOATrades>();
        }

		public static EF_SOATrades Fetch(System.Linq.Expressions.Expression<Func<EF_SOATrade, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_SOATrade>(exp,values);
            return EF.DataPortal.Fetch<EF_SOATrades>(lambda);
		}

		public static EF_SOATrades Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_SOATrades>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_SOATrades Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_SOATrade, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_SOATrades>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_SOATrade>(exp,values)});
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
