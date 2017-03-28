using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_TuitionByClass))]
#if Dev
    [RunLocal]
#endif

	public class SM_TuitionByClass:ReadOnlyBase<SM_TuitionByClass>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string Year
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

		
        public decimal LAmt
        {
            get ;
            set ;
        }

		
        public decimal CAmt
        {
            get ;
            set ;
        }

		
        public decimal OAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_TuitionByClass Create()
        {
            return EF.DataPortal.Create<SM_TuitionByClass>();
        }

		public static SM_TuitionByClass Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionByClass, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionByClass>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionByClass>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_TuitionByClasss))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_TuitionByClasss:ReadOnlyListBase<SM_TuitionByClasss,SM_TuitionByClass>
    {
        #region Factory Methods

        public static SM_TuitionByClasss Fetch()
        {
            return EF.DataPortal.Fetch<SM_TuitionByClasss>();
        }

		public static SM_TuitionByClasss Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionByClass, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionByClass>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionByClasss>(lambda);
		}

		public static SM_TuitionByClasss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_TuitionByClasss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_TuitionByClasss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_TuitionByClass, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_TuitionByClasss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_TuitionByClass>(exp,values)});
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
