using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_Currency))]
#if Dev
    [RunLocal]
#endif

	public class FI_Currency:ReadOnlyBase<FI_Currency>
    {
        #region Business Methods

		
        public string CurrCode
        {
            get ;
            set ;
        }

		
        public string SText
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
        public string Sign
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_Currency Create()
        {
            return EF.DataPortal.Create<FI_Currency>();
        }

		public static FI_Currency Fetch(System.Linq.Expressions.Expression<Func<FI_Currency, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_Currency>(exp,values);
            return EF.DataPortal.Fetch<FI_Currency>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_Currencys))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_Currencys:ReadOnlyListBase<FI_Currencys,FI_Currency>
    {
        #region Factory Methods

        public static FI_Currencys Fetch()
        {
            return EF.DataPortal.Fetch<FI_Currencys>();
        }

		public static FI_Currencys Fetch(System.Linq.Expressions.Expression<Func<FI_Currency, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_Currency>(exp,values);
            return EF.DataPortal.Fetch<FI_Currencys>(lambda);
		}

		public static FI_Currencys Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_Currencys>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_Currencys Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_Currency, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_Currencys>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_Currency>(exp,values)});
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
