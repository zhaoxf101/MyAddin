using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_ConfBillVouch))]
#if Dev
    [RunLocal]
#endif

	public class SM_ConfBillVouch:ReadOnlyBase<SM_ConfBillVouch>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ConfCode
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

		
        public string TransactionDate
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public decimal ConfAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_ConfBillVouch Create()
        {
            return EF.DataPortal.Create<SM_ConfBillVouch>();
        }

		public static SM_ConfBillVouch Fetch(System.Linq.Expressions.Expression<Func<SM_ConfBillVouch, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_ConfBillVouch>(exp,values);
            return EF.DataPortal.Fetch<SM_ConfBillVouch>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_ConfBillVouchs))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_ConfBillVouchs:ReadOnlyListBase<SM_ConfBillVouchs,SM_ConfBillVouch>
    {
        #region Factory Methods

        public static SM_ConfBillVouchs Fetch()
        {
            return EF.DataPortal.Fetch<SM_ConfBillVouchs>();
        }

		public static SM_ConfBillVouchs Fetch(System.Linq.Expressions.Expression<Func<SM_ConfBillVouch, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_ConfBillVouch>(exp,values);
            return EF.DataPortal.Fetch<SM_ConfBillVouchs>(lambda);
		}

		public static SM_ConfBillVouchs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_ConfBillVouchs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_ConfBillVouchs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_ConfBillVouch, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_ConfBillVouchs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_ConfBillVouch>(exp,values)});
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
