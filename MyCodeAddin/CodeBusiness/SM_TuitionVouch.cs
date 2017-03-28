using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_TuitionVouch))]
#if Dev
    [RunLocal]
#endif

	public class SM_TuitionVouch:ReadOnlyBase<SM_TuitionVouch>
    {
        #region Business Methods

		
        public string Client
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

		public static SM_TuitionVouch Create()
        {
            return EF.DataPortal.Create<SM_TuitionVouch>();
        }

		public static SM_TuitionVouch Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionVouch, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionVouch>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionVouch>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_TuitionVouchs))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_TuitionVouchs:ReadOnlyListBase<SM_TuitionVouchs,SM_TuitionVouch>
    {
        #region Factory Methods

        public static SM_TuitionVouchs Fetch()
        {
            return EF.DataPortal.Fetch<SM_TuitionVouchs>();
        }

		public static SM_TuitionVouchs Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionVouch, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionVouch>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionVouchs>(lambda);
		}

		public static SM_TuitionVouchs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_TuitionVouchs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_TuitionVouchs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_TuitionVouch, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_TuitionVouchs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_TuitionVouch>(exp,values)});
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
