using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_TuitionBillVouch))]
#if Dev
    [RunLocal]
#endif

	public class SM_TuitionBillVouch:ReadOnlyBase<SM_TuitionBillVouch>
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

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string AccPid
        {
            get ;
            set ;
        }

		
        public string LineNR
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

		public static SM_TuitionBillVouch Create()
        {
            return EF.DataPortal.Create<SM_TuitionBillVouch>();
        }

		public static SM_TuitionBillVouch Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionBillVouch, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionBillVouch>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionBillVouch>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_TuitionBillVouchs))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_TuitionBillVouchs:ReadOnlyListBase<SM_TuitionBillVouchs,SM_TuitionBillVouch>
    {
        #region Factory Methods

        public static SM_TuitionBillVouchs Fetch()
        {
            return EF.DataPortal.Fetch<SM_TuitionBillVouchs>();
        }

		public static SM_TuitionBillVouchs Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionBillVouch, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionBillVouch>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionBillVouchs>(lambda);
		}

		public static SM_TuitionBillVouchs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_TuitionBillVouchs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_TuitionBillVouchs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_TuitionBillVouch, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_TuitionBillVouchs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_TuitionBillVouch>(exp,values)});
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
