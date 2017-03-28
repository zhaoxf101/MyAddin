using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_ConfVouch))]
#if Dev
    [RunLocal]
#endif

	public class SM_ConfVouch:ReadOnlyBase<SM_ConfVouch>
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

		
        public string ConfCode
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

		public static SM_ConfVouch Create()
        {
            return EF.DataPortal.Create<SM_ConfVouch>();
        }

		public static SM_ConfVouch Fetch(System.Linq.Expressions.Expression<Func<SM_ConfVouch, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_ConfVouch>(exp,values);
            return EF.DataPortal.Fetch<SM_ConfVouch>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_ConfVouchs))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_ConfVouchs:ReadOnlyListBase<SM_ConfVouchs,SM_ConfVouch>
    {
        #region Factory Methods

        public static SM_ConfVouchs Fetch()
        {
            return EF.DataPortal.Fetch<SM_ConfVouchs>();
        }

		public static SM_ConfVouchs Fetch(System.Linq.Expressions.Expression<Func<SM_ConfVouch, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_ConfVouch>(exp,values);
            return EF.DataPortal.Fetch<SM_ConfVouchs>(lambda);
		}

		public static SM_ConfVouchs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_ConfVouchs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_ConfVouchs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_ConfVouch, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_ConfVouchs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_ConfVouch>(exp,values)});
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
