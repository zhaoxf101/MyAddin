using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_PaymentLog))]
#if Dev
    [RunLocal]
#endif

	public class SM_PaymentLog:ReadOnlyBase<SM_PaymentLog>
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

		
        public bool IsConf
        {
            get ;
            set ;
        }

		
        public bool IsExternal
        {
            get ;
            set ;
        }

		
        public string BillNo
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

		public static SM_PaymentLog Create()
        {
            return EF.DataPortal.Create<SM_PaymentLog>();
        }

		public static SM_PaymentLog Fetch(System.Linq.Expressions.Expression<Func<SM_PaymentLog, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_PaymentLog>(exp,values);
            return EF.DataPortal.Fetch<SM_PaymentLog>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_PaymentLogs))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_PaymentLogs:ReadOnlyListBase<SM_PaymentLogs,SM_PaymentLog>
    {
        #region Factory Methods

        public static SM_PaymentLogs Fetch()
        {
            return EF.DataPortal.Fetch<SM_PaymentLogs>();
        }

		public static SM_PaymentLogs Fetch(System.Linq.Expressions.Expression<Func<SM_PaymentLog, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_PaymentLog>(exp,values);
            return EF.DataPortal.Fetch<SM_PaymentLogs>(lambda);
		}

		public static SM_PaymentLogs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_PaymentLogs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_PaymentLogs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_PaymentLog, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_PaymentLogs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_PaymentLog>(exp,values)});
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
