using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BankTransBus))]
#if Dev
    [RunLocal]
#endif

	public class FI_BankTransBus:ReadOnlyBase<FI_BankTransBus>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TransactionNo
        {
            get ;
            set ;
        }

		
        public string BankId
        {
            get ;
            set ;
        }

		
        public string BusType
        {
            get ;
            set ;
        }

		
        public string ItemId
        {
            get ;
            set ;
        }

		
        public string ItemText
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

		public static FI_BankTransBus Create()
        {
            return EF.DataPortal.Create<FI_BankTransBus>();
        }

		public static FI_BankTransBus Fetch(System.Linq.Expressions.Expression<Func<FI_BankTransBus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BankTransBus>(exp,values);
            return EF.DataPortal.Fetch<FI_BankTransBus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BankTransBuss))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BankTransBuss:ReadOnlyListBase<FI_BankTransBuss,FI_BankTransBus>
    {
        #region Factory Methods

        public static FI_BankTransBuss Fetch()
        {
            return EF.DataPortal.Fetch<FI_BankTransBuss>();
        }

		public static FI_BankTransBuss Fetch(System.Linq.Expressions.Expression<Func<FI_BankTransBus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BankTransBus>(exp,values);
            return EF.DataPortal.Fetch<FI_BankTransBuss>(lambda);
		}

		public static FI_BankTransBuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BankTransBuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BankTransBuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BankTransBus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BankTransBuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BankTransBus>(exp,values)});
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
