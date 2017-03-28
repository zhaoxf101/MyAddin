using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_PaymentLogCache))]
#if Dev
    [RunLocal]
#endif

	public class SM_PaymentLogCache:ReadOnlyBase<SM_PaymentLogCache>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string DealNo
        {
            get ;
            set ;
        }

		
        public string PayWayCode
        {
            get ;
            set ;
        }

		
        public DateTime PayDateTime
        {
            get ;
            set ;
        }

		
        public decimal Amount
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
        public string StudentNo
        {
            get ;
            set ;
        }

		
        public string Staff
        {
            get ;
            set ;
        }

		
        public bool? IsDelete
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_PaymentLogCache Create()
        {
            return EF.DataPortal.Create<SM_PaymentLogCache>();
        }

		public static SM_PaymentLogCache Fetch(System.Linq.Expressions.Expression<Func<SM_PaymentLogCache, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_PaymentLogCache>(exp,values);
            return EF.DataPortal.Fetch<SM_PaymentLogCache>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_PaymentLogCaches))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_PaymentLogCaches:ReadOnlyListBase<SM_PaymentLogCaches,SM_PaymentLogCache>
    {
        #region Factory Methods

        public static SM_PaymentLogCaches Fetch()
        {
            return EF.DataPortal.Fetch<SM_PaymentLogCaches>();
        }

		public static SM_PaymentLogCaches Fetch(System.Linq.Expressions.Expression<Func<SM_PaymentLogCache, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_PaymentLogCache>(exp,values);
            return EF.DataPortal.Fetch<SM_PaymentLogCaches>(lambda);
		}

		public static SM_PaymentLogCaches Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_PaymentLogCaches>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_PaymentLogCaches Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_PaymentLogCache, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_PaymentLogCaches>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_PaymentLogCache>(exp,values)});
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
