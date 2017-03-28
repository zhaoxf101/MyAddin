using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_TuitionBillItem))]
#if Dev
    [RunLocal]
#endif

	public class SM_TuitionBillItem:ReadOnlyBase<SM_TuitionBillItem>
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

		
        public string ClassCode
        {
            get ;
            set ;
        }

		
        public string FeeItemCode
        {
            get ;
            set ;
        }

		
        public string PayWayCode
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
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

		public static SM_TuitionBillItem Create()
        {
            return EF.DataPortal.Create<SM_TuitionBillItem>();
        }

		public static SM_TuitionBillItem Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionBillItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionBillItem>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionBillItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_TuitionBillItems))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_TuitionBillItems:ReadOnlyListBase<SM_TuitionBillItems,SM_TuitionBillItem>
    {
        #region Factory Methods

        public static SM_TuitionBillItems Fetch()
        {
            return EF.DataPortal.Fetch<SM_TuitionBillItems>();
        }

		public static SM_TuitionBillItems Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionBillItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionBillItem>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionBillItems>(lambda);
		}

		public static SM_TuitionBillItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_TuitionBillItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_TuitionBillItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_TuitionBillItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_TuitionBillItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_TuitionBillItem>(exp,values)});
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
