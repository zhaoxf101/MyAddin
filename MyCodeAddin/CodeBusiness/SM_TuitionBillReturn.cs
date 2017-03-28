using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_TuitionBillReturn))]
#if Dev
    [RunLocal]
#endif

	public class SM_TuitionBillReturn:ReadOnlyBase<SM_TuitionBillReturn>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TuitionBillNo
        {
            get ;
            set ;
        }

		
        public string DealNo
        {
            get ;
            set ;
        }

		
        public string StuentNo
        {
            get ;
            set ;
        }

		
        public bool IsExternal
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

		public static SM_TuitionBillReturn Create()
        {
            return EF.DataPortal.Create<SM_TuitionBillReturn>();
        }

		public static SM_TuitionBillReturn Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionBillReturn, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionBillReturn>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionBillReturn>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_TuitionBillReturns))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_TuitionBillReturns:ReadOnlyListBase<SM_TuitionBillReturns,SM_TuitionBillReturn>
    {
        #region Factory Methods

        public static SM_TuitionBillReturns Fetch()
        {
            return EF.DataPortal.Fetch<SM_TuitionBillReturns>();
        }

		public static SM_TuitionBillReturns Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionBillReturn, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionBillReturn>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionBillReturns>(lambda);
		}

		public static SM_TuitionBillReturns Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_TuitionBillReturns>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_TuitionBillReturns Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_TuitionBillReturn, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_TuitionBillReturns>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_TuitionBillReturn>(exp,values)});
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
